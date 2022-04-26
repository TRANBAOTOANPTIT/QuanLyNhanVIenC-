namespace Lab4_NHOM_TRANBAOTOAN
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hệThốngToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doimatkhauToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quảnLýToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nhanvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lophocToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bangdiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.trogiupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlContent = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hệThốngToolStripMenuItem,
            this.quảnLýToolStripMenuItem,
            this.trogiupToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hệThốngToolStripMenuItem
            // 
            this.hệThốngToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.doimatkhauToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hệThốngToolStripMenuItem.Name = "hệThốngToolStripMenuItem";
            this.hệThốngToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hệThốngToolStripMenuItem.Text = "Hệ Thống";
            // 
            // doimatkhauToolStripMenuItem
            // 
            this.doimatkhauToolStripMenuItem.Name = "doimatkhauToolStripMenuItem";
            this.doimatkhauToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.doimatkhauToolStripMenuItem.Text = "Đổi mật khẩu";
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // quảnLýToolStripMenuItem
            // 
            this.quảnLýToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nhanvienToolStripMenuItem,
            this.lophocToolStripMenuItem,
            this.sinhvienToolStripMenuItem,
            this.bangdiemToolStripMenuItem});
            this.quảnLýToolStripMenuItem.Name = "quảnLýToolStripMenuItem";
            this.quảnLýToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.quảnLýToolStripMenuItem.Text = "Quản lý";
            // 
            // nhanvienToolStripMenuItem
            // 
            this.nhanvienToolStripMenuItem.Name = "nhanvienToolStripMenuItem";
            this.nhanvienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.nhanvienToolStripMenuItem.Text = "Nhân viên";
            this.nhanvienToolStripMenuItem.Click += new System.EventHandler(this.nhanvienToolStripMenuItem_Click);
            // 
            // lophocToolStripMenuItem
            // 
            this.lophocToolStripMenuItem.Name = "lophocToolStripMenuItem";
            this.lophocToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lophocToolStripMenuItem.Text = "Lớp học";
            this.lophocToolStripMenuItem.Click += new System.EventHandler(this.lophocToolStripMenuItem_Click);
            // 
            // sinhvienToolStripMenuItem
            // 
            this.sinhvienToolStripMenuItem.Name = "sinhvienToolStripMenuItem";
            this.sinhvienToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.sinhvienToolStripMenuItem.Text = "Sinh viên";
            this.sinhvienToolStripMenuItem.Click += new System.EventHandler(this.sinhvienToolStripMenuItem_Click);
            // 
            // bangdiemToolStripMenuItem
            // 
            this.bangdiemToolStripMenuItem.Name = "bangdiemToolStripMenuItem";
            this.bangdiemToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.bangdiemToolStripMenuItem.Text = "Bảng điểm";
            this.bangdiemToolStripMenuItem.Click += new System.EventHandler(this.bangdiemToolStripMenuItem_Click);
            // 
            // trogiupToolStripMenuItem
            // 
            this.trogiupToolStripMenuItem.Name = "trogiupToolStripMenuItem";
            this.trogiupToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.trogiupToolStripMenuItem.Text = "Trợ giúp";
            // 
            // pnlContent
            // 
            this.pnlContent.BackColor = System.Drawing.Color.White;
            this.pnlContent.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContent.Location = new System.Drawing.Point(0, 24);
            this.pnlContent.Name = "pnlContent";
            this.pnlContent.Size = new System.Drawing.Size(874, 582);
            this.pnlContent.TabIndex = 1;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 606);
            this.Controls.Add(this.pnlContent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hệThốngToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doimatkhauToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quảnLýToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nhanvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lophocToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bangdiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem trogiupToolStripMenuItem;
        private System.Windows.Forms.Panel pnlContent;
    }
}