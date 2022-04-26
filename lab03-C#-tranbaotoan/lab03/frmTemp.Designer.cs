namespace lab03
{
    partial class frmTemp
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
            this.btnLop = new System.Windows.Forms.Button();
            this.btnSv = new System.Windows.Forms.Button();
            this.btnNhapdiem = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnLop
            // 
            this.btnLop.Location = new System.Drawing.Point(101, 44);
            this.btnLop.Name = "btnLop";
            this.btnLop.Size = new System.Drawing.Size(75, 23);
            this.btnLop.TabIndex = 0;
            this.btnLop.Text = "Lớp";
            this.btnLop.UseVisualStyleBackColor = true;
            this.btnLop.Click += new System.EventHandler(this.btnLop_Click);
            // 
            // btnSv
            // 
            this.btnSv.Location = new System.Drawing.Point(101, 97);
            this.btnSv.Name = "btnSv";
            this.btnSv.Size = new System.Drawing.Size(75, 23);
            this.btnSv.TabIndex = 1;
            this.btnSv.Text = "Sinh viên";
            this.btnSv.UseVisualStyleBackColor = true;
            this.btnSv.Click += new System.EventHandler(this.btnSv_Click);
            // 
            // btnNhapdiem
            // 
            this.btnNhapdiem.Location = new System.Drawing.Point(101, 150);
            this.btnNhapdiem.Name = "btnNhapdiem";
            this.btnNhapdiem.Size = new System.Drawing.Size(75, 23);
            this.btnNhapdiem.TabIndex = 2;
            this.btnNhapdiem.Text = "Nhập Điểm";
            this.btnNhapdiem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnNhapdiem.UseVisualStyleBackColor = true;
            this.btnNhapdiem.Click += new System.EventHandler(this.btnNhapdiem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(120, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Quản Lý";
            // 
            // frmTemp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(313, 261);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnNhapdiem);
            this.Controls.Add(this.btnSv);
            this.Controls.Add(this.btnLop);
            this.Name = "frmTemp";
            this.Text = "frmTemp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLop;
        private System.Windows.Forms.Button btnSv;
        private System.Windows.Forms.Button btnNhapdiem;
        private System.Windows.Forms.Label label1;
    }
}