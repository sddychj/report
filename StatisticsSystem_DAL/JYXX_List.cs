using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public class JYXX_List
  {
    public JYXX_List()
    { }
    public bool Add(StatisticsSystem.Model.JYXX_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into JYXX(");
      strSql.Append("JYXXID,BBBM,JYMC,JYMS,JYGX,JYSX,DWBM,NF,YF)");
      strSql.Append(" values (");
      strSql.Append(":JYXXID,:BBBM,:JYMC,:JYMS,:JYGX,:JYSX,:DWBM,:NF,:YF)");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":JYMC", OracleDbType.Varchar2,200),
					new OracleParameter(":JYMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JYGX", OracleDbType.Varchar2,10),
					new OracleParameter(":JYSX", OracleDbType.Double,8),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.JYXXID;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.JYMC;
      parameters[3].Value = model.JYMS;
      parameters[4].Value = model.JYGX;
      parameters[5].Value = model.JYSX;
      parameters[6].Value = model.DWBM;
      parameters[7].Value = model.NF;
      parameters[8].Value = model.YF;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(),model.BBBM.Length, parameters);
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
