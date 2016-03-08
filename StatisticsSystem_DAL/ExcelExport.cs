using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;

namespace StatisticsSystem.DAL
{
  public class ExcelExport
  {

    public bool Update(string sql)
    {
      int rows = DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
      return rows > 0 ? true : false;
    }

    public bool Insert(string bbbm, string dwbm, string nf, string yf)
    {
      string sql = "select count(*) from " + bbbm + " where dwbm='" + dwbm + "' and nf=" + nf + " and yf=" + yf;
      int rows = int.Parse(DBUtilityOdp.DbHelperOra.GetSingle(sql).ToString());
      if (rows == 0)
      {
        OracleParameter[] parameters = {
					new OracleParameter(":v_bbbm", OracleDbType.Varchar2,30),
					new OracleParameter(":v_dwbm", OracleDbType.Varchar2,20),
					new OracleParameter(":v_nf", OracleDbType.Varchar2,20),
					new OracleParameter(":v_yf", OracleDbType.Varchar2,20)};
        parameters[0].Value = bbbm;
        parameters[1].Value = dwbm;
        parameters[2].Value = nf;
        parameters[3].Value = yf;
        OracleDataReader dr = DBUtilityOdp.DbHelperOra.RunProcedure("p_create", parameters);
        if (dr.Read())
        { }
        dr.Close();
      }
      return true;
    }
  }
}
