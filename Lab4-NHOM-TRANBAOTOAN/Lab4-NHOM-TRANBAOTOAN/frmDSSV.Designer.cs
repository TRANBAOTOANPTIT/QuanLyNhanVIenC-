namespace Lab4_NHOM_TRANBAOTOAN
{
    partial class frmDSSV
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
            this.dgvSv = new System.Windows.Forms.DataGridView();
            this.mtbns = new System.Windows.Forms.MaskedTextBox();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtdn = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtml = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtdc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnxsv = new System.Windows.Forms.Button();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSv
            // 
            this.dgvSv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSv.Location = new System.Drawing.Point(-1, 166);
            this.dgvSv.MultiSelect = false;
            this.dgvSv.Name = "dgvSv";
            this.dgvSv.Size = new System.Drawing.Size(756, 225);
            this.dgvSv.TabIndex = 16;
            this.dgvSv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSv_CellDoubleClick);
            // 
            // mtbns
            // 
            this.mtbns.Location = new System.Drawing.Point(97, 86);
            this.mtbns.Mask = "00/00/0000";
            this.mtbns.Name = "mtbns";
            this.mtbns.Size = new System.Drawing.Size(100, 20);
            this.mtbns.TabIndex = 33;
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(336, 89);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(146, 20);
            this.txtmk.TabIndex = 32;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(249, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 31;
            this.label7.Text = "Mật Khẩu";
            // 
            // txtdn
            // 
            this.txtdn.Location = new System.Drawing.Point(336, 53);
            this.txtdn.Name = "txtdn";
            this.txtdn.Size = new System.Drawing.Size(146, 20);
            this.txtdn.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(249, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Tên Đăng Nhập";
            // 
            // txtml
            // 
            this.txtml.Location = new System.Drawing.Point(336, 12);
            this.txtml.Name = "txtml";
            this.txtml.Size = new System.Drawing.Size(146, 20);
            this.txtml.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(249, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Mã Lớp";
            // 
            // txtdc
            // 
            this.txtdc.Location = new System.Drawing.Point(97, 129);
            this.txtdc.Name = "txtdc";
            this.txtdc.Size = new System.Drawing.Size(131, 20);
            this.txtdc.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Địa chỉ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Ngày Sinh";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(97, 50);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(131, 20);
            this.txtht.TabIndex = 23;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 22;
            this.label2.Text = "Họ Tên";
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(97, 12);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(131, 20);
            this.txtmsv.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Mã Sinh viên";
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(614, 51);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 36;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(577, 12);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(146, 20);
            this.txtTukhoa.TabIndex = 35;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(501, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 13);
            this.label8.TabIndex = 34;
            this.label8.Text = "Từ khóa";
            // 
            // btnxsv
            // 
            this.btnxsv.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxsv.Location = new System.Drawing.Point(273, 420);
            this.btnxsv.Name = "btnxsv";
            this.btnxsv.Size = new System.Drawing.Size(89, 23);
            this.btnxsv.TabIndex = 39;
            this.btnxsv.Text = "Xóa sinh viên";
            this.btnxsv.UseVisualStyleBackColor = true;
            this.btnxsv.Click += new System.EventHandler(this.btnxsv_Click);
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthoat.Location = new System.Drawing.Point(438, 420);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 38;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Location = new System.Drawing.Point(130, 420);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 37;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // frmDSSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(755, 464);
            this.Controls.Add(this.btnxsv);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.mtbns);
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
            this.Controls.Add(this.dgvSv);
            this.Name = "frmDSSV";
            this.Text = "Danh sách sinh viên";
            this.Load += new System.EventHandler(this.frmDSSV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSv;
        private System.Windows.Forms.MaskedTextBox mtbns;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtdn;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtml;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnxsv;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLuu;
    }
}