using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace lab1.Models.Database
{
    public class Database
    {
        public Students Students { get; set; }

        public Database()
        {
            string connString = @"Server=DESKTOP-R96QE19\LOCALDB#AFD1CA09;Database=Students;Integrated Security=true;";
            SqlConnection conn = new SqlConnection(connString);

            Students = new Students(conn);

        }
    }
}