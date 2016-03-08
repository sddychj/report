using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Diagnostics;
using System.Data;

namespace DBUtilityOdp
{
  public class odac_test
  {
    public static string insert1()
    {
      //设置一个数据库的连接串， 
      string connectStr = @"Data Source=(DESCRIPTION=
         (ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.66.237.3)(PORT=1521)))
         (CONNECT_DATA=(SERVICE_NAME=ORA10G)));
         User Id=hbtj;Password=hbtj;";
      OracleConnection conn = new OracleConnection(connectStr);
      OracleCommand command = new OracleCommand();
      command.Connection = conn;
      conn.Open();
      Stopwatch sw = new Stopwatch();
      sw.Start();
      //通过循环写入大量的数据，这种方法显然是肉垫 
      for (int i = 0; i < 1000; i++)
      {
        string sql = "insert into a_test values(" + i.ToString() + ",'aaaaaaaaaaaaa','aaaaaaaaaaaaaa','aaaaaaaaaaaaaa','aaaaaaaaaa')";
        command.CommandText = sql;
        command.ExecuteNonQuery();
      }
      sw.Stop();

      return sw.ElapsedMilliseconds.ToString();
    }
    public static string insert3()
    {
      //设置一个数据库的连接串， 
      string connectStr = @"Data Source=(DESCRIPTION=
         (ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.66.237.3)(PORT=1521)))
         (CONNECT_DATA=(SERVICE_NAME=ORA10G)));
         User Id=hbtj;Password=hbtj;";
      OracleConnection conn = new OracleConnection(connectStr);
      conn.Open();
      OracleCommand command = new OracleCommand();
      command.Connection = conn;
      OracleTransaction tx = conn.BeginTransaction();
      command.Transaction = tx;
      Stopwatch sw = new Stopwatch();
      sw.Start();
      //通过循环写入大量的数据，这种方法显然是肉垫 
      for (int i = 0; i < 1000; i++)
      {
        command.CommandText = "insert into a_test values(" + i.ToString() + ",'aaaaaaaaaaaaa','aaaaaaaaaaaaaa','aaaaaaaaaaaaaa','aaaaaaaaaa')";
        command.ExecuteNonQuery();
      }
      tx.Commit();
      conn.Close();
      sw.Stop();

      return sw.ElapsedMilliseconds.ToString();
    }
    public static string insert2()
    {
      //设置一个数据库的连接串 
      string connectStr = @"Data Source=(DESCRIPTION=
         (ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=10.66.237.3)(PORT=1521)))
         (CONNECT_DATA=(SERVICE_NAME=ORA10G)));
         User Id=hbtj;Password=hbtj;";
      //到此为止，还都是我们熟悉的代码，下面就要开始喽 
      //这个参数需要指定每次批插入的记录数 
      int recc = 50000;
      int[] la = new int[recc];
      string[] lb = new string[recc];
      string[] lc = new string[recc];
      string[] ld = new string[recc];
      string[] le = new string[recc];
      Stopwatch sw = new Stopwatch();
      sw.Start();
      for (int j = 0; j < 20; j++)
      {
        OracleConnection conn = new OracleConnection(connectStr);
        OracleCommand command = new OracleCommand();
        command.Connection = conn;
        command.ArrayBindCount = recc;
        //在这个命令行中,用到了参数,参数我们很熟悉,但是这个参数在传值的时候 
        //用到的是数组,而不是单个的值,这就是它独特的地方 
        command.CommandText = "insert into a_tttt values(:deptno, :deptname, :loc,:d,:e)";
        conn.Open();
        //下面定义几个数组,分别表示三个字段,数组的长度由参数直接给出 
        //List<int> la = new List<int>();
        //List<string> lb = new List<string>();
        //List<string> lc = new List<string>();
        //List<string> ld = new List<string>();
        //List<string> le = new List<string>();
        // 为了传递参数,不可避免的要使用参数,下面会连续定义三个 
        // 从名称可以直接看出每个参数的含义,不在每个解释了 
        OracleParameter deptNoParam = new OracleParameter("deptno", OracleDbType.Int32);
        deptNoParam.Direction = ParameterDirection.Input;
        deptNoParam.Value = la;
        command.Parameters.Add(deptNoParam);
        OracleParameter deptNameParam = new OracleParameter("deptname", OracleDbType.Varchar2, 60);
        deptNameParam.Direction = ParameterDirection.Input;
        deptNameParam.Value = lb;
        command.Parameters.Add(deptNameParam);
        OracleParameter deptLocParam = new OracleParameter("loc", OracleDbType.Varchar2, 60);
        deptLocParam.Direction = ParameterDirection.Input;
        deptLocParam.Value = lc;
        command.Parameters.Add(deptLocParam);
        OracleParameter dParam = new OracleParameter("d", OracleDbType.Varchar2, 60);
        deptLocParam.Direction = ParameterDirection.Input;
        deptLocParam.Value = ld;
        command.Parameters.Add(dParam);
        OracleParameter eParam = new OracleParameter("e", OracleDbType.Varchar2, 60);
        deptLocParam.Direction = ParameterDirection.Input;
        deptLocParam.Value = le;
        command.Parameters.Add(eParam);
        //在下面的循环中,先把数组定义好,而不是像上面那样直接生成SQL 
        for (int i = 0; i < recc; i++)
        {
          //la.Add(i);
          //lb.Add("bbbbbbbbbb");
          //lc.Add("cccccccccccc");
          //ld.Add("ddddddddddd");
          //le.Add("eeeeeeeeeeeeee");
          la[i] = i + j * recc;
          lb[i] = "bbbbbbbbbbjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj";
          lc[i] = "ccccccccccccjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj";
          ld[i] = "dddddddddddjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj   ";
          le[i] = "eeeeeeeeeeeeeejjjjjjjjjjjjjjjjjjjjjjjjjjjj   ";
        }
        //这个调用将把参数数组传进SQL,同时写入数据库 
        //command.ExecuteNonQuery();
        conn.Close();
      }
      sw.Stop();

      return sw.ElapsedMilliseconds.ToString();
    }
    public static string select()
    {
      Stopwatch sw = new Stopwatch();
      sw.Start();
      //通过循环写入大量的数据，这种方法显然是肉垫 
      for (int i = 0; i < 1000; i++)
      {
        string sql = "select * from jsxx";
        DbHelperOra.ExecuteSql(sql);
      }
      sw.Stop();

      return sw.ElapsedMilliseconds.ToString();

    }
    public static string insert4()
    {
      Stopwatch sw = new Stopwatch();
      sw.Start();
      int recc = 50000;
      int[] la = new int[recc];
      string[] lb = new string[recc];
      string[] lc = new string[recc];
      string[] ld = new string[recc];
      string[] le = new string[recc];
      for (int j = 0; j < 1; j++)
      {
        Dictionary<string, object> datas = new Dictionary<string, object>();
        for (int i = 0; i < recc; i++)
        {
          //la.Add(i);
          //lb.Add("bbbbbbbbbb");
          //lc.Add("cccccccccccc");
          //ld.Add("ddddddddddd");
          //le.Add("eeeeeeeeeeeeee");
          la[i] = i + j * recc;
          lb[i] = "bbbbbbbbbbjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj";
          lc[i] = "ccccccccccccjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj";
          ld[i] = "dddddddddddjjjjjjjjjjjjjjjjjjjjjjjjjjjjjjj   ";
          le[i] = "eeeeeeeeeeeeeejjjjjjjjjjjjjjjjjjjjjjjjjjjj   ";
        }
        datas.Add("a", la);
        datas.Add("b", lb);
        datas.Add("c", lc);
        datas.Add("d", ld);
        datas.Add("e", le);
        DbHelperOra.BatchInsert("a_tttt", datas, recc);
      }
      sw.Stop();
      return sw.ElapsedMilliseconds.ToString();
    }

    public static void UpdateTest()
    {
      string sql = "update cl0002 set col6=4 where dwbm='HG' and zbbm='CL00020007' and nf=2014 and yf=12";
      DbHelperOra.ExecuteSql(sql);
    }
  }
}
