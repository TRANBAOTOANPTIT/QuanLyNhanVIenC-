using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Security.Cryptography;
using System.Data.SqlClient;
using System.Configuration;

namespace Lab4_NHOM_TRANBAOTOAN
{
    public partial class frmDSNV : Form
    {
        public frmDSNV()
        {
            InitializeComponent();
        }
        private string mnv = null;
        private void frmDSNV_Load(object sender, EventArgs e)
        {
            LoadDsnv();
        }
        public void LoadDsnv()
        {
            //var r = new Database().select("SELECTNV '" + mnv + "'");
            List<CustomParameter> lstPara = new List<CustomParameter>();
            this.dgvnv.DataSource = new Database().selectdata("SP_SEL_PUBLIC_ENCRYPT_NHANVIEN", lstPara);
            this.dgvnv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvnv_CellFormatting);
            dgvnv.Columns["MANV"].HeaderText = "Mã Nhân Viên";
            dgvnv.Columns["HOTEN"].HeaderText = "Họ Tên";
            dgvnv.Columns["EMAIL"].HeaderText = "Email";
            dgvnv.Columns["LUONG"].HeaderText = "Lương";
          

        }
        void dgvnv_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 3 && e.RowIndex != this.dgvnv.NewRowIndex)
            {

                string luong = e.Value.ToString();
                // MessageBox.Show(e.Value.ToString());
                /*int mod4 = e.Value.ToString().Length % 4;
                if (mod4 > 0)
                {
                    luong += new string('=', 4 - mod4);
                }*/
                e.Value = Encryptor.Decrypted(luong);

            }

        }
        void dgvnv_encrypt(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 3 && e.RowIndex != this.dgvnv.NewRowIndex)
            {

                string luong = e.Value.ToString();
                // MessageBox.Show(e.Value.ToString());
                /* int mod4 = e.Value.ToString().Length % 4;
                 if (mod4 > 0)
                 {
                     luong += new string('=', 4 - mod4);
                 }*/
                e.Value = Encryptor.Encrypt(luong);

            }


        }

        private void dgvnv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var mnv = dgvnv.Rows[e.RowIndex].Cells["MANV"].Value.ToString();
                this.mnv = mnv;
                loaddulieu(mnv);

            }
        }
        private void loaddulieu(string mnv)
        {

            if (string.IsNullOrEmpty(mnv))
            {
                this.Text = "Thêm nhân viên mới";
            }
            else
            {

                this.Text = "Cập nhập thông tin nhân viên";
                var r = new Database().select("SELECTNV '" + mnv + "'");
                txtmnv.Text = r["MANV"].ToString();
                txtht.Text = r["HOTEN"].ToString();
                txteml.Text = r["EMAIL"].ToString();
                string luong = r["LUONG"].ToString();
                /*int mod4 = r["LUONG"].ToString().Length % 4;
                if (mod4 > 0)
                {
                    luong += new string('=', 4 - mod4);
                }*/
                txtl.Text = Encryptor.Decrypted(luong);
                txttdn.Text = r["TENDN"].ToString();
                txtmk.Text = r["MATKHAU"].ToString();
               
                
            }

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
      

        private void btnghiluu_Click(object sender, EventArgs e)
        {
            string sql = "";

            string hoten = txtht.Text;
            string email = txteml.Text;
            string luong = Encryptor.Encrypt(txtl.Text);
            string tendn = txttdn.Text;
            string mk = Hash(txtmk.Text);
            List<CustomParameter> lstPara = new List<CustomParameter>();
            if (string.IsNullOrEmpty(mnv))
            {
                sql = "SP_INS_PUBLIC_ENCRYPT_NHANVIEN";

            }
            else
            {
                sql = "UPDATENV";

            }
            lstPara.Add(new CustomParameter()
            {
                key = "@MANV",
                value = txtmnv.Text
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@HOTEN",
                value = hoten
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@EMAIL",
                value = email
            });
            lstPara.Add(new CustomParameter()
            {
                key = "@LUONG",
                value = luong
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
            lstPara.Add(new CustomParameter()
            {

                key = "@PUBKEY",
                value = Encryptor.pubkey()
            });
            var rs = new Database().ExeCute(sql, lstPara);

            if (rs == 1)
            {
                if (string.IsNullOrEmpty(mnv))
                {
                    MessageBox.Show("Thêm Nhân viên mới thành công");
                }
                else
                {
                    MessageBox.Show("Cập nhập thông tin nhân viên thành công");

                }

                this.dgvnv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvnv_encrypt);
                LoadDsnv();
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
                if (string.IsNullOrEmpty(mnv))
                {
                    MessageBox.Show("Xóa Nhân viên không thành công");

                }
                else
                {
                    sql = "DELETENV";
                    lstPara.Add(new CustomParameter()
                    {
                        key = "@MANV",
                        value = mnv
                    });

                }
                var rs = new Database().ExeCute(sql, lstPara);

                if (rs == 1)
                {
                    if (string.IsNullOrEmpty(mnv))
                    {
                        MessageBox.Show("Xóa Nhân viên không thành công");

                    }
                    else
                    {
                        MessageBox.Show("Xóa Nhân viên thành công");

                    }
                    this.dgvnv.CellFormatting += new DataGridViewCellFormattingEventHandler(dgvnv_encrypt);
                    LoadDsnv();
                }
                else
                {

                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult dg = MessageBox.Show("Bạn có muốn thoát ?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dg == DialogResult.Yes)
                Application.Exit();
        }

        
    }
}
