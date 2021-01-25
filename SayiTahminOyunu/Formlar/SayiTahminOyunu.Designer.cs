namespace SayiTahminOyunu
{
    partial class SayiTahmin
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.yeniOyunToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tekrarBaşlatCtrlRToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.çıkışToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.profilDeğiştirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sTATSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeProfileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableWarningsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grpGame = new CWUI.CWGroupBox();
            this.cwGroupBox4 = new CWUI.CWGroupBox();
            this.btRestart = new CWUI.CwButton();
            this.btBack = new CWUI.CwButton();
            this.tablelayoutGame = new System.Windows.Forms.TableLayoutPanel();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnTahminYap = new CWUI.CwButton();
            this.tablelayoutNumeric = new System.Windows.Forms.TableLayoutPanel();
            this.bt4 = new CWUI.CwButton();
            this.bt3 = new CWUI.CwButton();
            this.bt2 = new CWUI.CwButton();
            this.btnDelete = new CWUI.CwButton();
            this.bt1 = new CWUI.CwButton();
            this.bt5 = new CWUI.CwButton();
            this.bt6 = new CWUI.CwButton();
            this.bt7 = new CWUI.CwButton();
            this.bt8 = new CWUI.CwButton();
            this.bt9 = new CWUI.CwButton();
            this.bt0 = new CWUI.CwButton();
            this.rtbHistory = new CWUI.CWHaderRichTextBox();
            this.lblSonuc = new CWUI.CwLabelPlus();
            this.pbSure = new CWUI.CWProgressBar();
            this.btnRemain = new CWUI.CwButton();
            this.lblInfoBottom = new CWUI.CwLabelPlus();
            this.grpStartGame = new CWUI.CWGroupBox();
            this.grpStartNew = new CWUI.CWGroupBox();
            this.cwGroupBox2 = new CWUI.CWGroupBox();
            this.starZorluk = new CWUI.CWStars();
            this.lblDifficult = new CWUI.CWLabel();
            this.lvStartGame = new CWUI.EditListView();
            this.columnSetting = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cwGroupBox3 = new CWUI.CWGroupBox();
            this.btnStartGame = new CWUI.CwButton();
            this.cwContainerFooter1 = new CWUI.CWContainerFooter();
            this.lblInfo = new CWUI.CwLabelPlus();
            this.lblVectorel = new CWUI.CwLabelPlus();
            this.tmrVectorel = new System.Windows.Forms.Timer(this.components);
            this.phraseComponent1 = new SayiTahminOyunu.PhraseSiniflar.PhraseComponent(this.components);
            this.menuStrip1.SuspendLayout();
            this.grpGame.SuspendLayout();
            this.cwGroupBox4.SuspendLayout();
            this.tablelayoutGame.SuspendLayout();
            this.tablelayoutNumeric.SuspendLayout();
            this.grpStartGame.SuspendLayout();
            this.grpStartNew.SuspendLayout();
            this.cwGroupBox2.SuspendLayout();
            this.cwGroupBox3.SuspendLayout();
            this.cwContainerFooter1.SuspendLayout();
            this.lblInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Azure;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oyunToolStripMenuItem,
            this.profilToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(498, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oyunToolStripMenuItem
            // 
            this.oyunToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yeniOyunToolStripMenuItem,
            this.tekrarBaşlatCtrlRToolStripMenuItem,
            this.çıkışToolStripMenuItem});
            this.oyunToolStripMenuItem.Name = "oyunToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.oyunToolStripMenuItem, "MENU_GAME");
            this.oyunToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.oyunToolStripMenuItem.Text = "Oyun";
            // 
            // yeniOyunToolStripMenuItem
            // 
            this.yeniOyunToolStripMenuItem.Name = "yeniOyunToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.yeniOyunToolStripMenuItem, "MENU_STARTNEW");
            this.yeniOyunToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.yeniOyunToolStripMenuItem.Text = "Yeni";
            this.yeniOyunToolStripMenuItem.Click += new System.EventHandler(this.yeniOyunToolStripMenuItem_Click);
            // 
            // tekrarBaşlatCtrlRToolStripMenuItem
            // 
            this.tekrarBaşlatCtrlRToolStripMenuItem.Name = "tekrarBaşlatCtrlRToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.tekrarBaşlatCtrlRToolStripMenuItem, "MENU_RESTART");
            this.tekrarBaşlatCtrlRToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.tekrarBaşlatCtrlRToolStripMenuItem.Text = "TB";
            this.tekrarBaşlatCtrlRToolStripMenuItem.Click += new System.EventHandler(this.tekrarBaşlatCtrlRToolStripMenuItem_Click);
            // 
            // çıkışToolStripMenuItem
            // 
            this.çıkışToolStripMenuItem.Name = "çıkışToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.çıkışToolStripMenuItem, "MENU_EXIT");
            this.çıkışToolStripMenuItem.Size = new System.Drawing.Size(97, 22);
            this.çıkışToolStripMenuItem.Text = "Çık";
            this.çıkışToolStripMenuItem.Click += new System.EventHandler(this.çıkışToolStripMenuItem_Click);
            // 
            // profilToolStripMenuItem
            // 
            this.profilToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.profilDeğiştirToolStripMenuItem,
            this.sTATSToolStripMenuItem,
            this.closeProfileToolStripMenuItem});
            this.profilToolStripMenuItem.Name = "profilToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.profilToolStripMenuItem, "MENU_PROF");
            this.profilToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.profilToolStripMenuItem.Text = "Profile";
            // 
            // profilDeğiştirToolStripMenuItem
            // 
            this.profilDeğiştirToolStripMenuItem.Name = "profilDeğiştirToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.profilDeğiştirToolStripMenuItem, "MENU_PROF_CHN");
            this.profilDeğiştirToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.profilDeğiştirToolStripMenuItem.Text = "Profili Değiştir";
            this.profilDeğiştirToolStripMenuItem.Click += new System.EventHandler(this.profilDeğiştirToolStripMenuItem_Click);
            // 
            // sTATSToolStripMenuItem
            // 
            this.sTATSToolStripMenuItem.Name = "sTATSToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.sTATSToolStripMenuItem, "MENU_PROF_STATS");
            this.sTATSToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.sTATSToolStripMenuItem.Text = "STATS";
            this.sTATSToolStripMenuItem.Click += new System.EventHandler(this.sTATSToolStripMenuItem_Click);
            // 
            // closeProfileToolStripMenuItem
            // 
            this.closeProfileToolStripMenuItem.Name = "closeProfileToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.closeProfileToolStripMenuItem, "MENU_PROF_CLOSE");
            this.closeProfileToolStripMenuItem.Size = new System.Drawing.Size(154, 22);
            this.closeProfileToolStripMenuItem.Text = "Close Profile";
            this.closeProfileToolStripMenuItem.Click += new System.EventHandler(this.closeProfileToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.disableWarningsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.settingsToolStripMenuItem, "MENU_SETTINGS");
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // disableWarningsToolStripMenuItem
            // 
            this.disableWarningsToolStripMenuItem.Checked = true;
            this.disableWarningsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.disableWarningsToolStripMenuItem.Name = "disableWarningsToolStripMenuItem";
            this.phraseComponent1.SetPhraseNameTI(this.disableWarningsToolStripMenuItem, "MENU_DIS_WARNINGS");
            this.disableWarningsToolStripMenuItem.Size = new System.Drawing.Size(169, 22);
            this.disableWarningsToolStripMenuItem.Text = "Disable Warnings";
            this.disableWarningsToolStripMenuItem.Click += new System.EventHandler(this.disableWarningsToolStripMenuItem_Click);
            // 
            // grpGame
            // 
            this.grpGame.BorderColor = System.Drawing.Color.Green;
            this.grpGame.Collapsed = true;
            this.grpGame.Controls.Add(this.cwGroupBox4);
            this.grpGame.Controls.Add(this.tablelayoutGame);
            this.grpGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpGame.HeaderColorA = System.Drawing.Color.White;
            this.grpGame.HeaderColorB = System.Drawing.Color.Azure;
            this.grpGame.HideCollapseButton = true;
            this.grpGame.Location = new System.Drawing.Point(7, 34);
            this.grpGame.MinCollapsed = 0;
            this.grpGame.Name = "grpGame";
            this.grpGame.Padding = new System.Windows.Forms.Padding(7, 34, 7, 7);
            this.phraseComponent1.SetPhraseName(this.grpGame, "STI_GAME_TEXT");
            this.grpGame.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.grpGame.RoundCorners = false;
            this.grpGame.ShowHeader = true;
            this.grpGame.Size = new System.Drawing.Size(476, 476);
            this.grpGame.TabIndex = 21;
            this.grpGame.Visible = false;
            // 
            // cwGroupBox4
            // 
            this.cwGroupBox4.BorderColor = System.Drawing.Color.Green;
            this.cwGroupBox4.Collapsed = true;
            this.cwGroupBox4.Controls.Add(this.btRestart);
            this.cwGroupBox4.Controls.Add(this.btBack);
            this.cwGroupBox4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cwGroupBox4.HeaderColorA = System.Drawing.Color.White;
            this.cwGroupBox4.HeaderColorB = System.Drawing.Color.GreenYellow;
            this.cwGroupBox4.HideCollapseButton = false;
            this.cwGroupBox4.Location = new System.Drawing.Point(7, 423);
            this.cwGroupBox4.MinCollapsed = 0;
            this.cwGroupBox4.Name = "cwGroupBox4";
            this.cwGroupBox4.Padding = new System.Windows.Forms.Padding(7);
            this.cwGroupBox4.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.cwGroupBox4.RoundCorners = false;
            this.cwGroupBox4.RoundedCorners = CWUI.CWKöşeler.Hiçbiri;
            this.cwGroupBox4.ShowHeader = false;
            this.cwGroupBox4.Size = new System.Drawing.Size(462, 46);
            this.cwGroupBox4.TabIndex = 24;
            this.cwGroupBox4.Text = "cwGroupBox4";
            // 
            // btRestart
            // 
            this.btRestart.ActiveBorder = System.Drawing.Color.DimGray;
            this.btRestart.BorderSize = 0;
            this.btRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btRestart.Dock = System.Windows.Forms.DockStyle.Right;
            this.btRestart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btRestart.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.SystemColors.Window,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Orange,
        System.Drawing.Color.White};
            this.btRestart.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btRestart.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.Silver,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Silver};
            this.btRestart.GörünümOnMouseOver.BorderColor = System.Drawing.Color.DarkGray;
            this.btRestart.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Orange,
        System.Drawing.Color.Orange,
        System.Drawing.Color.WhiteSmoke};
            this.btRestart.Location = new System.Drawing.Point(231, 7);
            this.btRestart.Name = "btRestart";
            this.btRestart.RoundCorners = false;
            this.btRestart.Size = new System.Drawing.Size(224, 32);
            this.btRestart.TabIndex = 2;
            this.btRestart.Text = "tb";
            this.btRestart.Click += new System.EventHandler(this.btRestart_Click);
            // 
            // btBack
            // 
            this.btBack.ActiveBorder = System.Drawing.Color.DimGray;
            this.btBack.BorderSize = 0;
            this.btBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btBack.Dock = System.Windows.Forms.DockStyle.Left;
            this.btBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btBack.Görünüm.BorderColor = System.Drawing.Color.Red;
            this.btBack.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.WhiteSmoke};
            this.btBack.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Red;
            this.btBack.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Gray};
            this.btBack.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btBack.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.Silver,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Silver};
            this.btBack.Location = new System.Drawing.Point(7, 7);
            this.btBack.Name = "btBack";
            this.btBack.RoundCorners = false;
            this.btBack.Size = new System.Drawing.Size(224, 32);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "gd";
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tablelayoutGame
            // 
            this.tablelayoutGame.ColumnCount = 2;
            this.tablelayoutGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tablelayoutGame.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 87F));
            this.tablelayoutGame.Controls.Add(this.txtInput, 0, 0);
            this.tablelayoutGame.Controls.Add(this.btnTahminYap, 0, 1);
            this.tablelayoutGame.Controls.Add(this.tablelayoutNumeric, 0, 3);
            this.tablelayoutGame.Controls.Add(this.lblSonuc, 0, 2);
            this.tablelayoutGame.Controls.Add(this.pbSure, 0, 4);
            this.tablelayoutGame.Controls.Add(this.btnRemain, 1, 1);
            this.tablelayoutGame.Controls.Add(this.lblInfoBottom, 0, 5);
            this.tablelayoutGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.tablelayoutGame.Location = new System.Drawing.Point(7, 34);
            this.tablelayoutGame.Name = "tablelayoutGame";
            this.tablelayoutGame.RowCount = 6;
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 45F));
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 133F));
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tablelayoutGame.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tablelayoutGame.Size = new System.Drawing.Size(462, 386);
            this.tablelayoutGame.TabIndex = 25;
            // 
            // txtInput
            // 
            this.txtInput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tablelayoutGame.SetColumnSpan(this.txtInput, 2);
            this.txtInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtInput.Location = new System.Drawing.Point(3, 3);
            this.txtInput.Name = "txtInput";
            this.txtInput.ShortcutsEnabled = false;
            this.txtInput.Size = new System.Drawing.Size(456, 62);
            this.txtInput.TabIndex = 13;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtInput.TextChanged += new System.EventHandler(this.txtInput_TextChanged);
            this.txtInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyDown);
            this.txtInput.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtInput_KeyUp);
            // 
            // btnTahminYap
            // 
            this.btnTahminYap.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnTahminYap.BorderSize = 0;
            this.btnTahminYap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTahminYap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnTahminYap.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTahminYap.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnTahminYap.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btnTahminYap.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnTahminYap.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnTahminYap.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnTahminYap.Location = new System.Drawing.Point(3, 71);
            this.btnTahminYap.Name = "btnTahminYap";
            this.btnTahminYap.RoundCorners = false;
            this.btnTahminYap.Size = new System.Drawing.Size(369, 51);
            this.btnTahminYap.TabIndex = 22;
            this.btnTahminYap.Text = "Tahmin Yap";
            this.btnTahminYap.Click += new System.EventHandler(this.btnTahminYap_Click);
            // 
            // tablelayoutNumeric
            // 
            this.tablelayoutNumeric.BackColor = System.Drawing.Color.White;
            this.tablelayoutNumeric.ColumnCount = 5;
            this.tablelayoutGame.SetColumnSpan(this.tablelayoutNumeric, 2);
            this.tablelayoutNumeric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayoutNumeric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayoutNumeric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayoutNumeric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tablelayoutNumeric.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 216F));
            this.tablelayoutNumeric.Controls.Add(this.bt4, 3, 0);
            this.tablelayoutNumeric.Controls.Add(this.bt3, 2, 0);
            this.tablelayoutNumeric.Controls.Add(this.bt2, 1, 0);
            this.tablelayoutNumeric.Controls.Add(this.btnDelete, 2, 2);
            this.tablelayoutNumeric.Controls.Add(this.bt1, 0, 0);
            this.tablelayoutNumeric.Controls.Add(this.bt5, 0, 1);
            this.tablelayoutNumeric.Controls.Add(this.bt6, 1, 1);
            this.tablelayoutNumeric.Controls.Add(this.bt7, 2, 1);
            this.tablelayoutNumeric.Controls.Add(this.bt8, 3, 1);
            this.tablelayoutNumeric.Controls.Add(this.bt9, 0, 2);
            this.tablelayoutNumeric.Controls.Add(this.bt0, 1, 2);
            this.tablelayoutNumeric.Controls.Add(this.rtbHistory, 4, 0);
            this.tablelayoutNumeric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablelayoutNumeric.Location = new System.Drawing.Point(3, 173);
            this.tablelayoutNumeric.Name = "tablelayoutNumeric";
            this.tablelayoutNumeric.RowCount = 3;
            this.tablelayoutNumeric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutNumeric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutNumeric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tablelayoutNumeric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelayoutNumeric.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tablelayoutNumeric.Size = new System.Drawing.Size(456, 127);
            this.tablelayoutNumeric.TabIndex = 23;
            // 
            // bt4
            // 
            this.bt4.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt4.BorderSize = 0;
            this.bt4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt4.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt4.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt4.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt4.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt4.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt4.Location = new System.Drawing.Point(183, 3);
            this.bt4.Name = "bt4";
            this.bt4.RoundCorners = false;
            this.bt4.Size = new System.Drawing.Size(54, 36);
            this.bt4.TabIndex = 26;
            this.bt4.Text = "4";
            // 
            // bt3
            // 
            this.bt3.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt3.BorderSize = 0;
            this.bt3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt3.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt3.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt3.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt3.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt3.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt3.Location = new System.Drawing.Point(123, 3);
            this.bt3.Name = "bt3";
            this.bt3.RoundCorners = false;
            this.bt3.Size = new System.Drawing.Size(54, 36);
            this.bt3.TabIndex = 25;
            this.bt3.Text = "3";
            // 
            // bt2
            // 
            this.bt2.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt2.BorderSize = 0;
            this.bt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt2.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt2.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt2.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt2.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt2.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt2.Location = new System.Drawing.Point(63, 3);
            this.bt2.Name = "bt2";
            this.bt2.RoundCorners = false;
            this.bt2.Size = new System.Drawing.Size(54, 36);
            this.bt2.TabIndex = 24;
            this.bt2.Text = "2";
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnDelete.BorderSize = 0;
            this.tablelayoutNumeric.SetColumnSpan(this.btnDelete, 2);
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnDelete.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnDelete.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btnDelete.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnDelete.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnDelete.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnDelete.Location = new System.Drawing.Point(123, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RoundCorners = false;
            this.btnDelete.Size = new System.Drawing.Size(114, 37);
            this.btnDelete.TabIndex = 29;
            this.btnDelete.Text = "Sil";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // bt1
            // 
            this.bt1.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt1.BorderSize = 0;
            this.bt1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt1.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt1.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt1.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt1.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt1.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt1.Location = new System.Drawing.Point(3, 3);
            this.bt1.Name = "bt1";
            this.bt1.RoundCorners = false;
            this.bt1.Size = new System.Drawing.Size(54, 36);
            this.bt1.TabIndex = 23;
            this.bt1.Text = "1";
            // 
            // bt5
            // 
            this.bt5.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt5.BorderSize = 0;
            this.bt5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt5.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt5.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt5.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt5.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt5.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt5.Location = new System.Drawing.Point(3, 45);
            this.bt5.Name = "bt5";
            this.bt5.RoundCorners = false;
            this.bt5.Size = new System.Drawing.Size(54, 36);
            this.bt5.TabIndex = 30;
            this.bt5.Text = "5";
            // 
            // bt6
            // 
            this.bt6.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt6.BorderSize = 0;
            this.bt6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt6.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt6.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt6.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt6.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt6.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt6.Location = new System.Drawing.Point(63, 45);
            this.bt6.Name = "bt6";
            this.bt6.RoundCorners = false;
            this.bt6.Size = new System.Drawing.Size(54, 36);
            this.bt6.TabIndex = 29;
            this.bt6.Text = "6";
            // 
            // bt7
            // 
            this.bt7.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt7.BorderSize = 0;
            this.bt7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt7.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt7.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt7.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt7.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt7.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt7.Location = new System.Drawing.Point(123, 45);
            this.bt7.Name = "bt7";
            this.bt7.RoundCorners = false;
            this.bt7.Size = new System.Drawing.Size(54, 36);
            this.bt7.TabIndex = 28;
            this.bt7.Text = "7";
            // 
            // bt8
            // 
            this.bt8.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt8.BorderSize = 0;
            this.bt8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt8.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt8.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt8.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt8.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt8.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt8.Location = new System.Drawing.Point(183, 45);
            this.bt8.Name = "bt8";
            this.bt8.RoundCorners = false;
            this.bt8.Size = new System.Drawing.Size(54, 36);
            this.bt8.TabIndex = 27;
            this.bt8.Text = "8";
            // 
            // bt9
            // 
            this.bt9.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt9.BorderSize = 0;
            this.bt9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt9.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt9.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt9.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt9.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt9.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt9.Location = new System.Drawing.Point(3, 87);
            this.bt9.Name = "bt9";
            this.bt9.RoundCorners = false;
            this.bt9.Size = new System.Drawing.Size(54, 37);
            this.bt9.TabIndex = 31;
            this.bt9.Text = "9";
            // 
            // bt0
            // 
            this.bt0.ActiveBorder = System.Drawing.Color.DimGray;
            this.bt0.BorderSize = 0;
            this.bt0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bt0.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bt0.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.bt0.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.bt0.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.bt0.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.bt0.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.bt0.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.bt0.Location = new System.Drawing.Point(63, 87);
            this.bt0.Name = "bt0";
            this.bt0.RoundCorners = false;
            this.bt0.Size = new System.Drawing.Size(54, 37);
            this.bt0.TabIndex = 32;
            this.bt0.Text = "0";
            // 
            // rtbHistory
            // 
            this.rtbHistory.Dock = System.Windows.Forms.DockStyle.Right;
            this.rtbHistory.HeaderBackColor = System.Drawing.Color.Empty;
            this.rtbHistory.HeaderFont = new System.Drawing.Font("Arial", 8F);
            this.rtbHistory.HeaderForeColor = System.Drawing.Color.Black;
            this.rtbHistory.HeaderHAlign = CWUI.YatayHiza.CWYHSol;
            this.rtbHistory.HeaderText = "Tahmin Geçmişi";
            this.rtbHistory.HeaderVAlign = CWUI.DikeyHiza.CWDHÜst;
            this.rtbHistory.HideHButton = true;
            this.rtbHistory.Lines = new string[] {
        "Deneme"};
            this.rtbHistory.Location = new System.Drawing.Point(246, 3);
            this.rtbHistory.Name = "rtbHistory";
            this.rtbHistory.NextControl = null;
            this.rtbHistory.ReadOnly = true;
            this.rtbHistory.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Azure,
        System.Drawing.Color.White};
            this.tablelayoutNumeric.SetRowSpan(this.rtbHistory, 3);
            this.rtbHistory.Rtf = "{\\rtf1\\ansi\\deff0{\\fonttbl{\\f0\\fnil\\fcharset162 Microsoft Sans Serif;}}\r\n\\viewkin" +
    "d4\\uc1\\pard\\lang1055\\b\\f0\\fs20 Deneme\\par\r\n}\r\n";
            this.rtbHistory.SelectedRtf = "{\\rtf1\\ansi\\deff0\\uc1 }\r\n";
            this.rtbHistory.SelectedText = "";
            this.rtbHistory.Size = new System.Drawing.Size(207, 121);
            this.rtbHistory.TabIndex = 26;
            this.rtbHistory.TabStop = false;
            this.rtbHistory.Text = "Deneme";
            this.rtbHistory.TextBackColor = System.Drawing.SystemColors.Control;
            // 
            // lblSonuc
            // 
            this.lblSonuc.BaseParent = null;
            this.lblSonuc.Border = true;
            this.lblSonuc.BorderColor = System.Drawing.Color.Silver;
            this.tablelayoutGame.SetColumnSpan(this.lblSonuc, 2);
            this.lblSonuc.DikeyHiza = CWUI.DikeyHiza.CWDHOrta;
            this.lblSonuc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblSonuc.DrawBack = false;
            this.lblSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSonuc.Location = new System.Drawing.Point(3, 128);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Padding = new System.Windows.Forms.Padding(5);
            this.phraseComponent1.SetPhraseName(this.lblSonuc, "STI_GAME_RST");
            this.lblSonuc.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lblSonuc.RoundCorners = false;
            this.lblSonuc.Secilebilir = false;
            this.lblSonuc.Size = new System.Drawing.Size(456, 39);
            this.lblSonuc.TabIndex = 24;
            this.lblSonuc.Text = " ";
            this.lblSonuc.YatayHiza = CWUI.YatayHiza.CWYHOrta;
            // 
            // pbSure
            // 
            this.pbSure.BorderColor = System.Drawing.Color.Black;
            this.pbSure.BorderStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            this.pbSure.BorderWidth = 0F;
            this.pbSure.CausesValidation = false;
            this.tablelayoutGame.SetColumnSpan(this.pbSure, 2);
            this.pbSure.Değer = ((long)(60));
            this.pbSure.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbSure.Location = new System.Drawing.Point(3, 306);
            this.pbSure.Maximum = ((long)(60));
            this.pbSure.Name = "pbSure";
            this.pbSure.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.LightBlue,
        System.Drawing.Color.LightGreen,
        System.Drawing.Color.White};
            this.pbSure.RoundCorners = false;
            this.pbSure.Size = new System.Drawing.Size(456, 31);
            this.pbSure.TabIndex = 25;
            this.pbSure.Tag = "0";
            this.pbSure.Text = "Infinite";
            this.pbSure.YazıTürü = CWUI.CWProgressBar.YazıTürüEnum.Kişisel;
            // 
            // btnRemain
            // 
            this.btnRemain.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnRemain.BorderSize = 0;
            this.btnRemain.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRemain.Enabled = false;
            this.btnRemain.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnRemain.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.SystemColors.Window,
        System.Drawing.Color.Transparent,
        System.Drawing.Color.White};
            this.btnRemain.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btnRemain.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnRemain.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnRemain.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnRemain.Location = new System.Drawing.Point(378, 71);
            this.btnRemain.Name = "btnRemain";
            this.btnRemain.RoundCorners = false;
            this.btnRemain.Size = new System.Drawing.Size(81, 51);
            this.btnRemain.TabIndex = 26;
            this.btnRemain.Text = "∞";
            // 
            // lblInfoBottom
            // 
            this.lblInfoBottom.BaseParent = null;
            this.lblInfoBottom.Border = true;
            this.lblInfoBottom.BorderColor = System.Drawing.Color.Silver;
            this.tablelayoutGame.SetColumnSpan(this.lblInfoBottom, 2);
            this.lblInfoBottom.DikeyHiza = CWUI.DikeyHiza.CWDHOrta;
            this.lblInfoBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfoBottom.DrawBack = false;
            this.lblInfoBottom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblInfoBottom.Location = new System.Drawing.Point(3, 343);
            this.lblInfoBottom.Name = "lblInfoBottom";
            this.lblInfoBottom.Padding = new System.Windows.Forms.Padding(5);
            this.lblInfoBottom.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lblInfoBottom.RoundCorners = false;
            this.lblInfoBottom.Secilebilir = false;
            this.lblInfoBottom.Size = new System.Drawing.Size(456, 40);
            this.lblInfoBottom.TabIndex = 27;
            this.lblInfoBottom.Text = " ";
            this.lblInfoBottom.YatayHiza = CWUI.YatayHiza.CWYHOrta;
            // 
            // grpStartGame
            // 
            this.grpStartGame.BorderColor = System.Drawing.Color.Green;
            this.grpStartGame.Collapsed = true;
            this.grpStartGame.Controls.Add(this.grpGame);
            this.grpStartGame.Controls.Add(this.grpStartNew);
            this.grpStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpStartGame.HeaderColorA = System.Drawing.Color.White;
            this.grpStartGame.HeaderColorB = System.Drawing.Color.MediumTurquoise;
            this.grpStartGame.HideCollapseButton = true;
            this.grpStartGame.Location = new System.Drawing.Point(3, 29);
            this.grpStartGame.MinCollapsed = 0;
            this.grpStartGame.Name = "grpStartGame";
            this.grpStartGame.Padding = new System.Windows.Forms.Padding(7, 34, 7, 7);
            this.phraseComponent1.SetPhraseName(this.grpStartGame, "GAME_TEXT");
            this.grpStartGame.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.grpStartGame.ShowHeader = true;
            this.grpStartGame.Size = new System.Drawing.Size(490, 517);
            this.grpStartGame.TabIndex = 20;
            this.grpStartGame.Text = "Geçerli Profil:";
            // 
            // grpStartNew
            // 
            this.grpStartNew.BorderColor = System.Drawing.Color.Green;
            this.grpStartNew.Collapsed = true;
            this.grpStartNew.Controls.Add(this.cwGroupBox2);
            this.grpStartNew.Controls.Add(this.lvStartGame);
            this.grpStartNew.Controls.Add(this.cwGroupBox3);
            this.grpStartNew.Dock = System.Windows.Forms.DockStyle.Fill;
            this.grpStartNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpStartNew.HeaderColorA = System.Drawing.Color.White;
            this.grpStartNew.HeaderColorB = System.Drawing.Color.Azure;
            this.grpStartNew.HideCollapseButton = true;
            this.grpStartNew.Location = new System.Drawing.Point(7, 34);
            this.grpStartNew.MinCollapsed = 0;
            this.grpStartNew.Name = "grpStartNew";
            this.grpStartNew.Padding = new System.Windows.Forms.Padding(7, 34, 7, 7);
            this.grpStartNew.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.grpStartNew.RoundCorners = false;
            this.grpStartNew.ShowHeader = true;
            this.grpStartNew.Size = new System.Drawing.Size(476, 476);
            this.grpStartNew.TabIndex = 19;
            this.grpStartNew.Text = "YOB";
            this.grpStartNew.VisibleChanged += new System.EventHandler(this.grpStartNew_VisibleChanged);
            // 
            // cwGroupBox2
            // 
            this.cwGroupBox2.BorderColor = System.Drawing.Color.Green;
            this.cwGroupBox2.Collapsed = true;
            this.cwGroupBox2.Controls.Add(this.starZorluk);
            this.cwGroupBox2.Controls.Add(this.lblDifficult);
            this.cwGroupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cwGroupBox2.HeaderColorA = System.Drawing.Color.White;
            this.cwGroupBox2.HeaderColorB = System.Drawing.Color.GreenYellow;
            this.cwGroupBox2.HideCollapseButton = false;
            this.cwGroupBox2.Location = new System.Drawing.Point(7, 377);
            this.cwGroupBox2.MinCollapsed = 0;
            this.cwGroupBox2.Name = "cwGroupBox2";
            this.cwGroupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cwGroupBox2.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.cwGroupBox2.RoundCorners = false;
            this.cwGroupBox2.RoundedCorners = CWUI.CWKöşeler.Hiçbiri;
            this.cwGroupBox2.ShowHeader = false;
            this.cwGroupBox2.Size = new System.Drawing.Size(462, 46);
            this.cwGroupBox2.TabIndex = 21;
            this.cwGroupBox2.Text = "cwGroupBox2";
            // 
            // starZorluk
            // 
            this.starZorluk.AutoSizeYildiz = false;
            this.starZorluk.BackColor = System.Drawing.Color.White;
            this.starZorluk.BorderColor = System.Drawing.Color.White;
            this.starZorluk.Dock = System.Windows.Forms.DockStyle.Right;
            this.starZorluk.Location = new System.Drawing.Point(231, 7);
            this.starZorluk.Name = "starZorluk";
            this.starZorluk.Size = new System.Drawing.Size(224, 32);
            this.starZorluk.TabIndex = 20;
            this.starZorluk.Text = "1";
            this.starZorluk.YıldızBorderColor = System.Drawing.Color.LimeGreen;
            this.starZorluk.YıldızColor = System.Drawing.Color.Lime;
            this.starZorluk.YildizHizasi = System.Windows.Forms.HorizontalAlignment.Center;
            this.starZorluk.YildizHizasiDikey = CWUI.DikeyHiza.CWDHOrta;
            this.starZorluk.YıldızPuanı = 0;
            this.starZorluk.YıldızRadius = 16F;
            this.starZorluk.YıldızReadOnly = true;
            this.starZorluk.YıldızSayısı = 6;
            // 
            // lblDifficult
            // 
            this.lblDifficult.BorderSize = 0;
            this.lblDifficult.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblDifficult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblDifficult.ForeColor = System.Drawing.Color.OrangeRed;
            this.lblDifficult.Location = new System.Drawing.Point(7, 7);
            this.lblDifficult.Name = "lblDifficult";
            this.lblDifficult.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lblDifficult.Size = new System.Drawing.Size(211, 32);
            this.lblDifficult.TabIndex = 1;
            this.lblDifficult.Text = "Tahmini Zorluk Derecesi";
            this.lblDifficult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lvStartGame
            // 
            this.lvStartGame.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnSetting,
            this.columnValue});
            this.lvStartGame.Dock = System.Windows.Forms.DockStyle.Top;
            this.lvStartGame.HideSelection = false;
            this.lvStartGame.Location = new System.Drawing.Point(7, 34);
            this.lvStartGame.Name = "lvStartGame";
            this.lvStartGame.OwnerDraw = true;
            this.lvStartGame.ReadOnly = false;
            this.lvStartGame.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lvStartGame.RenklerH = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke};
            this.lvStartGame.Size = new System.Drawing.Size(462, 338);
            this.lvStartGame.TabIndex = 1;
            this.lvStartGame.UseCompatibleStateImageBehavior = false;
            this.lvStartGame.UseDefaultStyle = false;
            this.lvStartGame.View = System.Windows.Forms.View.Details;
            this.lvStartGame.EditOpening += new System.EventHandler<CWUI.EditListView.mEditOpening>(this.lvStartGame_EditOpening);
            this.lvStartGame.EditCommit += new System.EventHandler<CWUI.EditListView.mEditCommit>(this.lvStartGame_EditCommit);
            // 
            // columnSetting
            // 
            this.columnSetting.Tag = "columnSetting";
            this.columnSetting.Text = "Ayar Adı";
            this.columnSetting.Width = 265;
            // 
            // columnValue
            // 
            this.columnValue.Tag = "columnValue";
            this.columnValue.Text = "Değer";
            this.columnValue.Width = 190;
            // 
            // cwGroupBox3
            // 
            this.cwGroupBox3.BorderColor = System.Drawing.Color.Green;
            this.cwGroupBox3.Collapsed = true;
            this.cwGroupBox3.Controls.Add(this.btnStartGame);
            this.cwGroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cwGroupBox3.HeaderColorA = System.Drawing.Color.White;
            this.cwGroupBox3.HeaderColorB = System.Drawing.Color.GreenYellow;
            this.cwGroupBox3.HideCollapseButton = false;
            this.cwGroupBox3.Location = new System.Drawing.Point(7, 423);
            this.cwGroupBox3.MinCollapsed = 0;
            this.cwGroupBox3.Name = "cwGroupBox3";
            this.cwGroupBox3.Padding = new System.Windows.Forms.Padding(7);
            this.cwGroupBox3.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.cwGroupBox3.RoundCorners = false;
            this.cwGroupBox3.RoundedCorners = CWUI.CWKöşeler.Hiçbiri;
            this.cwGroupBox3.ShowHeader = false;
            this.cwGroupBox3.Size = new System.Drawing.Size(462, 46);
            this.cwGroupBox3.TabIndex = 22;
            this.cwGroupBox3.Text = "cwGroupBox3";
            // 
            // btnStartGame
            // 
            this.btnStartGame.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnStartGame.BorderSize = 0;
            this.btnStartGame.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnStartGame.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnStartGame.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.SystemColors.Window,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnStartGame.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btnStartGame.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnStartGame.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnStartGame.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnStartGame.Location = new System.Drawing.Point(7, 7);
            this.btnStartGame.Name = "btnStartGame";
            this.btnStartGame.RoundCorners = false;
            this.btnStartGame.Size = new System.Drawing.Size(448, 32);
            this.btnStartGame.TabIndex = 1;
            this.btnStartGame.Text = "Oyuna Başla";
            this.btnStartGame.Click += new System.EventHandler(this.btnStartGame_Click);
            // 
            // cwContainerFooter1
            // 
            this.cwContainerFooter1.BackColor = System.Drawing.Color.Transparent;
            this.cwContainerFooter1.Controls.Add(this.lblInfo);
            this.cwContainerFooter1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cwContainerFooter1.Location = new System.Drawing.Point(0, 546);
            this.cwContainerFooter1.Name = "cwContainerFooter1";
            this.cwContainerFooter1.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.Azure,
        System.Drawing.Color.White};
            this.cwContainerFooter1.Size = new System.Drawing.Size(498, 27);
            this.cwContainerFooter1.TabIndex = 18;
            this.cwContainerFooter1.Text = "cwContainerFooter1";
            // 
            // lblInfo
            // 
            this.lblInfo.BaseParent = null;
            this.lblInfo.Border = false;
            this.lblInfo.Controls.Add(this.lblVectorel);
            this.lblInfo.DikeyHiza = CWUI.DikeyHiza.CWDHOrta;
            this.lblInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblInfo.DrawBack = false;
            this.lblInfo.Location = new System.Drawing.Point(0, 0);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Padding = new System.Windows.Forms.Padding(3);
            this.phraseComponent1.SetPhraseName(this.lblInfo, "lblinfo_text");
            this.lblInfo.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lblInfo.Secilebilir = false;
            this.lblInfo.Size = new System.Drawing.Size(498, 27);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.YatayHiza = CWUI.YatayHiza.CWYHOrta;
            this.lblInfo.Click += new System.EventHandler(this.lblInfo_Click);
            // 
            // lblVectorel
            // 
            this.lblVectorel.BaseParent = null;
            this.lblVectorel.Border = false;
            this.lblVectorel.DikeyHiza = CWUI.DikeyHiza.CWDHOrta;
            this.lblVectorel.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblVectorel.DrawBack = false;
            this.lblVectorel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVectorel.Location = new System.Drawing.Point(385, 3);
            this.lblVectorel.Name = "lblVectorel";
            this.lblVectorel.Padding = new System.Windows.Forms.Padding(5);
            this.lblVectorel.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lblVectorel.Size = new System.Drawing.Size(110, 21);
            this.lblVectorel.TabIndex = 0;
            this.lblVectorel.Visible = false;
            this.lblVectorel.YatayHiza = CWUI.YatayHiza.CWYHSağ;
            // 
            // tmrVectorel
            // 
            this.tmrVectorel.Enabled = true;
            this.tmrVectorel.Interval = 1000;
            this.tmrVectorel.Tick += new System.EventHandler(this.vecTimer_Tick);
            // 
            // SayiTahmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 573);
            this.Controls.Add(this.grpStartGame);
            this.Controls.Add(this.cwContainerFooter1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SayiTahmin";
            this.phraseComponent1.SetPhraseName(this, "MENU_MAIN_TEXT");
            this.Text = "SayiTahminOyunu";
            this.Activated += new System.EventHandler(this.SayiTahmin_Activated);
            this.Deactivate += new System.EventHandler(this.SayiTahmin_Deactivate);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.KelimeOyunu_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SayiTahmin_KeyPress);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.grpGame.ResumeLayout(false);
            this.cwGroupBox4.ResumeLayout(false);
            this.tablelayoutGame.ResumeLayout(false);
            this.tablelayoutGame.PerformLayout();
            this.tablelayoutNumeric.ResumeLayout(false);
            this.grpStartGame.ResumeLayout(false);
            this.grpStartNew.ResumeLayout(false);
            this.cwGroupBox2.ResumeLayout(false);
            this.cwGroupBox3.ResumeLayout(false);
            this.cwContainerFooter1.ResumeLayout(false);
            this.lblInfo.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oyunToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem çıkışToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem profilDeğiştirToolStripMenuItem;
        private CWUI.CWContainerFooter cwContainerFooter1;
        private System.Windows.Forms.ToolStripMenuItem yeniOyunToolStripMenuItem;
        private CWUI.CWGroupBox grpStartNew;
        private CWUI.EditListView lvStartGame;
        private System.Windows.Forms.ColumnHeader columnSetting;
        private System.Windows.Forms.ColumnHeader columnValue;
        private CWUI.CWStars starZorluk;
        private CWUI.CWGroupBox cwGroupBox2;
        private CWUI.CWLabel lblDifficult;
        private CWUI.CWGroupBox cwGroupBox3;
        private CWUI.CwButton btnStartGame;
        private CWUI.CWGroupBox grpStartGame;
        private CWUI.CWGroupBox grpGame;
        private PhraseSiniflar.PhraseComponent phraseComponent1;
        private System.Windows.Forms.ToolStripMenuItem sTATSToolStripMenuItem;
        private CWUI.CWGroupBox cwGroupBox4;
        private CWUI.CwButton btBack;
        private CWUI.CwButton btRestart;
        private CWUI.CwButton btnTahminYap;
        private System.Windows.Forms.TableLayoutPanel tablelayoutGame;
        private CWUI.CWHaderRichTextBox rtbHistory;
        private System.Windows.Forms.TableLayoutPanel tablelayoutNumeric;
        private CWUI.CwButton bt4;
        private CWUI.CwButton bt3;
        private CWUI.CwButton bt2;
        private CWUI.CwButton btnDelete;
        private CWUI.CwButton bt1;
        private CWUI.CwButton bt5;
        private CWUI.CwButton bt6;
        private CWUI.CwButton bt7;
        private CWUI.CwButton bt8;
        private CWUI.CwButton bt9;
        private CWUI.CwButton bt0;
        private CWUI.CwLabelPlus lblSonuc;
        private CWUI.CWProgressBar pbSure;
        private CWUI.CwButton btnRemain;
        private System.Windows.Forms.ToolStripMenuItem closeProfileToolStripMenuItem;
        private CWUI.CwLabelPlus lblInfo;
        private CWUI.CwLabelPlus lblInfoBottom;
        private CWUI.CwLabelPlus lblVectorel;
        private System.Windows.Forms.Timer tmrVectorel;
        private System.Windows.Forms.ToolStripMenuItem tekrarBaşlatCtrlRToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableWarningsToolStripMenuItem;
    }
}

