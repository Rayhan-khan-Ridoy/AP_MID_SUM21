using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace lab1.Models.Database
{
    public class Students
    {
        SqlConnection conn;

        public Students(SqlConnection conn)
        {
            this.conn = conn;
        }
        public void Insert(Student S)
        {
           
            string query = "Insert into Students values(@name,@id,@dob,@cre,@cgpa,@Dept)";
            SqlCommand cmd = new SqlCommand(query, conn);
            cmd.Parameters.AddWithValue("@name", S.Name);
            cmd.Parameters.AddWithValue("@id", S.ID);
            cmd.Parameters.AddWithValue("@dob", S.DOB);
            cmd.Parameters.AddWithValue("@cre", S.Credit);
            cmd.Parameters.AddWithValue("@cgpa", S.CGPA);
            cmd.Parameters.AddWithValue("@Dept", S.Dept_id);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }
    }
}