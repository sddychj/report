using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public class JYXXYSJ_List
  {
    public JYXXYSJ_List()
    { }
    public bool Add(StatisticsSystem.Model.JYXXYSJ_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into JYXXYSJ(");
      strSql.Append("JYXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF)");
      strSql.Append(" values (");
      strSql.Append(":JYXXID,:ONAME,:OBBBM,:OZBBM,:OZD,:ODWBM,:ONF,:OYF)");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10),
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Double,4),
					new OracleParameter(":OYF", OracleDbType.Double,4)};
      parameters[0].Value = model.JYXXID;
      parameters[1].Value = model.ONAME;
      parameters[2].Value = model.OBBBM;
      parameters[3].Value = model.OZBBM;
      parameters[4].Value = model.OZD;
      parameters[5].Value = model.ODWBM;
      parameters[6].Value = model.ONF;
      parameters[7].Value = model.OYF;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(),model.JYXXID.Length, parameters);
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
