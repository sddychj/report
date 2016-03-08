using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Data;

namespace StatisticsSystem.DAL
{
  public class login
  {
    public login()
    {

    }
    public bool checklogin(string username, string password)
    {
      bool flag = false;
      string sql = "select * from cs_user where username=:0 and pwd=:1";
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,20),
					new OracleParameter(":1", OracleDbType.Varchar2,50)};
      parameters[0].Value = username;
      parameters[1].Value = password;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      if (dr.Read())
      { flag = true; }
      dr.Close();
      return flag;
    }
    public bool update(string username, string password)
    {
      bool flag = false;
      string sql = "update cs_user set pwd='" + password + "' where username='" + username + "'";
      //OracleParameter[] parameters = {
      //    new OracleParameter(":0", OracleDbType.Varchar2,20),
      //    new OracleParameter(":1", OracleDbType.Varchar2,50)};
      //parameters[0].Value = username;
      //parameters[1].Value = password;
      int rows = DbHelperOra.ExecuteSql(sql);
      if (rows > 0)
      { flag = true; }
      return flag;

    }
    public string GetUSERID(string loginname)
    {
      string userid = "";
      string sql = "select * from s_pm_user where username=:0";
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,20)};
      parameters[0].Value = loginname;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      if (dr.Read())
      { userid = dr["userid"].ToString(); }
      dr.Close();
      return userid;
    }
  }
}
