using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab4_NHOM_TRANBAOTOAN
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            Application.Exit();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            frmDSNV f = new frmDSNV();
            addform(f);
        }
        private void addform(Form f)
        {
            this.pnlContent.Controls.Clear();
            f.TopLevel = false;
            f.AutoScroll = true;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            this.Text = f.Text;
            this.pnlContent.Controls.Add(f);
            f.Show();

        }

        private void nhanvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSNV f = new frmDSNV();
            addform(f);
        }

        private void lophocToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSLOP f = new frmDSLOP();
            addform(f);
        }

        private void sinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSSV f = new frmDSSV();
            addform(f);
        }

        private void bangdiemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDSBD f = new frmDSBD();
            addform(f);
        }
    }
}
