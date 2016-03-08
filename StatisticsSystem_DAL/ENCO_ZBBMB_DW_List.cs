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
  public partial class ENCO_ZBBMB_DW_List
  {
    public ENCO_ZBBMB_DW_List()
    { }

    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB_DW_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_ZBBMB_DW(");
      strSql.Append("ZBBM,DWBM)");
      strSql.Append(" values (");
      strSql.Append(":ZBBM,:DWBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ZBBM;
      parameters[1].Value = model.DWBM;

      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), model.ZBBM.Length, parameters);
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
