namespace lab03
{
    partial class frmDssv
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtTukhoa = new System.Windows.Forms.TextBox();
            this.btnTimkiem = new System.Windows.Forms.Button();
            this.btnThemmoi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSv
            // 
            this.dgvSv.AllowUserToAddRows = false;
            this.dgvSv.AllowUserToDeleteRows = false;
            this.dgvSv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSv.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvSv.Location = new System.Drawing.Point(0, 45);
            this.dgvSv.MultiSelect = false;
            this.dgvSv.Name = "dgvSv";
            this.dgvSv.ReadOnly = true;
            this.dgvSv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSv.Size = new System.Drawing.Size(838, 275);
            this.dgvSv.TabIndex = 0;
            this.dgvSv.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSv_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(457, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Từ khóa";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtTukhoa
            // 
            this.txtTukhoa.Location = new System.Drawing.Point(510, 14);
            this.txtTukhoa.Name = "txtTukhoa";
            this.txtTukhoa.Size = new System.Drawing.Size(141, 20);
            this.txtTukhoa.TabIndex = 2;
            // 
            // btnTimkiem
            // 
            this.btnTimkiem.Location = new System.Drawing.Point(670, 12);
            this.btnTimkiem.Name = "btnTimkiem";
            this.btnTimkiem.Size = new System.Drawing.Size(75, 23);
            this.btnTimkiem.TabIndex = 3;
            this.btnTimkiem.Text = "Tìm Kiếm";
            this.btnTimkiem.UseVisualStyleBackColor = true;
            this.btnTimkiem.Click += new System.EventHandler(this.btnTimkiem_Click);
            // 
            // btnThemmoi
            // 
            this.btnThemmoi.Location = new System.Drawing.Point(751, 12);
            this.btnThemmoi.Name = "btnThemmoi";
            this.btnThemmoi.Size = new System.Drawing.Size(75, 23);
            this.btnThemmoi.TabIndex = 4;
            this.btnThemmoi.Text = "Thêm mới";
            this.btnThemmoi.UseVisualStyleBackColor = true;
            this.btnThemmoi.Click += new System.EventHandler(this.btnThemmoi_Click);
            // 
            // frmDssv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 320);
            this.Controls.Add(this.btnThemmoi);
            this.Controls.Add(this.btnTimkiem);
            this.Controls.Add(this.txtTukhoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSv);
            this.Name = "frmDssv";
            this.Text = "frmDssv";
            this.Load += new System.EventHandler(this.frmDssv_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTukhoa;
        private System.Windows.Forms.Button btnTimkiem;
        private System.Windows.Forms.Button btnThemmoi;
    }
}