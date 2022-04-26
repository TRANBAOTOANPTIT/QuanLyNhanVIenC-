namespace Lab4_NHOM_TRANBAOTOAN
{
    partial class frmDSNV
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
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txteml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnghiluu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            this.SuspendLayout();
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(485, 126);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(202, 20);
            this.txtmk.TabIndex = 43;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(401, 126);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 42;
            this.label6.Text = "Mật Khẩu";
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(485, 74);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(202, 20);
            this.txtl.TabIndex = 41;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(401, 77);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 40;
            this.label5.Text = "Lương";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(485, 21);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(202, 20);
            this.txtht.TabIndex = 39;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(401, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "Họ Tên";
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(148, 126);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(197, 20);
            this.txttdn.TabIndex = 37;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 36;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // txteml
            // 
            this.txteml.Location = new System.Drawing.Point(148, 74);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(197, 20);
            this.txteml.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "Email";
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(148, 21);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(197, 20);
            this.txtmnv.TabIndex = 33;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 32;
            this.label1.Text = "Mã NV";
            // 
            // dgvnv
            // 
            this.dgvnv.AllowUserToAddRows = false;
            this.dgvnv.AllowUserToDeleteRows = false;
            this.dgvnv.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Location = new System.Drawing.Point(1, 220);
            this.dgvnv.MultiSelect = false;
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.ReadOnly = true;
            this.dgvnv.Size = new System.Drawing.Size(849, 260);
            this.dgvnv.TabIndex = 31;
            this.dgvnv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvnv_CellDoubleClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxoa.Location = new System.Drawing.Point(197, 503);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(83, 23);
            this.btnxoa.TabIndex = 49;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // btnsua
            // 
            this.btnsua.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnsua.Location = new System.Drawing.Point(309, 503);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(83, 23);
            this.btnsua.TabIndex = 48;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            // 
            // btnghiluu
            // 
            this.btnghiluu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnghiluu.Location = new System.Drawing.Point(416, 503);
            this.btnghiluu.Name = "btnghiluu";
            this.btnghiluu.Size = new System.Drawing.Size(83, 23);
            this.btnghiluu.TabIndex = 47;
            this.btnghiluu.Text = "Ghi/lưu";
            this.btnghiluu.UseVisualStyleBackColor = true;
            this.btnghiluu.Click += new System.EventHandler(this.btnghiluu_Click);
            // 
            // button3
            // 
            this.button3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button3.Location = new System.Drawing.Point(525, 503);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(83, 23);
            this.button3.TabIndex = 46;
            this.button3.Text = "Không";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(638, 503);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(83, 23);
            this.button2.TabIndex = 45;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthemmoi.Location = new System.Drawing.Point(84, 503);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(83, 23);
            this.btnthemmoi.TabIndex = 44;
            this.btnthemmoi.Text = "Thêm ";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            // 
            // frmDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 538);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnghiluu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthemmoi);
            this.Controls.Add(this.txtmk);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtht);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttdn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txteml);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmnv);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvnv);
            this.Name = "frmDSNV";
            this.Text = "Danh sách nhân viên";
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvnv;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnghiluu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthemmoi;
    }
}