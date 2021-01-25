using SayiTahminOyunu.StatisticSiniflar;
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
using SayiTahminOyunu.ProfilSiniflar;
using System.IO;

namespace SayiTahminOyunu
{
    public partial class ProfileSelector : Form
    {
        UserProfile uProfil = null;
        /// <summary>
        /// Diğer formdan profil seçtirmek için kullanacağımız fonksiyon.
        /// </summary>
        /// <returns></returns>
        public static UserProfile SelectProfile()
        {
            ProfileSelector pselector = new ProfileSelector();
            pselector.ShowDialog();
            //Başlıca istatistikler yoksa sıralamada üstte görünsünler diye otomatik eklenecek.
            UserProfileUtils.InitializeStatistics(pselector.uProfil);
            return pselector.uProfil;
        }
        /// <summary>
        /// Bir önceki uygulama açılışında seçimi hatırla seçeneği işaretlenen profili dönderir.
        /// </summary>
        /// <returns>Profil yüklenemediyse null diğer türlü UserProfile türünden dönüş yapar</returns>
        public static Task<UserProfile> GetRebemberProfile()
        {
            return Task.Run<UserProfile>(() => 
            {
                if (!GlobalSettings.Settings.RebemmerChecked) return null;
                return UserProfileUtils.LoadUserProfile(GlobalSettings.Settings.RebemmerName);
            }); ;
        }
        public ProfileSelector()
        {
            InitializeComponent();
            btnNew.RoundCorners = true;
            btnNew.RoundedCorners = CWUI.CWKöşeler.SolAlt | CWUI.CWKöşeler.SolÜst;
            btnDelete.RoundCorners = true;
            btnDelete.RoundedCorners = CWUI.CWKöşeler.SağAlt | CWUI.CWKöşeler.SağÜst;
            pbLoadProfile.Dock = DockStyle.Fill;
            cbRebemmer.Checked = GlobalSettings.Settings.RebemmerChecked;
            FillUserProfiles();
         
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            //Eğer ilk defa profil seçilirken Çıkış tuşuna basılırsa uygulamayı kapatır.
            //Profil değiştirmek için basılırsa sadece bu formu kapatır.
            if(GlobalVariants.ActiveProfile == null)
            {
                Application.Exit();
            }
            else
            {
                uProfil = null;
                this.Close();
            }
            
        }

        private async void btnContinue_Click(object sender, EventArgs e)
        {
            string SelectedProfile = "";

   
            if (lvProfiles.SelectedItems.Count == 0) return;
            SelectedProfile = lvProfiles.SelectedItems[0].SubItems[1].Text;
            //Devam etmek istenen profil aktif profil ise yeniden yükleme yapmayacak.
            if(SelectedProfile == GlobalVariants.ActiveProfile?.ProfileName)
            {
                goto endofaction;
            }
            pbLoadProfile.Visible = true;
            UserProfile Uprofil = await Task.Run<UserProfile>(() => UserProfileUtils.LoadUserProfile(SelectedProfile));
            if(Uprofil == null)
            {
                new Mesaj().Göster(String.GetLangText("PRF_ERR_PROFILE_LOAD"));
                goto endofaction;
            }
            if(GlobalSettings.Settings.RebemmerChecked)
            {
                GlobalSettings.Settings.RebemmerName = SelectedProfile;
            }
            Uprofil.LastactivityDate = DateTime.Now;
            uProfil = Uprofil;

        endofaction:
            pbLoadProfile.Visible = false;
            this.Close();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string SelectedProfile = "";
            if (lvProfiles.SelectedItems.Count == 0) return;
            SelectedProfile = lvProfiles.SelectedItems[0].SubItems[1].Text;
            Mesaj Msj = new Mesaj();
            MesajSonuç Msonuc = Msj.Göster(String.GetLangText("PRF_DEL_CONFIRM"), String.GetLangText("PRF_DEL_CONFIRM_HDR", SelectedProfile), MessageBoxButtons.YesNo);
            if(Msonuc.MesajCevap == DialogResult.Yes)
            {
                UserProfileUtils.DeleteUserProfile(SelectedProfile);
                lvProfiles.Items.Remove(lvProfiles.SelectedItems[0]);
            }

        }
        private void btnNew_Click(object sender, EventArgs e)
        {
            Mesaj Msj = new Mesaj();
           
            MesajSonuç Msonuc = Msj.Input(String.GetLangText("PRF_ADD_INPUT", string.Join(", ", ProfilSiniflar.UserProfileUtils.FileNameErroredChars)), String.GetLangText("PRF_ADD_INPUT_HDR"), "");
            if(Msonuc.MesajCevap != DialogResult.OK)
            {
                return;
            }
            string errormsg;
            if (!UserProfileUtils.CanCreateUserProfile(Msonuc.Sonuç, out errormsg))
            {
                Msj.Göster(String.GetLangText("PRF_ADD_ERR_HM", errormsg), String.GetLangText("PRF_ADD_ERR_HDR"));
                return;
            }
            UserProfile UProfil = UserProfileUtils.CreateUserProfile(Msonuc.Sonuç);
            if(UProfil == null)
            {
                Msj.Göster(String.GetLangText("PRF_ADD_ERR_NOTCREATE"), String.GetLangText("PRF_ADD_ERR_HDR"));
            }
            ListViewItem Lvi = new ListViewItem()
            {
                Text = (lvProfiles.Items.Count + 1).ToString()
            };
            Lvi.SubItems.Add(UProfil.ProfileName);
            lvProfiles.Items.Add(Lvi);

        }
        void FillUserProfiles()
        {
            lvProfiles.Items.Clear();
   
            lvProfiles.BeginUpdate();
            for (int i = 0; i < GlobalVariants.ExistingProfiles.Count; i++)
            {
                ListViewItem Lvi = new ListViewItem()
                {
                    Text = (i + 1).ToString()
                };

                string pname = Path.GetFileNameWithoutExtension(GlobalVariants.ExistingProfiles[i]);
                Lvi.SubItems.Add(pname);
                //Eğer seçili profil ise Arka planı yeşil yazı rengi beyaz olacak.
                if(pname == GlobalVariants.ActiveProfile?.ProfileName)
                {
                    Lvi.BackColor = Color.Green;
                    Lvi.ForeColor = Color.White;
                }
                lvProfiles.Items.Add(Lvi);
            }
            lvProfiles.EndUpdate();

        }

        private void lvProfiles_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(lvProfiles.SelectedItems.Count > 0)
            {
                string SelectedProfile = lvProfiles.SelectedItems[0].SubItems[1].Text;
                //Eğer seçilen profil aktif ise silme işlemine izin vermeyecek.
                if(SelectedProfile == GlobalVariants.ActiveProfile?.ProfileName)
                {
                    btnDelete.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                }
                btnContinue.Enabled = true;
            }
            else
            {
                btnContinue.Enabled = false;
            }
        }

        private void lvProfiles_DoubleClick(object sender, EventArgs e)
        {
            if(lvProfiles.SelectedItems.Count > 0 && btnContinue.Enabled)
            {
                btnContinue.PerformClick();
            }
        }

        private void ProfileSelector_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (GlobalVariants.ActiveProfile == null && uProfil == null)
            {
                Application.Exit();
            }
        }

        private void cbRebemmer_CheckedChanged(object sender, EventArgs e)
        {
            GlobalSettings.Settings.RebemmerChecked = cbRebemmer.Checked;
        }

        private void ProfileSelector_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(cbRebemmer, String.GetLangText("PRF_REBEMBER"));
            lvProfiles.SetAllColumnsText();
            GlobalVariants.PhraseList.SetAllControlTextByName(this);
        }
    }
}
