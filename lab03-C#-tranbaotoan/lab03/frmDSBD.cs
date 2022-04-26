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
    public partial class frmDSBD : Form
    {
        public frmDSBD()
        {
            InitializeComponent();
        }

        private void frmDSBD_Load(object sender, EventArgs e)
        {
            LoadDsBD();
        }
        private void LoadDsBD()
        {

            string tukhoa = txtTK.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvDSBD.DataSource = new Database().selectdata("SELECTALLFROMBANGDIEM", lstPara);
            dgvDSBD.Columns["MASV"].HeaderText = "Mã sinh viên";
            dgvDSBD.Columns["MAHP"].HeaderText = "Mã học phần";
            dgvDSBD.Columns["DIEMTHI"].HeaderText = "điểm thi";
        }

        private void dgvDSBD_DoubleClick(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvDSBD.Rows[e.RowIndex].Cells["MASV"].Value.ToString();
                var mhp= dgvDSBD.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                new frmBD(msv,mhp).ShowDialog();
                LoadDsBD();
            }
        }

        private void btntk_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTK.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvDSBD.DataSource = new Database().selectdata("SELECTALLFROMBANGDIEM", lstPara);
        }

        private void btnnd_Click(object sender, EventArgs e)
        {
            new frmBD(null,null).ShowDialog();
            LoadDsBD();
        }
    }
}
