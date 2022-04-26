using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab03
{
    public partial class frmTemp : Form
    {
        public frmTemp()
        {
            InitializeComponent();
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            
            new frmDSLOP().ShowDialog();
            this.Dispose(); 
        }

        private void btnNhapdiem_Click(object sender, EventArgs e)
        {
            new frmDSBD().ShowDialog();
            this.Dispose();
        }

        private void btnSv_Click(object sender, EventArgs e)
        {
            new frmDssv().ShowDialog();
            this.Dispose();
        }
    }
}
