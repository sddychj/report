using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public class DWBMB
  {
    public Dictionary<string, string> GetDic()
    {
      Dictionary<string, string> dic = new Dictionary<string, string>();
      string sql = "select * from dwbmb";
      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql);
      while (dr.Read())
      {
        dic.Add(dr["dydwbm"].ToString(), dr["dwbm"].ToString());
      }
      dr.Close();
      return dic;
    }

    public DataSet GetList(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select * from dwbmb");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append(" order by xssx");
      return DbHelperOra.Query(strSql.ToString());
    }

    public DataSet GetList_xssx()
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append(@"SELECT decode(a.parentid,'1',a.dwmc,'0',a.dwmc,'  '||a.dwmc) dwmc,a.dwbm FROM dwbmb A 
start with a.parentid='0' connect by prior a.dwbm = a.parentid order siblings by a.xssx ");
      return DbHelperOra.Query(strSql.ToString());
    }

    public Dictionary<string, string> GetDicDWMC()
    {
      Dictionary<string, string> dic = new Dictionary<string, string>();
      string sql = "select * from dwbmb";
      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql);
      while (dr.Read())
      {
        dic.Add(dr["dwbm"].ToString(), dr["dwmc"].ToString());
      }
      dr.Close();
      return dic;
    }

    public string GetDW(string userid)
    {
      string dw = "";
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select * from s_pm_user ");
      strSql.Append(" where loginname=:0");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30)		};
      parameters[0].Value = userid;
      DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
      if (ds != null)
        dw = ds.Tables[0].Rows[0]["userdept"].ToString();
      return dw;
    }
  }
}
