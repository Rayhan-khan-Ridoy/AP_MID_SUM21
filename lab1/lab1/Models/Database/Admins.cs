using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace lab1.Models.Database
{
    public class Admins
    {
        SqlConnection conn;

        public Admins(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Admin A)
        {

            string query = "Insert into Admins values(@uname,@pa)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@uname", A.UserName);
            cmd.Parameters.AddWithValue("@pa", A.Password);
     
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}