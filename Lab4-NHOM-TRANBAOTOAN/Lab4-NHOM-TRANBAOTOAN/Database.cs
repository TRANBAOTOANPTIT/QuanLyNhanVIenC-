using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Lab4_NHOM_TRANBAOTOAN
{
   public class Database
   {
       private SqlConnection conn;
       private DataTable dt;
       private SqlCommand cmd;

       //SqlConnection conn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=QLSVNhom;Integrated Security=True");
       public Database()
       {
           try
           {
               conn = new SqlConnection(@"Data Source=HP-PC;Initial Catalog=QLSVNhom;Integrated Security=True");
               conn.Open();
           }
           catch (Exception ex)
           {
               MessageBox.Show("Lỗi kết nối: " + ex.Message);
           }
           finally
           {
               conn.Close();
           }
       }
       public  DataTable selectdata(String sql, List<CustomParameter> lstPara)
       {
           try
           {
               conn.Open();
               cmd = new SqlCommand(sql, conn);
               dt = new DataTable();
               cmd.CommandType = CommandType.StoredProcedure;
               foreach (var p in lstPara)
               {
                   cmd.Parameters.AddWithValue(p.key, p.value);
               }
               dt.Load(cmd.ExecuteReader());
               return dt;
           }
           catch (Exception ex)
           {
               MessageBox.Show("Lỗi load dữ liệu: " + ex.Message);
               return null;
           }
           finally
           {
               conn.Close();
           }

       }

       public DataRow select(string sql)
       {

           try
           {
               conn.Open();
               cmd = new SqlCommand(sql, conn);
               dt = new DataTable();
               dt.Load(cmd.ExecuteReader());
               return dt.Rows[0];
           }
           catch (Exception ex)
           {
               MessageBox.Show("Lỗi load thông tin chi tiết: " + ex.Message);
               return null;
           }
           finally
           {

               conn.Close();
           }
       }
       public int ExeCute(string sql, List<CustomParameter> lstPara)
       {
           try
           {
               conn.Open();
               cmd = new SqlCommand(sql, conn);
               cmd.CommandType = CommandType.StoredProcedure;
               foreach (var p in lstPara)
               {
                   cmd.Parameters.AddWithValue(p.key, p.value);
               }
               var rs = cmd.ExecuteNonQuery();
               return (int)rs;
           }
           catch (Exception ex)
           {
               MessageBox.Show("Lỗi thực thi câu lệnh: " + ex.Message);
               return -100;
           }
           finally
           {

               conn.Close();
           }

       } 
    }
}
