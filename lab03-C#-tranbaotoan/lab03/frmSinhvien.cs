using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace lab03
{
    public partial class frmSinhvien : Form
    {
       public frmSinhvien(string msv)
        {
            this.msv = msv;
            InitializeComponent();
        }
       private string msv;
       private void frmSinhvien_Load(object sender, EventArgs e)
       {
           if (string.IsNullOrEmpty(msv))
           {
               this.Text = "Thêm Sinh viên mới";
           }
           else
           {
               this.Text = "Cập nhập thông tin Sinh viên";
               // lấy thông rin chi tiết của một lớp dựa vào mã lớp
               var r = new Database().select("SELECTSV '" + msv + "'");
               //MessageBox.Show(r[0].ToString());
               txtmsv.Text = r["MASV"].ToString();
               txtmsv.ReadOnly = true;
               txtht.Text = r["HOTEN"].ToString();
               mtbns.Text = r["NGAYSINH"].ToString();
               txtdc.Text = r["DIACHI"].ToString();
               txtml.Text = r["MALOP"].ToString();
               txtdn.Text = r["TENDN"].ToString();
               txtmk.Text = r["MATKHAU"].ToString();

           }
       }
        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string sql = "";
            string hoten = txtht.Text;
            DateTime ngaysinh;
            try{
                ngaysinh = DateTime.ParseExact(mtbns.Text, "dd/MM/yyyy", CultureInfo.InvariantCulture);
            }catch(Exception){
                MessageBox.Show("Ngày sinh không hợp lệ");
                mtbns.Select();
                return;
            }
                // ngaysinh = mtbns.Text;
            string diachi = txtdc.Text;
            string malop = txtml.Text;
            string tendn = txtdn.Text;
            string mk = txtmk.Text;
            SqlConnection conn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=QLSVNhom;Integrated Security=True");
            conn.Open();
            string sqll = "EXEC SVOFMNV '" + Form1.mnv + "' , '" + msv + "'  "; ;
            SqlCommand cmd = new SqlCommand(sqll, conn);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dta = cmd.ExecuteReader();
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
               
                sql = "THEMSVMOI";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MASV",
                    value = txtmsv.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@HOTEN",
                    value = hoten
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYSINH",
                    value = ngaysinh.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@DIACHI",
                    value = diachi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MALOP",
                    value = malop
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@TENDN",
                    value = tendn

                });

                lstPara.Add(new CustomParameter()
                {

                    key = "@MATKHAU",
                    value = mk
                });
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(msv))
                    {
                        MessageBox.Show("Thêm Sinh viên mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập thông tin sinh viên thành công");

                    }

                    
                }
                else
                {

                }
               
            }if (dta.Read() == true)
            {
                sql = "UPDATESV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MASV",
                    value = txtmsv.Text
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@HOTEN",
                    value = hoten
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@NGAYSINH",
                    value = ngaysinh.ToString("yyyy-MM-dd")
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@DIACHI",
                    value = diachi
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@MALOP",
                    value = malop
                });
                lstPara.Add(new CustomParameter()
                {
                    key = "@TENDN",
                    value = tendn

                });

                lstPara.Add(new CustomParameter()
                {

                    key = "@MATKHAU",
                    value = mk
                });
                var rs = new Database().ExeCute(sql, lstPara);
                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(msv))
                    {
                        MessageBox.Show("Thêm Sinh viên mới thành công");
                    }
                    else
                    {
                        MessageBox.Show("Cập nhập thông tin sinh viên thành công");

                    }
                    
                   
                }
                else
                {

                }
            }
            else { MessageBox.Show("Sinh viên không thuộc lớp nhân viên quản lý");
            
           
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn Hủy ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        private void btnxsv_Click(object sender, EventArgs e)
        {
            string sql = "";
            DialogResult dg = MessageBox.Show("Bạn có muốn xóa ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes) { 
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(msv))
            {
                MessageBox.Show("Xóa Sinh viên không thành công");

            }
            else
            {
                sql = "DELETESV";
                lstPara.Add(new CustomParameter()
                {
                    key = "@MASV",
                    value = msv
                });

            }
            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(msv))
                {
                    MessageBox.Show("Xóa Sinh viên không thành công");
                   
                }
                else
                {
                    MessageBox.Show("Xóa Sinh viên thành công");

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
