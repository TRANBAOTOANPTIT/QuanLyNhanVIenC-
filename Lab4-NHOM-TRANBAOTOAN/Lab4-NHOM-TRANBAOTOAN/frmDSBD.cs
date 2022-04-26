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
    public partial class frmDSBD : Form
    {
        private string msv;
        private string mhp;
        public frmDSBD()
        {
            this.msv = msv;
            this.mhp = mhp;
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
            this.dgvDSBD.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvbd_CellFormatting);
            dgvDSBD.Columns["MASV"].HeaderText = "Mã sinh viên";
            dgvDSBD.Columns["MAHP"].HeaderText = "Mã học phần";
            dgvDSBD.Columns["DIEMTHI"].HeaderText = "điểm thi";
        }
        void dgvbd_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 2 && e.RowIndex != this.dgvDSBD.NewRowIndex)
            {

                string diem = e.Value.ToString();
                // MessageBox.Show(e.Value.ToString());
               int mod4 = e.Value.ToString().Length % 4;
                if (mod4 > 0)
                {
                    diem += new string('=', 4 - mod4);
                }
                e.Value = Encryptor.Decrypted(diem);

            }

        }
        void dgvbd_encrypt(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 2 && e.RowIndex != this.dgvDSBD.NewRowIndex)
            {

                string diem = e.Value.ToString();
               
                e.Value = Encryptor.Encrypt(diem);

            }


        }
        private void dgvDSBD_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var msv = dgvDSBD.Rows[e.RowIndex].Cells["MASV"].Value.ToString();
                var mhp = dgvDSBD.Rows[e.RowIndex].Cells["MAHP"].Value.ToString();
                this.msv = msv;
                this.mhp = mhp;
                loaddulieu(msv,mhp);
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
        private void loaddulieu(string msv,string mhp)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Nhập điểm mới";
            }
            else
            {
                this.Text = "Cập nhập điểm";
                // lấy thông rin chi tiết của một sv dựa vào mã sv
                var r = new Database().select("SELECTBANGDIEM '" + msv + "','" + mhp + "'");
                //MessageBox.Show(r[0].ToString());
                txtmsv.Text = r["MASV"].ToString();   
                txtmhp.Text = r["MAHP"].ToString();
                txtdt.Text = Encryptor.Decrypted(r["DIEMTHI"].ToString());

            }
        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                this.Dispose();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string mahp = txtmhp.Text;
            string diemthi = Encryptor.Encrypt(txtdt.Text);
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                sql = "NHAPDIEMSV";

            }
            else
            {
                sql = "UPDATEDIEM";

            }
            lstPara.Add(new CustomParameter()
            {
                key = "@MASV",
                value = txtmsv.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@MAHP",
                value = mahp
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@DIEMTHI",
                value = diemthi
            });

            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Thêm mới điểm thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập diểm thành công");

                }
                this.dgvDSBD.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvbd_encrypt);
                LoadDsBD();
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
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Xóa điểm không thành công");

                }
                else
                {
                    sql = "DELETEDIEM";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MASV",
                        value = msv
                    });
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MAHP",
                        value = mhp
                    });

                }
                var rs = new Database().ExeCute(sql, lstPara);

                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(msv))
                    {
                        MessageBox.Show("Xóa điểm không thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa điểm thành công");

                    }
                    this.dgvDSBD.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvbd_encrypt);
                    LoadDsBD();
                }
                else
                {

                }
            }
        }
    }
}
