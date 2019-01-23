using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using MySql.Data.MySqlClient;

namespace UnitTestProject
{
    // [] 의존성 클라스 : 이 클라스는 TEST하기위해 만들어진 클라스다
    [TestClass]
    public class UnitTest1
    {
        // [] 의존성 매서드 : 이 매서드는 TEST하기 위해 만들어진 매서드다. || 요즘은 의존성(DI) 주입 매서드나 클라스를 많이 짠다.
        [TestMethod]
        public void TestMethod1()
        {
            Class1 C1 = new Class1();
            int a = 1;
            int b = 3;
            Console.WriteLine(C1.Test(a, b));

            int c = (a + b); //4
            int d = C1.Test(a, b);
            //c 는 내가 위의 값의 결과값을 예상한건데 이걸 비교해주는게 Unit 이다.
            Assert.AreEqual(c, d); 
            /*  테스트 실행은 위의 테스트 창에 실행을 누르면 된다.
                실행 해보면 테스트 탐색기가 옆에 생성될것이고 녹생동그라미에 v표가 쳐지는걸 확인할수 있는데
                v표가 보이면 정상작동이고 빨간동그라미v표는 비정상작동중이다. */

        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("데이터베이스 테스트 시작");

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
            int status = C2.NoneQuery(sql);
            Console.WriteLine("데이터 삽입 결과 : {0}", status);

            /// 데이터 건수 확인 || 기존 cnt 와 데이터 입력후의 cnt 비교
            sql = "SELECT COUNT(*) as cnt FROM Notice2";
            sdr = C2.Reader(sql);
            while (sdr.Read())
            {
                Assert.AreEqual(cnt + 1, Convert.ToInt32(sdr["cnt"]));
            }
            sdr.Close();

            //입력한 데이터 PK 가져오기
            sql = "SELECT max(nNo) as nNo FROM Notice2;";
            sdr = C2.Reader(sql);
            int nNo = 0;
            while (sdr.Read())
            {
               nNo = Convert.ToInt32(sdr["nNo"]);
            }
            sdr.Close();
            Console.WriteLine("nNo = {0}", nNo);

            //데이터 업데이트 부분
            sql = string.Format("UPDATE Notice2 SET mName = '테스터2' WHERE nNo = {0};", nNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("데이터 수정 결과 : {0}", status);
            Assert.AreEqual(1, status);

            //데이터 업데이트 -> 삭제 부분
            sql = string.Format("UPDATE Notice2 SET delYn = 'Y' WHERE nNo = {0}", nNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("데이터 삭제 결과 : {0}", status);
            Assert.AreEqual(1, status);
        }
    }
}
