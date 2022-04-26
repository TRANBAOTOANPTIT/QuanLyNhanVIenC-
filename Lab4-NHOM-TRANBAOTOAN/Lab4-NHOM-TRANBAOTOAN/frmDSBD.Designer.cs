namespace Lab4_NHOM_TRANBAOTOAN
{
    partial class frmDSBD
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
            this.txtdt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtmhp = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmsv = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvDSBD = new System.Windows.Forms.DataGridView();
            this.btntk = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnthoat = new System.Windows.Forms.Button();
            this.btnLuu = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBD)).BeginInit();
            this.SuspendLayout();
            // 
            // txtdt
            // 
            this.txtdt.Location = new System.Drawing.Point(88, 91);
            this.txtdt.Name = "txtdt";
            this.txtdt.Size = new System.Drawing.Size(144, 20);
            this.txtdt.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Điểm thi";
            // 
            // txtmhp
            // 
            this.txtmhp.Location = new System.Drawing.Point(88, 49);
            this.txtmhp.Name = "txtmhp";
            this.txtmhp.Size = new System.Drawing.Size(144, 20);
            this.txtmhp.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Mã học phần";
            // 
            // txtmsv
            // 
            this.txtmsv.Location = new System.Drawing.Point(88, 9);
            this.txtmsv.Name = "txtmsv";
            this.txtmsv.Size = new System.Drawing.Size(144, 20);
            this.txtmsv.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Mã sinh viên";
            // 
            // dgvDSBD
            // 
            this.dgvDSBD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDSBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBD.Location = new System.Drawing.Point(0, 130);
            this.dgvDSBD.MultiSelect = false;
            this.dgvDSBD.Name = "dgvDSBD";
            this.dgvDSBD.Size = new System.Drawing.Size(620, 195);
            this.dgvDSBD.TabIndex = 14;
            this.dgvDSBD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDSBD_CellDoubleClick);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(490, 10);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 17;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(355, 12);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(129, 20);
            this.txtTK.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(302, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Từ khóa";
            // 
            // btnthoat
            // 
            this.btnthoat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnthoat.Location = new System.Drawing.Point(409, 345);
            this.btnthoat.Name = "btnthoat";
            this.btnthoat.Size = new System.Drawing.Size(75, 23);
            this.btnthoat.TabIndex = 41;
            this.btnthoat.Text = "Thoát";
            this.btnthoat.UseVisualStyleBackColor = true;
            this.btnthoat.Click += new System.EventHandler(this.btnthoat_Click);
            // 
            // btnLuu
            // 
            this.btnLuu.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLuu.Location = new System.Drawing.Point(134, 345);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(75, 23);
            this.btnLuu.TabIndex = 40;
            this.btnLuu.Text = "Ghi/Lưu";
            this.btnLuu.UseVisualStyleBackColor = true;
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnxoa.Location = new System.Drawing.Point(274, 345);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(75, 23);
            this.btnxoa.TabIndex = 42;
            this.btnxoa.Text = "Xóa";
            this.btnxoa.UseVisualStyleBackColor = true;
            this.btnxoa.Click += new System.EventHandler(this.btnxoa_Click);
            // 
            // frmDSBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(619, 380);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnthoat);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dgvDSBD);
            this.Controls.Add(this.txtdt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtmhp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmsv);
            this.Controls.Add(this.label1);
            this.Name = "frmDSBD";
            this.Text = "Danh sách bảng điểm";
            this.Load += new System.EventHandler(this.frmDSBD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtdt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmhp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtmsv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvDSBD;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnthoat;
        private System.Windows.Forms.Button btnLuu;
        private System.Windows.Forms.Button btnxoa;
    }
}