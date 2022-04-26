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
    public partial class frmDSLOP : Form
    {
        public frmDSLOP()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dgvLop_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frmLOP_Load(object sender, EventArgs e)
        {
            LoadDslop();
        }

        private void LoadDslop()
        {

            string tukhoa= txtTukhoa.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            
            lstPara.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvLop.DataSource = new Database().selectdata("SELECTALLFROMLOP", lstPara);
            dgvLop.Columns["MALOP"].HeaderText = "Mã Lớp";
            dgvLop.Columns["TENLOP"].HeaderText = "Tên Lớp";
            dgvLop.Columns["MANV"].HeaderText = "Mã Nhân viên";
        }

        private void dgvLop_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex>=0){
                var mlop = dgvLop.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                new frmLOP(mlop).ShowDialog();
                LoadDslop();
            }
        }

        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmLOP(null).ShowDialog();
            LoadDslop();
        }

        private void btnTimkiem_Click(object sender, EventArgs e)
        {
            string tukhoa = txtTukhoa.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvLop.DataSource = new Database().selectdata("SELECTALLFROMLOP", lstPara);
        }
    }
}
