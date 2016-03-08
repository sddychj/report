using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public partial class ENCO_SJJDJJBL_List
  {
    public ENCO_SJJDJJBL_List()
    { }
    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_SJJDJJBL_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_SJJDJJBL(");
      strSql.Append("BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZBBM,:ZD,:SJLX,:SJCD,:SJJD,:JJBL)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SJLX", OracleDbType.Varchar2,20),
					new OracleParameter(":SJCD", OracleDbType.Double,6),
					new OracleParameter(":SJJD", OracleDbType.Double,6),
					new OracleParameter(":JJBL", OracleDbType.Double,5)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZD;
      parameters[3].Value = model.SJLX;
      parameters[4].Value = model.SJCD;
      parameters[5].Value = model.SJJD;
      parameters[6].Value = model.JJBL;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), model.BBBM.Length, parameters);
      if (rows > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool update(StatisticsSystem.Model.ENCO_SJJDJJBL_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_SJJDJJBL ");
      strSql.Append("set sjjd=:sjjd ");
      strSql.Append("where bbbm=:BBBM and zbbm=ZBBM and zd=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SJJD", OracleDbType.Double,6)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZD;
      parameters[3].Value = model.SJJD;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), model.BBBM.Length, parameters);
      if (rows > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public bool Delete(string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_SJJDJJBL ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
      if (rows > 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
