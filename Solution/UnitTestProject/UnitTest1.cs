using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System;
using MySql.Data.MySqlClient;

namespace UnitTestProject
{
    // [] ������ Ŭ�� : �� Ŭ�󽺴� TEST�ϱ����� ������� Ŭ�󽺴�
    [TestClass]
    public class UnitTest1
    {
        // [] ������ �ż��� : �� �ż���� TEST�ϱ� ���� ������� �ż����. || ������ ������(DI) ���� �ż��峪 Ŭ�󽺸� ���� §��.
        [TestMethod]
        public void TestMethod1()
        {
            Class1 C1 = new Class1();
            int a = 1;
            int b = 3;
            Console.WriteLine(C1.Test(a, b));

            int c = (a + b); //4
            int d = C1.Test(a, b);
            //c �� ���� ���� ���� ������� �����Ѱǵ� �̰� �����ִ°� Unit �̴�.
            Assert.AreEqual(c, d); 
            /*  �׽�Ʈ ������ ���� �׽�Ʈ â�� ������ ������ �ȴ�.
                ���� �غ��� �׽�Ʈ Ž���Ⱑ ���� �����ɰ��̰� ������׶�̿� vǥ�� �����°� Ȯ���Ҽ� �ִµ�
                vǥ�� ���̸� �����۵��̰� �������׶��vǥ�� �������۵����̴�. */

        }

        [TestMethod]
        public void TestMethod2()
        {
            Console.WriteLine("�����ͺ��̽� �׽�Ʈ ����");

            Class2 C2 = new Class2();

            //������ SELECT
            string sql = "SELECT * FROM Notice2;";
            MySqlDataReader sdr = C2.Reader(sql);
            int cnt = 0;
            while (sdr.Read())
            {
                cnt++;
            }
            //Reader�� �ݾ���� ���� ������ ���� �ɼ� �ִ�.
            sdr.Close();
            Console.WriteLine("�� ������ �� : {0}", cnt);

            //������ �Է�ó�� �κ�
            sql = "INSERT INTO Notice2 (nTitle, nContents, mName) VALUES ('4', '5', '6');";
            int status = C2.NoneQuery(sql);
            Console.WriteLine("������ ���� ��� : {0}", status);

            /// ������ �Ǽ� Ȯ�� || ���� cnt �� ������ �Է����� cnt ��
            sql = "SELECT COUNT(*) as cnt FROM Notice2";
            sdr = C2.Reader(sql);
            while (sdr.Read())
            {
                Assert.AreEqual(cnt + 1, Convert.ToInt32(sdr["cnt"]));
            }
            sdr.Close();

            //�Է��� ������ PK ��������
            sql = "SELECT max(nNo) as nNo FROM Notice2;";
            sdr = C2.Reader(sql);
            int nNo = 0;
            while (sdr.Read())
            {
               nNo = Convert.ToInt32(sdr["nNo"]);
            }
            sdr.Close();
            Console.WriteLine("nNo = {0}", nNo);

            //������ ������Ʈ �κ�
            sql = string.Format("UPDATE Notice2 SET mName = '�׽���2' WHERE nNo = {0};", nNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("������ ���� ��� : {0}", status);
            Assert.AreEqual(1, status);

            //������ ������Ʈ -> ���� �κ�
            sql = string.Format("UPDATE Notice2 SET delYn = 'Y' WHERE nNo = {0}", nNo);
            status = C2.NoneQuery(sql);
            Console.WriteLine("������ ���� ��� : {0}", status);
            Assert.AreEqual(1, status);
        }
    }
}
