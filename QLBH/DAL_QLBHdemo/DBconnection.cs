using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_QLBHdemo
{
    public class DBconnection
    {
       public string strConnect = "Server = (local)\\SQLEXPRESS;database=QLBHdemo;Integrated Security=True";
        SqlConnection conn = new SqlConnection();
        public DBconnection()
        {
            conn.ConnectionString = strConnect;
        }
        public void OpenConnection()
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }
        public void CloseConnection()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
        //Viết hàm thực 1 câu lệnh select, kết quả trả về 1 DatTable
        public DataTable ExcuteQuery(string commandtext)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(commandtext, conn);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            return ds.Tables[0];
        }

        //Viết hàm thực hiện insert, update, delete
        public int ExecuteNonQuery(string commandtext, SqlParameter[] sqlParameters)
        {
            SqlCommand comm = new SqlCommand();
            int data;
            try
            {
                comm.Connection = conn;
                OpenConnection();
                comm.CommandText = commandtext;
                comm.Parameters.AddRange(sqlParameters);
                data = comm.ExecuteNonQuery();
                CloseConnection();
                return data;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        } 
    }
}
 