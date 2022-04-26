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
    public partial class frmDSLOP : Form
    {
        public frmDSLOP()
        {
            InitializeComponent();
        }
        private string mlop = null;
        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex >= 0)
            {
                var mlop = dgvLop.Rows[e.RowIndex].Cells["MALOP"].Value.ToString();
                this.mlop = mlop;
                loaddulieu(mlop);
            }
        }
        private void LoadDslop()
        {

            string tukhoa = txtTukhoa.Text;
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

        private void frmDSLOP_Load(object sender, EventArgs e)
        {
            LoadDslop();
        }
        private void loaddulieu(string mlop)
        {
            if (string.IsNullOrEmpty(mlop))
            {
                this.Text = "Thêm lớp mới";
            }
            else
            {
                this.Text = "Cập nhập thông tin lớp";
                // lấy thông rin chi tiết của một lớp dựa vào mã lớp
                var r = new Database().select("SELECTLOP '" + mlop + "'");
                //MessageBox.Show(r[0].ToString());
                txtml.Text = r["MALOP"].ToString();
                txtml.ReadOnly = true;
                txttl.Text = r["TENLOP"].ToString();
                txtmnv.Text = r["MANV"].ToString();
            }

        }

        private void btnghiluu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenlop = txttl.Text;
            string manv = txtmnv.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mlop))
            {
                sql = "THEMMOILOP";

            }
            else
            {
                sql = "UPDATELOP";
                
            }
            lstPara.Add(new CustomParameter()
            {
                key = "@MALOP",
                value = txtml.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@TENLOP",
                value = tenlop
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MANV",
                value = manv
            });

            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mlop))
                {
                    MessageBox.Show("Thêm lớp mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập thông tin lớp thành công");

                }
                LoadDslop();
            }
            else
            {

            }
        }

        private void btnxoa_Click(object sender, EventArgs e)
        {
            string sql = "";
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
            {
                List<CustomParameter> lstPara = new List<CustomParameter>();
                if (string.IsNullOrEmpty(mlop))
                {
                    MessageBox.Show("Xóa lớp không thành công");

                }
                else
                {
                    sql = "DELETELOP";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MALOP",
                        value = mlop
                    });

                }
                var rs = new Database().ExeCute(sql, lstPara);

                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mlop))
                    {
                        MessageBox.Show("Xóa lớp không thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa lớp thành công");

                    }
                    LoadDslop();
                }
                else
                {

                }
            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btntk_Click(object sender, EventArgs e)
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
