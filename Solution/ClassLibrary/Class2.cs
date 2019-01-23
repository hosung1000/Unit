using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
   public class Class2
    {
        private MySqlConnection conn;
       public Class2()
        {
            try
            {
                conn = new  MySqlConnection();
                conn.ConnectionString = string.Format("server={0};user={1};password={2};database={3}", "192.168.3.136", "root", "1234", "test2");
                conn.Open();
            }
            catch
            {
                Console.WriteLine("DB 접속 오류");
            }
        }
        public MySqlDataReader Reader(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                return cmd.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        public int NoneQuery(string sql)
        {
            try
            {
                MySqlCommand cmd = new MySqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = sql;
                return cmd.ExecuteNonQuery();
            }
            catch
            {
                return 0;
            }
        }
    }
}
