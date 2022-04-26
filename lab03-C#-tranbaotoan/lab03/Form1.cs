using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;

namespace lab03
{   
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        public static string mnv;
        private void label1_Click(object sender, EventArgs e)
        {

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

        
        private void btnlogin_Click(object sender, EventArgs e)
        {   
            SqlConnection conn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=QLSVNhom;Integrated Security=True");
            try{
                conn.Open();
                string tk = txttaikhoan.Text;
                mnv = txttaikhoan.Text;
                string mk = txtmatkhau.Text;
                //SELECT *FROM NHANVIEN WHERE TENDN =N'" + tk + "'  AND MATKHAU = HASHBYTES('SHA1','" + mk + "') "
                string sql = "SELECT *FROM NHANVIEN WHERE MANV =N'" + tk + "'  AND MATKHAU = HASHBYTES('SHA1','" + mk + "')  ";
                SqlCommand cmd = new SqlCommand(sql,conn);
                cmd.CommandType = CommandType.Text;
                SqlDataReader dta = cmd.ExecuteReader();
                if (dta.Read() == true)
                {
                    MessageBox.Show("Đăng nhập thành công");
                    
                    new frmTemp().ShowDialog();
                    this.Close();
                }
                else {
                    MessageBox.Show("Tên đăng nhập và mật khẩu không hợp lệ");
                }
                
            }catch(Exception ){
             MessageBox.Show("Lỗi kết nối");
            }
            finally
            {
                conn.Close();
            }
        }

        private void txtmatkhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }
    }
}
