using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CWMsgBox;
using CWUI;
using SayiTahminOyunu.GlobalSiniflar;
using SayiTahminOyunu.NumerikSiniflar;
using SayiTahminOyunu.ProfilSiniflar;
using System.Reflection;
using System.Globalization;
using SayiTahminOyunu.PhraseSiniflar;

namespace SayiTahminOyunu
{
  
    public partial class SayiTahmin : Form
    {
        private bool CWMode { get; set; }
        public SayiTahminGame ActiveGame { get; set; }
        public UserProfileStatsRecorder UserProfileStatsGenerator { get; set; }
        private ComboBox YesNoCombo = null;
        public SayiTahmin()
        {
            InitializeComponent();

        }
        /// <summary>
        /// EditListView deki itemleri Reflection yardımıyla SayiTahminIcerik sınıfına çeviriyoruz.
        /// </summary>
        /// <param name="prototype"></param>
        /// <returns></returns>
        SayiTahminIcerik lvStartGameToSayiTahmin(SayiTahminIcerik prototype)
        {
            SayiTahminIcerik stIcerik = prototype ?? new SayiTahminIcerik();
            Type type = stIcerik.GetType();
            foreach (ListViewItem lvItem in lvStartGame.Items)
            {
                PropertyInfo pInfo = type.GetProperty(lvItem.Name);
                Type mtype = pInfo.PropertyType;
                TypeConverter tconvert = TypeDescriptor.GetConverter(mtype);
                string itemtext = lvItem.SubItems[1].Text;
                if(mtype == typeof(bool))
                {
                    itemtext = (itemtext == YesNoCombo.Items[0].ToString()).ToString();
                }
                object obj = tconvert.ConvertFromString(itemtext);
                pInfo.SetValue(stIcerik, obj);
            }
            return stIcerik;
        }
        /// <summary>
        /// Reflection ile SayiTahminIcerik sınıfının içeriğini EditListView'e aktaracağız.
        /// </summary>
        /// <param name="icerik"></param>
        void fillStartGameLv(SayiTahminIcerik icerik)
        {
            lvStartGame.Items.Clear();
            Type type = icerik.GetType();
            PropertyInfo[] allProperties = type.GetProperties();
            foreach (var property in allProperties)
            {
                if (property.CustomAttributes == null) continue;
                var cdata = (SayiTahminAttribute) property.GetCustomAttribute(typeof(SayiTahminAttribute));
                if (cdata == null) continue;
                ListViewItem lvItem = new ListViewItem()
                {
                    Name = property.Name,
                    Text = GlobalVariants.PhraseList[cdata.Description]?.Text ?? cdata.Description
                };
                ListViewItem.ListViewSubItem lvSubItem = new ListViewItem.ListViewSubItem();
                if(property.PropertyType == typeof(bool))
                {

                    if ((bool)property.GetValue(icerik, null))
                    {
                        lvSubItem.Text = YesNoCombo.Items[0].ToString();
                    }
                    else
                    {
                        lvSubItem.Text = YesNoCombo.Items[1].ToString();
                    }
                }
                else
                {
                    lvSubItem.Text = property.GetValue(icerik, null)?.ToString();
                }

                EditListView.EditItemTag editItemTag = new EditListView.EditItemTag(cdata.Group);
                lvSubItem.Tag = editItemTag;
                lvItem.SubItems.Add(lvSubItem);
                lvStartGame.Items.Add(lvItem);

            }
        }
        /// <summary>
        /// Edit listview combobxlarını oluşturuyoruz.
        /// </summary>
        void createStartGameGroup()
        {
            lvStartGame.ComboBoxEkle("sayi_0-180", 0, new string[] { "0", "15", "30", "60", "90", "120", "150", "180" }, true);
            lvStartGame.ComboBoxEkle("rakam_1-10", 0, new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" }, true);
            lvStartGame.ComboBoxEkle("sayi_0-20", 0, new string[] { "0", "2", "5", "10", "15", "20" }, true);
            YesNoCombo = lvStartGame.ComboBoxEkle("EvetHayır", 0, new string[] { GlobalVariants.PhraseList["YESNO_YES"]?.Text, GlobalVariants.PhraseList["YESNO_NO"]?.Text }, true);
        }
        /// <summary>
        /// Girişte profilin seçilip seçilmediğini kontrol eder.
        /// </summary>
        public async void CheckProfile(bool norebember = false)
        {
            //Bir önceki oturumda seçimi hatırla seçeneği işaretli ise hatırlanan profili yükler.
            if(!norebember)
            {
                GlobalVariants.ActiveProfile = await ProfileSelector.GetRebemberProfile();
                if (GlobalVariants.ActiveProfile != null) GlobalVariants.ActiveProfile.LastactivityDate = DateTime.Now;
            }
            if (GlobalVariants.ActiveProfile == null)
            {
                this.Visible = false;
                GlobalVariants.ActiveProfile = ProfileSelector.SelectProfile();
                if (GlobalVariants.ActiveProfile == null) return;
                this.Visible = true;
            }
            grpStartGame.SetText(GlobalVariants.ActiveProfile?.ProfileName);
            if (GlobalVariants.ActiveProfile.LastGameProp == null)
            {
                GlobalVariants.ActiveProfile.LastGameProp = new SayiTahminIcerik();
            }
            GlobalVariants.ActiveProfile.LastGameProp.VectorelMode = false;
            fillStartGameLv(GlobalVariants.ActiveProfile.LastGameProp);
            GlobalVariants.ActiveProfile.LastGameProp.VectorelMode = CWMode;
            starZorluk.YıldızPuanı = SayiTahminChecker.GetDifficultLevel(GlobalVariants.ActiveProfile.LastGameProp);
            UserProfileStatsGenerator.RecordProfile(GlobalVariants.ActiveProfile, ActiveGame);
            disableWarningsToolStripMenuItem.Checked = !GlobalVariants.ActiveProfile.DisableWarnings;

        }
        private void btnNumericsClick(object sender, EventArgs e)
        {
            if (txtInput.Text.Length >= txtInput.MaxLength)
            {
                txtInput.Focus();
                return;
            }
            CwButton btn = sender as CwButton;
            if (btn == null) return;
            int bnum = int.Parse(btn.Name.Substring((2)));
            txtInput.SelectedText += bnum;
            txtInput.Focus();
        }
        private void SetNumericEnabledStatus(bool value)
        {
            for (int i = 0; i < 10; i++)
            {
                CwButton btn = tablelayoutNumeric.Controls["bt" + i] as CwButton;
                if (btn != null) btn.Enabled = value;
            }
            btnDelete.Enabled = value;
        }
        private bool FormActivated = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            yeniOyunToolStripMenuItem.Enabled = false;
            tekrarBaşlatCtrlRToolStripMenuItem.Enabled = false;
            this.KeyPreview = true;
            UserProfileStatsGenerator = new UserProfileStatsRecorder();
            ActiveGame = new SayiTahminGame();
            ActiveGame.GameStarted += ActiveGame_GameStarted;
            ActiveGame.GameFinished += ActiveGame_GameFinished;
            ActiveGame.TimeDecreased += ActiveGame_TimeDecreased;
            ActiveGame.LifeDecreased += ActiveGame_LifeDecreased;
            ActiveGame.EnteredGuess += ActiveGame_EnteredGuess;

            phraseComponent1.SetAllControlTextByName(this);
            phraseComponent1.SetAllBindedControlText();
            if(this.CWMode)
            {
                this.SetText(GlobalVariants.GameVersion + " (Cyber-Warrior Mode)");
            }
            else
            {
                this.SetText(GlobalVariants.GameVersion);
            }
           
            lvStartGame.SetAllColumnsText();
            CheckProfile();
            createStartGameGroup();
            btBack.RoundCorners = true;
            btBack.RoundedCorners = CWKöşeler.SolAlt | CWKöşeler.SolÜst;
            btBack.BorderRadius = 15;
            btRestart.RoundCorners = true;
            btRestart.RoundedCorners = CWKöşeler.SağAlt | CWKöşeler.SağÜst;
            btRestart.BorderRadius = 15;
            rtbHistory.Text = String.GetLangText("STI_GAME_GUESS_HST");
            rtbHistory.HeaderVAlign = DikeyHiza.CWDHOrta;
            rtbHistory.HeaderHAlign = YatayHiza.CWYHOrta;
            for (int i = 0; i < 10; i++)
            {
                CwButton btn = tablelayoutNumeric.Controls["bt" + i] as CwButton;
                if(btn != null) btn.Click += btnNumericsClick;
            }
        }

        private void ActiveGame_EnteredGuess(object sender, EnteredGuessEventArgs e)
        {
            lblSonuc.SetText(e.Guess, e.GuessResults, ActiveGame.TotalGuessCount);
            if(ActiveGame.SayiTahminData.GecmisiGoster)
            {
                StringBuilder ResultsText = new StringBuilder();
                rtbHistory.mRichTextBox.Select(rtbHistory.Text.Length, 0);
                ToRtf toRtf = new ToRtf();
                if(CWMode)
                {
                    string equaltfmt = "<font color=limegreen>{0}</font>";
                    string equalondiffertfmt = "<font color=orangered>{0}</font>";
                    foreach (var compareResult in e.GuessResults.TargetTextResults)
                    {
                        char gchar = compareResult.CharValue;
                        switch (compareResult.CompareResults)
                        {
                            case NumberCompareResultEnum.NotEquals:
                            default:
                                ResultsText.Append(gchar);
                                break;
                            case NumberCompareResultEnum.Equals:
                                ResultsText.AppendFormat(equaltfmt, gchar);
                                break;
                            case NumberCompareResultEnum.EqualsOnDiffer:
                                ResultsText.AppendFormat(equalondiffertfmt, gchar);
                                break;
                        }
                    }
                    toRtf.KaynakMetin = string.Format("{0}: <font size=10><b>{1}</b></font>(<font size=8>{2}</font>)", ActiveGame.TotalGuessCount, ResultsText, e.GuessResults);
                }
                else
                {
                    toRtf.KaynakMetin = string.Format("{0}: <font size=10><b>{1}</b></font>(<font size=8>{2}</font>)", ActiveGame.TotalGuessCount,  e.Guess, e.GuessResults);
                }
                rtbHistory.SelectedRtf = toRtf.HtmlToRtf();
                rtbHistory.mRichTextBox.ScrollToCaret();
            }
        }

        private void ActiveGame_LifeDecreased(object sender, EventArgs e)
        {
            btnRemain.Text = ActiveGame.LifeLeft.ToString();
        }

        private void ActiveGame_TimeDecreased(object sender, EventArgs e)
        {
            pbSure.Invoke((MethodInvoker)delegate { pbSure.Text = String.GetLangText("pbSure_alter", --pbSure.Değer); });
        }

        private void ActiveGame_GameFinished(object sender, GameFinishedEventArgs e)
        {
            if (e.IsAborted) return;
            string infotext = "";
            switch (e.FinishType)
            {
                case GameFinishType.GameFinish_Win:
                    infotext = String.GetLangText("STI_GAME_WIN", ActiveGame.ActiveNumber);
                    break;
                case GameFinishType.GameFinish_LoseResign:
                    infotext = String.GetLangText("STI_GAME_LOSE_RSG", ActiveGame.ActiveNumber);
                    break;
                case GameFinishType.GameFinish_LoseTimeOver:
                    infotext = String.GetLangText("STI_GAME_LOSE_TIME", ActiveGame.ActiveNumber);
                    break;
                case GameFinishType.GameFinish_LOseLifeOver:
                    infotext = String.GetLangText("STI_GAME_LOSE_LIFE", ActiveGame.ActiveNumber);
                    break;
                default:
                    break;
            }
            infotext += "\r";
            infotext += String.GetLangText("STI_GAME_STATS", (DateTime.Now - ActiveGame.GameStartedAt).TotalSeconds, ActiveGame.TotalGuessCount, ActiveGame.TotalPlus, ActiveGame.TotalMinus);
            if (e.FinishType == GameFinishType.GameFinish_LoseTimeOver)
            {

                this.Invoke((MethodInvoker)delegate {
                    lblInfoBottom.Text = infotext;
                    btnTahminYap.Enabled = false;
                    txtInput.Enabled = false;
                    SetNumericEnabledStatus(false);
                    btRestart.Text = String.GetLangText("btRestart_After");
                });
            }
            else
            {
                lblInfoBottom.Text = infotext;
                btnTahminYap.Enabled = false;
                txtInput.Enabled = false;
                SetNumericEnabledStatus(false);
                btRestart.Text = String.GetLangText("btRestart_After");
            }

        }

        private void ActiveGame_GameStarted(object sender, GameStartedEventArgs e)
        {
            if(ActiveGame.TimeLeft <= 0)
            {
                pbSure.SetText();

                pbSure.Maximum = 100;
                pbSure.Değer = pbSure.Maximum;
            }
            else
            {
                pbSure.Maximum = ActiveGame.TimeLeft;
                pbSure.Değer = pbSure.Maximum;
                pbSure.Text = String.GetLangText("pbSure_alter", pbSure.Maximum);
            }
            if(ActiveGame.LifeLeft <= 0)
            {
                btnRemain.Text = "∞";
            }
            else
            {
                btnRemain.Text = ActiveGame.LifeLeft.ToString();
            }
            string rfarklitext;
            if(ActiveGame.SayiTahminData.RakalmarFarkli)
            {
                rfarklitext = String.GetLangText("YESNO_YES");
            }
            else
            {
                rfarklitext = String.GetLangText("YESNO_NO");
            }
            grpGame.SetText(ActiveGame.ActiveNumber.Length, rfarklitext, ActiveGame.DifficultLevel, 6);
            string bsmktext = "";
            if(ActiveGame.SayiTahminData.MinBasamak == ActiveGame.SayiTahminData.MaxBasamak)
            {
                bsmktext = ActiveGame.SayiTahminData.MinBasamak.ToString();
            }
            else
            {
                bsmktext = string.Format("{0}-{1}", ActiveGame.SayiTahminData.MinBasamak, ActiveGame.SayiTahminData.MaxBasamak);
            }
            lblInfo.SetText(pbSure.Text, bsmktext, rfarklitext, btnRemain.Text);
            txtInput.MaxLength = ActiveGame.ActiveNumber.Length;
            txtInput.Text = "";
            grpGame.Visible = true;
            grpStartNew.Visible = false;
            rtbHistory.Text = "";
            lblSonuc.Text = " ";
            lblInfoBottom.Text = " ";
            btnTahminYap.Enabled = false;
            txtInput.Enabled = true;
            SetNumericEnabledStatus(true);
            btRestart.SetText();
            if (!ActiveGame.SayiTahminData.GecmisiGoster)
            {
                rtbHistory.Text = String.GetLangText("STI_GAME_GUESS_HST_DIS");
            }
        }

        private void txtInput_KeyDown(object sender, KeyEventArgs e)
        {
            //Backspace veya Enter ise müdahe etmiyoruz.
            if(e.KeyCode == Keys.Back || e.KeyCode == Keys.Enter)
            {
                return;
            }
            int ittl = (int)e.KeyCode - 96;
            if (ittl < 10 && ittl >= 0)
            {

                return;
            }
            char Chr = (char)e.KeyValue;

        
            if(!char.IsDigit(Chr))
            {
                //Eğer girilen basılan tuş numerik değilse, metni Text e yazdırmaması için aşağıdaki değer true yapacağız.
                e.SuppressKeyPress = true;
                return;
            }
        }

        private void btnTahminYap_Click(object sender, EventArgs e)
        {
            if (!ActiveGame.IsGameStarted) return;
            string inputtext = txtInput.Text.TrimStart('0');
            if(inputtext.Length != ActiveGame.ActiveNumber.Length)
            {
                Mesaj.mbox.Göster(String.GetLangText("GAME_ERR_THM_LEN", ActiveGame.ActiveNumber.Length));
                return;
            }
            ActiveGame.EnterGuess(inputtext);
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MesajSonuç msonuc = Mesaj.mbox.Göster(String.GetLangText("GLB_APP_EXIT"), String.GetLangText("GLB_APP_EXIT_HDR"), MessageBoxButtons.YesNo);
            if (msonuc.MesajCevap != DialogResult.Yes) return;
            Application.Exit();
        }

        private void KelimeOyunu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Uygulamadan çıkış yapıldığında geçerli profil dosyasına kayıt yapar.
            if (ActiveGame.IsGameStarted)
            {
                ActiveGame.Abort();
            }
            UserProfileUtils.SaveUserProfile(GlobalVariants.ActiveProfile);
            GlobalSettings.SaveSettings();
        }

        private void profilDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string oldname = GlobalVariants.ActiveProfile.ProfileName;
            UserProfile uProfil = ProfileSelector.SelectProfile();
            if(uProfil != null && oldname != uProfil.ProfileName)
            {
                if (ActiveGame.IsGameStarted) ActiveGame.Resign();
                grpStartNew.Visible = true;
                grpGame.Visible = false;
                UserProfileUtils.SaveUserProfile(GlobalVariants.ActiveProfile);
                GlobalVariants.ActiveProfile = uProfil;
                UserProfileStatsGenerator.RecordProfile(GlobalVariants.ActiveProfile, ActiveGame);
            }


        }

        private void lvStartGame_EditCommit(object sender, EditListView.mEditCommit e)
        {
            SayiTahminIcerik sti = lvStartGameToSayiTahmin(null);
            ReflectFunctions.SetPropertyValueDirect(sti, e.BaseItem.Name, e.Value, YesNoCombo.Items[0].ToString());
            GlobalVariants.ActiveProfile.LastGameProp = sti;
            refreshYildizPuani(sti);

        }
        private void refreshYildizPuani(SayiTahminIcerik sti)
        {
            sti.VectorelMode = CWMode;
            starZorluk.YıldızPuanı = SayiTahminChecker.GetDifficultLevel(sti);
        }
        private void btnStartGame_Click(object sender, EventArgs e)
        {
          
            SayiTahminIcerik sti = lvStartGameToSayiTahmin(null);
            sti.VectorelMode = CWMode;
            if (sti.MinBasamak > sti.MaxBasamak)
            {
                
                Mesaj.mbox.Göster(String.GetLangText("GLB_ERROR_MINMAX"));
                return;
            }
            if (ActiveGame.IsGameStarted) return;
            GlobalVariants.ActiveProfile.LastGameProp = sti;
            ActiveGame.StartGame(sti, GlobalVariants.ActiveProfile);
            //starZorluk.YıldızPuanı = SayiTahminChecker.GetDifficultLevel(GlobalVariants.ActiveProfile.LastGameProp);
        }

        private void txtInput_TextChanged(object sender, EventArgs e)
        {
            if(txtInput.Text.Length == ActiveGame.ActiveNumber.Length)
            {
                btnTahminYap.Enabled = true;
            }
            else
            {
                btnTahminYap.Enabled = false;
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(txtInput.Text.Length <= 0)
            {
                txtInput.Focus();
                return;
            }
            if(txtInput.SelectedText.Length > 0)
            {
                txtInput.SelectedText = "";
                txtInput.Focus();
                return;
            }
            if(txtInput.SelectionStart == 0)
            {
                txtInput.Focus();
                return;
            }
            int selstart = txtInput.SelectionStart - 1;
            txtInput.Text = txtInput.Text.Remove(txtInput.SelectionStart - 1, 1);
            txtInput.SelectionLength = 0;
            txtInput.SelectionStart = selstart;
            txtInput.Focus();
        }

        private void closeProfileToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MesajSonuç mesajSonuç = Mesaj.mbox.Göster(String.GetLangText("MENU_PROF_CLOSE_PRMPT"), "", MessageBoxButtons.YesNo);
            if(mesajSonuç.MesajCevap == DialogResult.Yes)
            {
                UserProfileUtils.SaveUserProfile(GlobalVariants.ActiveProfile);
                if (ActiveGame.IsGameStarted) ActiveGame.Abort();
                GlobalVariants.ActiveProfile = null;
                CheckProfile(true);
            }
        }
        private void btBack_Click(object sender, EventArgs e)
        {
            if (ActiveGame.IsGameStarted)
            {
                MesajSonuç msonuc = Mesaj.mbox.Göster(String.GetLangText("STI_GAME_RETURN"), String.GetLangText("STI_GAME_RETURN_HDR"), MessageBoxButtons.YesNo);
                if (msonuc.MesajCevap != DialogResult.Yes) return;
                ActiveGame.Resign();
            }
            grpGame.Visible = false;
            grpStartNew.Visible = true;
            lblInfo.Text = "";
        }

        private void lblInfo_Click(object sender, EventArgs e)
        {

        }

        private void btRestart_Click(object sender, EventArgs e)
        {
            if(ActiveGame.IsGameStarted)
            {
                if(!GlobalVariants.ActiveProfile.DisableWarnings)
                {
                    MesajSonuç msonuc = Mesaj.mbox.Göster(String.GetLangText("STI_GAME_RESIGN"), String.GetLangText("STI_GAME_RETURN_HDR"), MessageBoxButtons.YesNo);
                    if (msonuc.MesajCevap != DialogResult.Yes) return;
                }
                ActiveGame.Resign();
                return;
            }
            ActiveGame.RestartGame();
      
        }

        private void yeniOyunToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!grpStartNew.Visible)
                btBack.PerformClick();
        }

        private void sTATSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(ActiveGame.IsGameStarted)
            {
                Mesaj.mbox.Göster(String.GetLangText("MENU_SHOW_STATS_ERROR"));
                return;
            }
            ProfileStatistics.ShowStatistics(GlobalVariants.ActiveProfile);
          
        }
        DateTime lastkeydowndate = DateTime.Now;
        string activekey = "";
        string veckey = "Cyber-Warrior";
        private void SayiTahmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!FormActivated || CWMode || ActiveGame.IsGameStarted || !grpStartNew.Visible)
            {
                return;
            }
            if ((DateTime.Now - lastkeydowndate).TotalSeconds > 3.0)
            {
                activekey = "";
            }
            if(e.KeyChar == '\b')
            {
                if(activekey.Length > 0)
                {
                    activekey = activekey.Substring(0, activekey.Length - 1);
                    if(activekey.Length < 3)
                    {
                        lblVectorel.Visible = false;
                    }
                    else
                    {
                        lblVectorel.Text = CreateVecLabelString();
                    }
                    return;
                }
            }
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != '-')
            {
                return;
            }
            activekey += e.KeyChar;
            if(!veckey.StartsWith(activekey))
            {
                activekey = "";
            }
            if(activekey == veckey)
            {
                this.SetCWTheme();
                CWMode = true;
                lblVectorel.Text = CreateVecLabelString();
                tmrVectorel.Enabled = false;
                lvStartGame.Items["GecmisiGoster"].SubItems[1].Text = YesNoCombo.Items[0].ToString();
                this.SetText(GlobalVariants.GameVersion + " (Cyber-Warrior Mode)");
                refreshYildizPuani(lvStartGameToSayiTahmin(null));
                Mesaj.mbox.Göster(String.GetLangText("VEK_MD_ENABLED"), String.GetLangText("VEK_MD_ENABLED_HDR"));
                lblVectorel.Visible = false;
                this.Focus();
                return;
            }
            lastkeydowndate = DateTime.Now;
            if(activekey.Length >= 3)
            {
                lblVectorel.Visible = true;
                lblVectorel.Text = CreateVecLabelString();
            }
            else
            {
                lblVectorel.Visible = false;
            }
        }

        private string CreateVecLabelString()
        {
            string totaltext = "";
            if(activekey.Length > 0)
            {
                totaltext = string.Format("<b>{0}</b>", activekey);
            }
            if(activekey.Length < veckey.Length)
            {
                totaltext += veckey.Substring(activekey.Length);
            }
            return totaltext;

        }

        private void vecTimer_Tick(object sender, EventArgs e)
        {
            if ((DateTime.Now - lastkeydowndate).TotalSeconds > 3.0)
            {
                activekey = "";
                lblVectorel.Visible = false;
            }
        }

        private void lvStartGame_EditOpening(object sender, EditListView.mEditOpening e)
        {
            if(CWMode && e.BaseItem.Name == "GecmisiGoster")
            {
                e.Cancel = 1;
                return;
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if(grpGame.Visible)
            {
                if(keyData == (Keys.Control | Keys.R))
                {
                    tekrarBaşlatCtrlRToolStripMenuItem.PerformClick();
                }
                else if(keyData == (Keys.Control | Keys.N))
                {
                    yeniOyunToolStripMenuItem.PerformClick();
                }
                else if(keyData == Keys.Escape)
                {
                    btBack.PerformClick();
                }
            }
            else if(grpStartNew.Visible && !ActiveGame.IsGameStarted)
            {
                if (keyData == Keys.Enter)
                {
                    btnStartGame.PerformClick();
                }
            }


            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void SayiTahmin_Activated(object sender, EventArgs e)
        {
            FormActivated = true;
        }

        private void SayiTahmin_Deactivate(object sender, EventArgs e)
        {
            FormActivated = false;
        }

        private void txtInput_KeyUp(object sender, KeyEventArgs e)
        {
            if(ActiveGame.IsGameStarted)
            {
                if(e.KeyCode == Keys.Enter)
                {
                    btnTahminYap.PerformClick();
                }
            }
        }

        private void grpStartNew_VisibleChanged(object sender, EventArgs e)
        {
            if(grpStartNew.Visible)
            {
                yeniOyunToolStripMenuItem.Enabled = false;
                tekrarBaşlatCtrlRToolStripMenuItem.Enabled = false;
            }
            else
            {
                yeniOyunToolStripMenuItem.Enabled = true;
                tekrarBaşlatCtrlRToolStripMenuItem.Enabled = true;
            }
        }

        private void tekrarBaşlatCtrlRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!grpGame.Visible) return;
            if (ActiveGame.IsGameStarted)
            {
                if(!GlobalVariants.ActiveProfile.DisableWarnings)
                {
                    MesajSonuç msonuc = Mesaj.mbox.Göster(String.GetLangText("STI_GAME_RESTART"), String.GetLangText("STI_GAME_RETURN_HDR"), MessageBoxButtons.YesNo);
                    if (msonuc.MesajCevap != DialogResult.Yes) return;
                }

            }
            ActiveGame.RestartGame();
        }

        private void disableWarningsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(!GlobalVariants.ActiveProfile.DisableWarnings)
            {
                MesajSonuç msonuc = Mesaj.mbox.Göster(String.GetLangText("MENU_DIS_WARNINGS_INF"), String.GetLangText("MENU_DIS_WARNINGS_INF_HDR"), MessageBoxButtons.YesNo);
                if (msonuc.MesajCevap != DialogResult.Yes) return;

            }
            GlobalVariants.ActiveProfile.DisableWarnings = !GlobalVariants.ActiveProfile.DisableWarnings;
            disableWarningsToolStripMenuItem.Checked = !GlobalVariants.ActiveProfile.DisableWarnings;
        }
        private void SetCWTheme()
        {
            this.menuStrip1.BackColor = Color.LimeGreen;
            this.grpStartGame.HeaderColorA = Color.Lime;
            this.grpStartGame.HeaderColorB = Color.White;
            this.grpStartGame.ForeColor = Color.Green;
            this.grpGame.HeaderColorB = Color.LimeGreen;
            this.grpStartNew.HeaderColorB = Color.LimeGreen;
            this.cwContainerFooter1.Renkler = new Color[] { Color.Lime, Color.Green };
        }
    }
}
