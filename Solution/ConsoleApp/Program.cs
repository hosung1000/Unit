using System;
using System.Collections;
using ClassLibrary;
using MySql.Data.MySqlClient;

namespace ConsoleApp
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Class2 C2 = new Class2();

            //데이터 SELECT
            string sql = "SELECT * FROM Notice2;";
            MySqlDataReader sdr = C2.Reader(sql);
            int cnt = 0;
            while (sdr.Read())
            {
                cnt++;
            }
            //Reader를 닫아줘야 다음 쿼리가 실행 될수 있다.
            sdr.Close();
            Console.WriteLine("총 데이터 수 : {0}", cnt);

            //데이터 입력처리 부분
            sql = "INSERT INTO Notice2 (nTitle, nContents, mName) VALUES ('4', '5', '6');";
            int status =  C2.NoneQuery(sql);
            Console.WriteLine("데이터 삽입 결과 : {0}", status);

            //입력한 데이터 PK 가져오기
            sql = "SELECT max(mNo) as mNo FROM Notice2;";
            sdr = C2.Reader(sql);
            int mNo = 0;
            while (sdr.Read())
            {
                mNo = Convert.ToInt32(sdr["mNo"]);
            }
            sdr.Close();
            Console.WriteLine("mNo = {0}", mNo);

            //데이터 업데이트 부분
            sql = string.Format("UPDATE Notice2 SET mName = '테스터2' WHERE mNo = {0};", mNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("데이터 수정 결과 : {0}", status);

            //데이터 업데이트 -> 삭제 부분
            sql = string.Format("UPDATE Notice2 SET delYn = 'Y' WHERE mNo = {0}" ,mNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("데이터 삭제 결과 : {0}", status);

        }
    }
}
