using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public class ZN_YYBB_List
  {
    public ZN_YYBB_List()
    { }
    public bool Add(StatisticsSystem.Model.ZN_YYBB_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ZN_YYBB(");
      strSql.Append("BBBM,YYBBBM)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:YYBBBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.YYBBBM;

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
  }
}
