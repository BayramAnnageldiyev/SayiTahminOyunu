namespace SayiTahminOyunu
{
    partial class ProfileSelector
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cwGroupBox2 = new CWUI.CWGroupBox();
            this.cbRebemmer = new System.Windows.Forms.CheckBox();
            this.pbLoadProfile = new System.Windows.Forms.ProgressBar();
            this.btnDelete = new CWUI.CwButton();
            this.btnNew = new CWUI.CwButton();
            this.btnContinue = new CWUI.CwButton();
            this.btnExit = new CWUI.CwButton();
            this.grpProfil = new CWUI.CWGroupBox();
            this.lvProfiles = new CWUI.EditListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cwGroupBox2.SuspendLayout();
            this.grpProfil.SuspendLayout();
            this.SuspendLayout();
            // 
            // cwGroupBox2
            // 
            this.cwGroupBox2.BorderColor = System.Drawing.Color.Green;
            this.cwGroupBox2.Collapsed = true;
            this.cwGroupBox2.Controls.Add(this.cbRebemmer);
            this.cwGroupBox2.Controls.Add(this.pbLoadProfile);
            this.cwGroupBox2.Controls.Add(this.btnDelete);
            this.cwGroupBox2.Controls.Add(this.btnNew);
            this.cwGroupBox2.Controls.Add(this.btnContinue);
            this.cwGroupBox2.Controls.Add(this.btnExit);
            this.cwGroupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cwGroupBox2.HeaderColorA = System.Drawing.Color.White;
            this.cwGroupBox2.HeaderColorB = System.Drawing.Color.GreenYellow;
            this.cwGroupBox2.HideCollapseButton = true;
            this.cwGroupBox2.Location = new System.Drawing.Point(5, 225);
            this.cwGroupBox2.MinCollapsed = 0;
            this.cwGroupBox2.Name = "cwGroupBox2";
            this.cwGroupBox2.Padding = new System.Windows.Forms.Padding(7);
            this.cwGroupBox2.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.cwGroupBox2.ShowHeader = false;
            this.cwGroupBox2.Size = new System.Drawing.Size(337, 36);
            this.cwGroupBox2.TabIndex = 4;
            this.cwGroupBox2.Text = "cwGroupBox2";
            // 
            // cbRebemmer
            // 
            this.cbRebemmer.AutoSize = true;
            this.cbRebemmer.Location = new System.Drawing.Point(156, 12);
            this.cbRebemmer.Name = "cbRebemmer";
            this.cbRebemmer.Size = new System.Drawing.Size(15, 14);
            this.cbRebemmer.TabIndex = 6;
            this.cbRebemmer.UseVisualStyleBackColor = true;
            this.cbRebemmer.CheckedChanged += new System.EventHandler(this.cbRebemmer_CheckedChanged);
            // 
            // pbLoadProfile
            // 
            this.pbLoadProfile.Location = new System.Drawing.Point(77, 7);
            this.pbLoadProfile.MarqueeAnimationSpeed = 50;
            this.pbLoadProfile.Name = "pbLoadProfile";
            this.pbLoadProfile.Size = new System.Drawing.Size(40, 23);
            this.pbLoadProfile.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.pbLoadProfile.TabIndex = 5;
            this.pbLoadProfile.Value = 25;
            this.pbLoadProfile.Visible = false;
            // 
            // btnDelete
            // 
            this.btnDelete.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnDelete.BorderRadius = 5F;
            this.btnDelete.BorderSize = 2;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDelete.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnDelete.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnDelete.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnDelete.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnDelete.Location = new System.Drawing.Point(40, 6);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.RoundCorners = false;
            this.btnDelete.Size = new System.Drawing.Size(31, 24);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "-";
            this.btnDelete.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnNew.BorderRadius = 5F;
            this.btnNew.BorderSize = 2;
            this.btnNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnNew.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnNew.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnNew.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnNew.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnNew.Location = new System.Drawing.Point(8, 6);
            this.btnNew.Name = "btnNew";
            this.btnNew.RoundCorners = false;
            this.btnNew.Size = new System.Drawing.Size(31, 24);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "+";
            this.btnNew.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnContinue.BorderRadius = 5F;
            this.btnContinue.BorderSize = 0;
            this.btnContinue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnContinue.Enabled = false;
            this.btnContinue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnContinue.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnContinue.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnContinue.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnContinue.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnContinue.Location = new System.Drawing.Point(174, 6);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.RoundCorners = false;
            this.btnContinue.Size = new System.Drawing.Size(75, 24);
            this.btnContinue.TabIndex = 1;
            this.btnContinue.Text = "Devam";
            this.btnContinue.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnExit
            // 
            this.btnExit.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnExit.BorderRadius = 5F;
            this.btnExit.BorderSize = 0;
            this.btnExit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnExit.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnExit.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnExit.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnExit.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnExit.Location = new System.Drawing.Point(255, 6);
            this.btnExit.Name = "btnExit";
            this.btnExit.RoundCorners = false;
            this.btnExit.Size = new System.Drawing.Size(75, 24);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Çıkış";
            this.btnExit.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // grpProfil
            // 
            this.grpProfil.BorderColor = System.Drawing.Color.Green;
            this.grpProfil.Collapsed = true;
            this.grpProfil.Controls.Add(this.lvProfiles);
            this.grpProfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.grpProfil.ForeColor = System.Drawing.Color.Black;
            this.grpProfil.HeaderColorA = System.Drawing.Color.White;
            this.grpProfil.HeaderColorB = System.Drawing.Color.LightGray;
            this.grpProfil.HideCollapseButton = true;
            this.grpProfil.Location = new System.Drawing.Point(5, 6);
            this.grpProfil.MinCollapsed = 0;
            this.grpProfil.Name = "grpProfil";
            this.grpProfil.Padding = new System.Windows.Forms.Padding(7, 34, 7, 7);
            this.grpProfil.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.grpProfil.ShowHeader = true;
            this.grpProfil.Size = new System.Drawing.Size(337, 220);
            this.grpProfil.TabIndex = 0;
            this.grpProfil.Text = "Bir Profil Seçin";
            // 
            // lvProfiles
            // 
            this.lvProfiles.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.lvProfiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lvProfiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lvProfiles.FullRowSelect = true;
            this.lvProfiles.Location = new System.Drawing.Point(7, 34);
            this.lvProfiles.MultiSelect = false;
            this.lvProfiles.Name = "lvProfiles";
            this.lvProfiles.OwnerDraw = true;
            this.lvProfiles.ReadOnly = false;
            this.lvProfiles.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.lvProfiles.RenklerH = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.WhiteSmoke};
            this.lvProfiles.Size = new System.Drawing.Size(323, 179);
            this.lvProfiles.TabIndex = 2;
            this.lvProfiles.UseCompatibleStateImageBehavior = false;
            this.lvProfiles.UseDefaultStyle = true;
            this.lvProfiles.View = System.Windows.Forms.View.Details;
            this.lvProfiles.SelectedIndexChanged += new System.EventHandler(this.lvProfiles_SelectedIndexChanged_1);
            this.lvProfiles.DoubleClick += new System.EventHandler(this.lvProfiles_DoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Tag = "PRF_LST_INDEX";
            this.columnHeader1.Text = "Sıra";
            this.columnHeader1.Width = 80;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Tag = "PRF_LST_PNAME";
            this.columnHeader2.Text = "Profil Adı";
            this.columnHeader2.Width = 235;
            // 
            // ProfileSelector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(349, 263);
            this.Controls.Add(this.cwGroupBox2);
            this.Controls.Add(this.grpProfil);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileSelector";
            this.Text = "ProfileSelector";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ProfileSelector_FormClosed);
            this.Load += new System.EventHandler(this.ProfileSelector_Load);
            this.cwGroupBox2.ResumeLayout(false);
            this.cwGroupBox2.PerformLayout();
            this.grpProfil.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        
        private CWUI.CWGroupBox grpProfil;
        private CWUI.CwButton btnExit;
        private CWUI.CwButton btnContinue;
        private CWUI.CwButton btnNew;
        private CWUI.CWGroupBox cwGroupBox2;
        private CWUI.CwButton btnDelete;
        private CWUI.EditListView lvProfiles;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ProgressBar pbLoadProfile;
        private System.Windows.Forms.CheckBox cbRebemmer;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}