using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace CS464_F_NguyenHuuTri_5264
{
    class LopDungChung
    {
        string chuoiketnoi = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\AppUser\SaveCode\LT_UngDung\CS464_F_NguyenHuuTri_5264\QLHANG.mdf;Integrated Security=True";
        SqlConnection conn;
        public LopDungChung()
        {
            conn = new SqlConnection(chuoiketnoi);
        }
        public int Scalar(string sqlScalar)
        {
            SqlCommand comm = new SqlCommand(sqlScalar, conn);
            conn.Open();
            int ketqua = (int)comm.ExecuteScalar();
            conn.Close();
            return ketqua;
        }
        public void Nonquery(string sqlNonquery)
        {
            SqlCommand comm = new SqlCommand(sqlNonquery, conn);
            conn.Open();
            try
            {
                int ketqua = comm.ExecuteNonQuery();
                if (ketqua >= 1) 
                {
                    MessageBox.Show("Thành Công");
                } else
                {
                    MessageBox.Show("Thất Bại");
                }
            } catch(Exception)
            {
                MessageBox.Show("Lỗi cú pháp hoặc nhập thiếu thông tin");
            }
            finally
            {
                conn.Close();
            }
        }
        public DataTable LoadData(string sqlData)
        {
            SqlDataAdapter daData = new SqlDataAdapter(sqlData, conn);
            DataTable dtData = new DataTable();
            daData.Fill(dtData);
            return dtData;
        } 
    }
}
