using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
namespace FanEase.Model.Common
{

    public static class SqlRepository
    {
        private static SqlConnection _conn;

        public static SqlConnection GetOpenConnection()
        {
            _conn = new SqlConnection( "Data Source=180.149.240.247;Initial Catalog=FAMP_Dev;Persist Security Info=True;User ID=famp_dbusers;Password=famp123!@#;");
            return _conn;
        }

        public static void OpenConnection(SqlConnection conn)
        {
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
        }


        public static void Dispose(SqlConnection conn)
        {
            if (conn != null && conn.State == ConnectionState.Open)
            {
                conn.Close();
            }
        }
    }
}
