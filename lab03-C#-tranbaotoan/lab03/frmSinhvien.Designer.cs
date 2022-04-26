namespace lab03
{
    partial class frmSinhvien
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
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.txtht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtml = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnHuy = new System.Windows.Forms.Button();
            this.mtbns = new System.Windows.Forms.MaskedTextBox();
            this.btnxsv = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(48, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Sinh viên";
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(139, 48);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(254, 20);
            this.txtmsv.TabIndex = 1;
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(139, 88);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(254, 20);
            this.txtht.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 95);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Họ Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(139, 174);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(254, 20);
            this.txtdc.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Địa chỉ";
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(139, 215);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(254, 20);
            this.txtml.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(48, 218);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mã Lớp";
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(139, 254);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(254, 20);
            this.txtdn.TabIndex = 13;
            this.txtdn.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(48, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(139, 297);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(254, 20);
            this.txtmk.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 304);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 14;
            this.label7.Text = "Mật Khẩu";
            // 
            // btnLuu
            // 
            this.btnLuu.Location = new System.Drawing.Point(162, 348);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 16;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Location = new System.Drawing.Point(270, 348);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.TabIndex = 17;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.UseVisualStyleBackColor = true;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // mtbns
            // 
            this.mtbns.Location = new System.Drawing.Point(139, 142);
            this.mtbns.Mask = "00/00/0000";
            this.mtbns.Name = "mtbns";
            this.mtbns.Size = new System.Drawing.Size(100, 20);
            this.mtbns.TabIndex = 18;
            // 
            // btnxsv
            // 
            this.btnxsv.Location = new System.Drawing.Point(416, 334);
            this.btnxsv.Name = "btnxsv";
            this.btnxsv.Size = new System.Drawing.Size(89, 23);
            this.btnxsv.TabIndex = 19;
            this.btnxsv.Text = "Xóa sinh viên";
            this.btnxsv.UseVisualStyleBackColor = true;
            this.btnxsv.Click += new System.EventHandler(this.btnxsv_Click);
            // 
            // frmSinhvien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 383);
            this.Controls.Add(this.btnxsv);
            this.Controls.Add(this.mtbns);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtdn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtml);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtdc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.label1);
            this.Name = "frmSinhvien";
            this.Text = "frmSinhvien";
            this.Load += new System.EventHandler(this.frmSinhvien_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnHuy;
        private System.Windows.Forms.MaskedTextBox mtbns;
        private System.Windows.Forms.Button btnxsv;
    }
}