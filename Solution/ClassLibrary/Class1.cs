using MySql.Data.MySqlClient;
using System;
using System.Collections;
using System.Data;

namespace ClassLibrary
{
    public class Class1
    {
        public MySqlConnection conn;
        
        //단위 테스트 : 클래스 매소드 단위
        //void 형은 테스트 할 필요가 없다.<비교를 못하니깐> 내가 실행하고자 하는 값과 돌아오는 값을 비교해봐야하는데.
        public int Test(int a, int b)
        {
            return (a + b);
        }

        //SELECT 문
        public ArrayList Select()
        {
            Class1 C1 = new Class1();
            MySqlDataReader sdr = C1.GetReader("sp_Select");
            ArrayList list = new ArrayList();
            while (sdr.Read())
            {
                string[] arr = new string[sdr.FieldCount];
                for (int i = 0; i < sdr.FieldCount; i++)
                {
                    arr[i] = sdr.GetValue(i).ToString();
                }
                list.Add(arr);
            }
            C1.ReaderClose(sdr);
            C1.ConnectionClose();
            return list;
        }
        //DB 연결
        public MySqlConnection GetConnection()
        {
            //DB 접속
            try
            {
                conn = new MySqlConnection();
               
                conn.ConnectionString = string.Format("server={0};user={1};password={2};database={3}", "192.168.3.136", "root", "1234", "test2");
                conn.Open();
                return conn;
            }
            //오류 걸릴때
            catch (MySqlException e)
            {
                Console.WriteLine("접속 실패");
                return null;
            }
        }
        //DB 종료
        public bool ConnectionClose()
        {
            try
            {
                conn.Close();
                return true;
            }
            catch
            {
                return false;
            }
        }
        //CRUD 중 SELECT
        public MySqlDataReader GetReader(string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = sql;
                comm.Connection = GetConnection();
                comm.CommandType = CommandType.StoredProcedure;
                return comm.ExecuteReader();
            }
            catch
            {
                return null;
            }
        }
        //SELECT 문 중지
        public void ReaderClose(MySqlDataReader GetReader)
        {
            GetReader.Close();
        }
        //CRUD 중 INSERT , DELETE , UPDATE
        public bool NonQuery(Hashtable ht , string sql)
        {
            try
            {
                MySqlCommand comm = new MySqlCommand();
                comm.CommandText = sql;
                comm.Connection = GetConnection();
                comm.CommandType = CommandType.StoredProcedure;

                foreach (DictionaryEntry data in ht)
                {
                    comm.Parameters.AddWithValue(data.Key.ToString(), data.Value);
                }
                comm.ExecuteNonQuery();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}

