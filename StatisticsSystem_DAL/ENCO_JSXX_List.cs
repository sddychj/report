using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  public class ENCO_JSXX_List
  {
    public ENCO_JSXX_List() { }
    public bool Add(StatisticsSystem.Model.ENCO_JSXX_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_JSXX(");
      strSql.Append("JSXXID,BBBM,ZBBM,ZD,JSMS,JSSX,DWBM,NF,YF,SFKDW,SFKB,SFTZ)");
      strSql.Append(" values (");
      strSql.Append(":JSXXID,:BBBM,:ZBBM,:ZD,:JSMS,:JSSX,:DWBM,:NF,:YF,:SFKDW,:SFKB,:SFTZ)");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":ZD", OracleDbType.Varchar2,30),
					new OracleParameter(":JSMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JSSX", OracleDbType.Double,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKDW", OracleDbType.Varchar2,50),
					new OracleParameter(":SFKB", OracleDbType.Varchar2,50),
					new OracleParameter(":SFTZ", OracleDbType.Varchar2,50)};
      parameters[0].Value = model.JSXXID;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.ZBBM;
      parameters[3].Value = model.ZD;
      parameters[4].Value = model.JSMS;
      parameters[5].Value = model.JSSX;
      parameters[6].Value = model.DWBM;
      parameters[7].Value = model.NF;
      parameters[8].Value = model.YF;
      parameters[9].Value = model.SFKDW;
      parameters[10].Value = model.SFKB;
      parameters[11].Value = model.SFTZ;

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

    public bool Delete(StatisticsSystem.Model.ENCO_JSXX_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from enco_jsxx where jsxxid=:jsxxid");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10)};
      parameters[0].Value = model.JSXXID;
      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), model.JSXXID.Length, parameters);

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
