namespace SayiTahminOyunu
{
    partial class ProfileStatistics
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
            this.grpStats = new CWUI.CWGroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.rtbStats = new System.Windows.Forms.RichTextBox();
            this.btnCloseStats = new CWUI.CwButton();
            this.btnResetStats = new CWUI.CwButton();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpStats.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpStats
            // 
            this.grpStats.BorderColor = System.Drawing.Color.Green;
            this.grpStats.Collapsed = true;
            this.grpStats.Controls.Add(this.tableLayoutPanel1);
            this.grpStats.HeaderColorA = System.Drawing.Color.White;
            this.grpStats.HeaderColorB = System.Drawing.Color.LightCyan;
            this.grpStats.HideCollapseButton = true;
            this.grpStats.Location = new System.Drawing.Point(3, 5);
            this.grpStats.MinCollapsed = 0;
            this.grpStats.Name = "grpStats";
            this.grpStats.Padding = new System.Windows.Forms.Padding(7, 34, 7, 7);
            this.grpStats.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.grpStats.ShowHeader = true;
            this.grpStats.Size = new System.Drawing.Size(475, 450);
            this.grpStats.TabIndex = 0;
            this.grpStats.Text = "Stats";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.5977F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.4023F));
            this.tableLayoutPanel1.Controls.Add(this.rtbStats, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnCloseStats, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnResetStats, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(7, 34);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(461, 409);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // rtbStats
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.rtbStats, 2);
            this.rtbStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbStats.Location = new System.Drawing.Point(3, 3);
            this.rtbStats.Name = "rtbStats";
            this.rtbStats.ReadOnly = true;
            this.rtbStats.Size = new System.Drawing.Size(455, 362);
            this.rtbStats.TabIndex = 5;
            this.rtbStats.Text = "";
            // 
            // btnCloseStats
            // 
            this.btnCloseStats.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnCloseStats.BorderRadius = 5F;
            this.btnCloseStats.BorderSize = 0;
            this.btnCloseStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCloseStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCloseStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCloseStats.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.SystemColors.Window,
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.Silver,
        System.Drawing.Color.White};
            this.btnCloseStats.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Gray;
            this.btnCloseStats.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.FloralWhite,
        System.Drawing.Color.White,
        System.Drawing.Color.White};
            this.btnCloseStats.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnCloseStats.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.White,
        System.Drawing.Color.White,
        System.Drawing.Color.LightGray,
        System.Drawing.Color.White};
            this.btnCloseStats.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnCloseStats.Location = new System.Drawing.Point(3, 371);
            this.btnCloseStats.Name = "btnCloseStats";
            this.btnCloseStats.RoundCorners = false;
            this.btnCloseStats.Size = new System.Drawing.Size(291, 35);
            this.btnCloseStats.TabIndex = 2;
            this.btnCloseStats.Text = "Kapat";
            this.btnCloseStats.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnCloseStats.Click += new System.EventHandler(this.btnCloseStats_Click);
            // 
            // btnResetStats
            // 
            this.btnResetStats.ActiveBorder = System.Drawing.Color.DimGray;
            this.btnResetStats.BorderRadius = 5F;
            this.btnResetStats.BorderSize = 0;
            this.btnResetStats.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnResetStats.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnResetStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnResetStats.Görünüm.BorderColor = System.Drawing.Color.Red;
            this.btnResetStats.Görünüm.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.WhiteSmoke,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.OrangeRed,
        System.Drawing.Color.WhiteSmoke};
            this.btnResetStats.GörünümOnMouseDown.BorderColor = System.Drawing.Color.Red;
            this.btnResetStats.GörünümOnMouseDown.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.Gray,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Gray};
            this.btnResetStats.GörünümOnMouseOver.BorderColor = System.Drawing.Color.LightGray;
            this.btnResetStats.GörünümOnMouseOver.Renkler = new System.Drawing.Color[] {
        System.Drawing.Color.Silver,
        System.Drawing.Color.Red,
        System.Drawing.Color.Red,
        System.Drawing.Color.Silver};
            this.btnResetStats.HAlign = CWUI.YatayHiza.CWYHOrta;
            this.btnResetStats.Location = new System.Drawing.Point(300, 371);
            this.btnResetStats.Name = "btnResetStats";
            this.btnResetStats.RoundCorners = false;
            this.btnResetStats.Size = new System.Drawing.Size(158, 35);
            this.btnResetStats.TabIndex = 4;
            this.btnResetStats.Text = "Sıfırla";
            this.btnResetStats.VAlign = CWUI.DikeyHiza.CWDHOrta;
            this.btnResetStats.Click += new System.EventHandler(this.btnResetStats_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 92);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 92);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // ProfileStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(481, 457);
            this.Controls.Add(this.grpStats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ProfileStatistics";
            this.Text = "ProfileStatistics";
            this.Load += new System.EventHandler(this.ProfileStatistics_Load);
            this.grpStats.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CWUI.CWGroupBox grpStats;
        private CWUI.CwButton btnCloseStats;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CWUI.CwButton btnResetStats;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.RichTextBox rtbStats;
    }
}