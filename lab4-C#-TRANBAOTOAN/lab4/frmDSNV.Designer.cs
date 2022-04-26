namespace lab4
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
            this.dgvnv = new System.Windows.Forms.DataGridView();
            this.btnxoa = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnghiluu = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnthemmoi = new System.Windows.Forms.Button();
            this.txtmnv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txteml = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txttdn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtht = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtl = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmk = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvnv
            // 
            this.dgvnv.AllowUserToAddRows = false;
            this.dgvnv.AllowUserToDeleteRows = false;
            this.dgvnv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvnv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvnv.Location = new System.Drawing.Point(-1, 179);
            this.dgvnv.MultiSelect = false;
            this.dgvnv.Name = "dgvnv";
            this.dgvnv.ReadOnly = true;
            this.dgvnv.Size = new System.Drawing.Size(849, 260);
            this.dgvnv.TabIndex = 0;
            this.dgvnv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnxoa
            // 
            this.btnxoa.Location = new System.Drawing.Point(199, 472);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(82, 23);
            this.btnxoa.TabIndex = 16;
            this.btnxoa.Text = "Xoá";
            this.btnxoa.UseVisualStyleBackColor = true;
            // 
            // btnsua
            // 
            this.btnsua.Location = new System.Drawing.Point(311, 472);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(82, 23);
            this.btnsua.TabIndex = 15;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = true;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnghiluu
            // 
            this.btnghiluu.Location = new System.Drawing.Point(418, 472);
            this.btnghiluu.Name = "btnghiluu";
            this.btnghiluu.Size = new System.Drawing.Size(82, 23);
            this.btnghiluu.TabIndex = 14;
            this.btnghiluu.Text = "Ghi/lưu";
            this.btnghiluu.UseVisualStyleBackColor = true;
            this.btnghiluu.Click += new System.EventHandler(this.btnghiluu_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(527, 472);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 23);
            this.button3.TabIndex = 13;
            this.button3.Text = "Không";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(640, 472);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(82, 23);
            this.button2.TabIndex = 12;
            this.button2.Text = "Thoát";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnthemmoi
            // 
            this.btnthemmoi.Location = new System.Drawing.Point(86, 472);
            this.btnthemmoi.Name = "btnthemmoi";
            this.btnthemmoi.Size = new System.Drawing.Size(82, 23);
            this.btnthemmoi.TabIndex = 11;
            this.btnthemmoi.Text = "Thêm ";
            this.btnthemmoi.UseVisualStyleBackColor = true;
            this.btnthemmoi.Click += new System.EventHandler(this.btnthemmoi_Click);
            // 
            // txtmnv
            // 
            this.txtmnv.Location = new System.Drawing.Point(136, 33);
            this.txtmnv.Name = "txtmnv";
            this.txtmnv.Size = new System.Drawing.Size(181, 20);
            this.txtmnv.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Mã NV";
            // 
            // txteml
            // 
            this.txteml.Location = new System.Drawing.Point(136, 86);
            this.txteml.Name = "txteml";
            this.txteml.Size = new System.Drawing.Size(181, 20);
            this.txteml.TabIndex = 22;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "Email";
            // 
            // txttdn
            // 
            this.txttdn.Location = new System.Drawing.Point(136, 138);
            this.txttdn.Name = "txttdn";
            this.txttdn.Size = new System.Drawing.Size(181, 20);
            this.txttdn.TabIndex = 24;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 23;
            this.label3.Text = "Tên Đăng Nhập";
            // 
            // txtht
            // 
            this.txtht.Location = new System.Drawing.Point(473, 33);
            this.txtht.Name = "txtht";
            this.txtht.Size = new System.Drawing.Size(174, 20);
            this.txtht.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(389, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 25;
            this.label4.Text = "Họ Tên";
            // 
            // txtl
            // 
            this.txtl.Location = new System.Drawing.Point(473, 86);
            this.txtl.Name = "txtl";
            this.txtl.Size = new System.Drawing.Size(174, 20);
            this.txtl.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(389, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "Lương";
            // 
            // txtmk
            // 
            this.txtmk.Location = new System.Drawing.Point(473, 138);
            this.txtmk.Name = "txtmk";
            this.txtmk.Size = new System.Drawing.Size(174, 20);
            this.txtmk.TabIndex = 30;
            this.txtmk.UseSystemPasswordChar = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 138);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Mật Khẩu";
            // 
            // frmDSNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 518);
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
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnghiluu);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnthemmoi);
            this.Controls.Add(this.dgvnv);
            this.Name = "frmDSNV";
            this.Text = "Danh  sách nhân viên";
            this.Load += new System.EventHandler(this.frmDSNV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvnv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvnv;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnghiluu;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnthemmoi;
        private System.Windows.Forms.TextBox txtmnv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txteml;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txttdn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtht;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtmk;
        private System.Windows.Forms.Label label6;
    }
}

