namespace Lab4_NHOM_TRANBAOTOAN
{
    partial class frmDN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.btndn = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đăng nhập  ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(119, 52);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(154, 20);
            this.txtdn.TabIndex = 2;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(119, 118);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(154, 20);
            this.txtmk.TabIndex = 3;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // btndn
            // 
            this.btndn.Location = new System.Drawing.Point(93, 168);
            this.btndn.Name = "btndn";
            this.btndn.Size = new System.Drawing.Size(75, 23);
            this.btndn.TabIndex = 4;
            this.btndn.Text = "Đăng nhập";
            this.btndn.UseVisualStyleBackColor = true;
            this.btndn.Click += new System.EventHandler(this.btndn_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Location = new System.Drawing.Point(185, 168);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 5;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            // 
            // frmDN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 261);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btndn);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmDN";
            this.Text = "Đăng nhập";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Button btndn;
        private System.Windows.Forms.Button btnthoat;
    }
}

