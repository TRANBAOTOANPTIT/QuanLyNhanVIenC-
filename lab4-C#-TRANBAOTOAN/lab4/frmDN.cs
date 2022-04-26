using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Security.Cryptography;

namespace lab4
{
    public partial class frmDN : Form
    {
        public frmDN()
        {
            InitializeComponent();
        }
        static string Hash(string input)
        {
            using (SHA1Managed sha1 = new SHA1Managed())
            {
                var hash = sha1.ComputeHash(Encoding.UTF8.GetBytes(input));
                var sb = new StringBuilder(hash.Length * 2);

                foreach (byte b in hash)
                {
                    // can be "x2" if you want lowercase
                    sb.Append(b.ToString("X2"));
                }

                return sb.ToString();
            }
        }
       
        private void btnluu_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=QLSV;Integrated Security=True");
            try
            {
                conn.Open();
                string tk = txtDN.Text;
                string mk = txtMK.Text;
                //"SELECT *FROM NHANVIEN WHERE TENDN =N'" + tk + "'  AND MATKHAU = HASHBYTES('SHA1','" + mk + "')  "
                // "SELECT *FROM NHANVIEN WHERE TENDN =N'" + tk + "'  AND MATKHAU = '"+Hash(mk)+"'  "
                string sql = "EXEC DANGNHAP '" + tk + "' , '" +Hash(mk)+ "'  ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");

                    new frmDSNV().ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
                }

            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                conn.Close();
            }
        }
    
        private void btnthoat_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
