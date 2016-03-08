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
  public partial class ENCO_BBZD_List
  {
    public ENCO_BBZD_List()
    { }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_BBZD(");
      strSql.Append("BBBM,ZD,ZDZS,SJLX,SJCD,SJJD,ZDSX,FLYC,SFZD,SFYC,SFHZ,WIDTH1)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZD,:ZDZS,:SJLX,:SJCD,:SJJD,:ZDSX,:FLYC,:SFZD,:SFYC,:SFHZ,:WIDTH1)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20),
					new OracleParameter(":ZDZS", OracleDbType.Varchar2,50),
					new OracleParameter(":SJLX", OracleDbType.Varchar2,20),
					new OracleParameter(":SJCD", OracleDbType.Varchar2,6),
					new OracleParameter(":SJJD", OracleDbType.Double,6),
					new OracleParameter(":ZDSX", OracleDbType.Double,6),
					new OracleParameter(":FLYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SFYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFHZ", OracleDbType.Varchar2,20),
					new OracleParameter(":WIDTH1", OracleDbType.Decimal)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZD;
      parameters[2].Value = model.ZDZS;
      parameters[3].Value = model.SJLX;
      parameters[4].Value = model.SJCD;
      parameters[5].Value = model.SJJD;
      parameters[6].Value = model.ZDSX;
      parameters[7].Value = model.FLYC;
      parameters[8].Value = model.Sfzd;
      parameters[9].Value = model.Sfyc;
      parameters[10].Value = model.Sfhz;
      parameters[11].Value = model.WIDTH1;

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
      strSql.Append("delete from ENCO_BBZD ");
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

    public Model.ENCO_BBZD_List Query(string bbbm)
    {
      string sql = "select * from enco_bbzd where bbbm=:bbbm";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = bbbm;
      DataSet ds = DbHelperOra.Query(sql, parameters);
      Model.ENCO_BBZD_List model = new Model.ENCO_BBZD_List(ds.Tables[0].Rows.Count);
      int i = 0;
      foreach (DataRow row in ds.Tables[0].Rows)
      {
        if (row != null)
        {
          if (row["BBBM"] != null)
          {
            model.BBBM[i] = row["BBBM"].ToString();
          }
          if (row["ZD"] != null)
          {
            model.ZD[i] = row["ZD"].ToString();
          }
          if (row["ZDZS"] != null)
          {
            model.ZDZS[i] = row["ZDZS"].ToString();
          }
          if (row["SJLX"] != null)
          {
            model.SJLX[i] = row["SJLX"].ToString();
          }
          if (row["SJCD"] != null && row["SJCD"].ToString() != "")
          {
            model.SJCD[i] = row["SJCD"].ToString();
          }
          if (row["SJJD"] != null && row["SJJD"].ToString() != "")
          {
            model.SJJD[i] = decimal.Parse(row["SJJD"].ToString());
          }
          if (row["ZDSX"] != null && row["ZDSX"].ToString() != "")
          {
            model.ZDSX[i] = decimal.Parse(row["ZDSX"].ToString());
          }
          if (row["FLYC"] != null)
          {
            model.FLYC[i] = row["FLYC"].ToString();
          }
          if (row["sfzd"] != null)
          {
            model.Sfzd[i] = row["sfzd"].ToString();
          }
          if (row["sfyc"] != null)
          {
            model.Sfyc[i] = row["sfyc"].ToString();
          }
          if (row["sfhz"] != null)
          {
            model.Sfyc[i] = row["sfhz"].ToString();
          }
        }
        i++;
      }
      return model;
    }

  }
}
