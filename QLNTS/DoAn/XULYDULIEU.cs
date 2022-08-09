using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DoAn
{
    class XULYDULIEU
    {
        SqlConnection con;
        SqlCommand commad;
        SqlDataAdapter da;
        public XULYDULIEU()
        {
            string chuoiKetNoi = @"server=DESKTOP-0M7P8F7\KIEN123; database=DOANVANG; Integrated Security = true;";
            con = new SqlConnection(chuoiKetNoi);
        }
        public XULYDULIEU(string sv, string db, bool au, string uid, string pwd)
        {
            string chuoiketnoi = "";
            if (au == true)
                chuoiketnoi = string.Format(@"Data source={0}; Initial Catalog={1}; Integrated Security={2};", sv, db, au);
            else
                chuoiketnoi = string.Format(@"Data source={0};Initial Catalog={1}; Integrated Security=false; uid={2};pwd={3}", sv, db, uid, pwd);
            con = new SqlConnection(chuoiketnoi);
        }
        public DataTable docDuLieu(string sql)
        {
            DataTable dt = new DataTable();
            da = new SqlDataAdapter(sql, con);
            da.Fill(dt);
            return dt;
        }
        public SqlDataReader readTable(string sql)
        {
            SqlCommand command = new SqlCommand(sql, con);
            if (con.State == ConnectionState.Closed)
                con.Open();
            SqlDataReader dr = command.ExecuteReader();
            return dr;
        }
        public int ThemXoaSua(string sql) // tren tung dong vao database
        {
            if (con.State == ConnectionState.Closed)
                con.Open();
            commad = new SqlCommand(sql, con);
            int kq = commad.ExecuteNonQuery();
            con.Close();
            return kq;
        }
        public void CapNhat(string lenhSql, DataTable dt)// cap nhat 1 bang xuống database
        {
            da = new SqlDataAdapter(lenhSql, con);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);
            da.Update(dt);
        }
    }
}
