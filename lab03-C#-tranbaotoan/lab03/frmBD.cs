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
    public partial class frmBD : Form
    {
        public frmBD(string msv,string mhp)
        {
            this.msv = msv;
            this.mhp = mhp;
            InitializeComponent();
        }
        private string msv;
        private string mhp;
        private void frmBD_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(msv))
            {
                this.Text = "Nhập điểm mới";
            }
            else
            {
                this.Text = "Cập nhập điểm";
                // lấy thông rin chi tiết của một sv dựa vào mã sv
                var r = new Database().select("SELECTBANGDIEM '" + msv + "','" +mhp+ "'");
                //MessageBox.Show(r[0].ToString());
                txtmsv.Text = r["MASV"].ToString();
                txtmsv.ReadOnly = true;
                txtmhp.Text = r["MAHP"].ToString();
                txtdt.Text = r["DIEMTHI"].ToString();

            }
        }

        private void btnhuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn Hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnluu_Click(object sender, EventArgs e)
        {
            string sql = "";
          
            string mahp = txtmhp.Text;
            string diemthi = txtdt.Text;
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
                this.Dispose();
            }
            else
            {

            }
        }

       
    }
}
