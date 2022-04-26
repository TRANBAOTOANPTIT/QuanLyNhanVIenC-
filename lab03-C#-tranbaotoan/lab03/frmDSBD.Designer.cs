namespace lab03
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
            this.dgvDSBD = new System.Windows.Forms.DataGridView();
            this.btnnd = new System.Windows.Forms.Button();
            this.btntk = new System.Windows.Forms.Button();
            this.txtTK = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBD)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDSBD
            // 
            this.dgvDSBD.AllowUserToAddRows = false;
            this.dgvDSBD.AllowUserToDeleteRows = false;
            this.dgvDSBD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDSBD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDSBD.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvDSBD.Location = new System.Drawing.Point(0, 63);
            this.dgvDSBD.Name = "dgvDSBD";
            this.dgvDSBD.ReadOnly = true;
            this.dgvDSBD.Size = new System.Drawing.Size(556, 198);
            this.dgvDSBD.TabIndex = 9;
            this.dgvDSBD.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // btnnd
            // 
            this.btnnd.Location = new System.Drawing.Point(469, 8);
            this.btnnd.Name = "btnnd";
            this.btnnd.Size = new System.Drawing.Size(75, 23);
            this.btnnd.TabIndex = 8;
            this.btnnd.Text = "Nhập Điểm";
            this.btnnd.UseVisualStyleBackColor = true;
            this.btnnd.Click += new System.EventHandler(this.btnnd_Click);
            // 
            // btntk
            // 
            this.btntk.Location = new System.Drawing.Point(388, 8);
            this.btntk.Name = "btntk";
            this.btntk.Size = new System.Drawing.Size(75, 23);
            this.btntk.TabIndex = 7;
            this.btntk.Text = "Tìm kiếm";
            this.btntk.UseVisualStyleBackColor = true;
            this.btntk.Click += new System.EventHandler(this.btntk_Click);
            // 
            // txtTK
            // 
            this.txtTK.Location = new System.Drawing.Point(253, 10);
            this.txtTK.Name = "txtTK";
            this.txtTK.Size = new System.Drawing.Size(129, 20);
            this.txtTK.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(200, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Từ khóa";
            // 
            // frmDSBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 261);
            this.Controls.Add(this.dgvDSBD);
            this.Controls.Add(this.btnnd);
            this.Controls.Add(this.btntk);
            this.Controls.Add(this.txtTK);
            this.Controls.Add(this.label1);
            this.Name = "frmDSBD";
            this.Text = "frmDSBD";
            this.Load += new System.EventHandler(this.frmDSBD_Load);
            this.DoubleClick += new System.EventHandler(this.dgvDSBD_DoubleClick);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDSBD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDSBD;
        private System.Windows.Forms.Button btnnd;
        private System.Windows.Forms.Button btntk;
        private System.Windows.Forms.TextBox txtTK;
        private System.Windows.Forms.Label label1;

    }
}