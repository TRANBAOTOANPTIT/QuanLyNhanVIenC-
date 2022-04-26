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
    public partial class frmDssv : Form
    {
        public frmDssv()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            LoadDssv();
        }
      
        public void LoadDssv()
        {

            string tukhoa = txtTukhoa.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();

            lstPara.Add(new CustomParameter()
            {
                key = "@TUKHOA",
                value = tukhoa
            });
            dgvSv.DataSource = new Database().selectdata("SELECTALLFROMSINHVIEN", lstPara);
            dgvSv.Columns["MASV"].HeaderText = "Mã Lớp";
            dgvSv.Columns["HOTEN"].HeaderText = "Họ Tên";
            dgvSv.Columns["NGAYSINH"].HeaderText = "Ngày Sinh";
            dgvSv.Columns["DIACHI"].HeaderText = "Địa Chỉ";
            dgvSv.Columns["MALOP"].HeaderText = "Mã Lớp";
            dgvSv.Columns["TENDN"].HeaderText = "Tên Đăng Nhập";
            dgvSv.Columns["MATKHAU"].HeaderText = "Mật Khẩu";
        }

        private void dgvSv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvSv.Rows[e.RowIndex].Cells["MASV"].Value.ToString();
                new frmSinhvien(msv).ShowDialog();
                LoadDssv();
            }
        }
        private void btnThemmoi_Click(object sender, EventArgs e)
        {
            new frmSinhvien(null).ShowDialog();
            LoadDssv();

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
            dgvSv.DataSource = new Database().selectdata("SELECTALLFROMSINHVIEN", lstPara);
        }

        private void frmDssv_Load_1(object sender, EventArgs e)
        {
            LoadDssv();
        }
       
    }
}
