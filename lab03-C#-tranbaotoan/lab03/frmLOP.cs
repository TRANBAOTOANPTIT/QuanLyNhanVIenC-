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
    public partial class frmLOP : Form
    {
        public frmLOP(string mlop)
        {
            this.mlop = mlop;
            InitializeComponent();
        }
        private string mlop;
        private void frmLOP_Load(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(mlop)){
                this.Text = "Thêm lớp mới";
            }
            else
            {
                this.Text = "Cập nhập thông tin lớp";
                // lấy thông rin chi tiết của một lớp dựa vào mã lớp
                var r = new Database().select("SELECTLOP '"+mlop+"'");
                //MessageBox.Show(r[0].ToString());
                txtMalop.Text = r["MALOP"].ToString();
                txtMalop.ReadOnly = true;
                txtTenlop.Text = r["TENLOP"].ToString();
                txtManv.Text = r["MANV"].ToString();

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
       
        
        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string tenlop = txtTenlop.Text;
            string manv = txtManv.Text;
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mlop))
            {
                sql = "THEMLOPMOI";
               
            }else
            {
                sql = "UPDATELOP";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MALOP",
                    value = mlop
                });
            }
           
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
                this.Dispose();
            }else
            {

            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn Hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnxlop_Click(object sender, EventArgs e)
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
                    this.Dispose();
                }
                else
                {

                }
            }
        }

       
    }
}
