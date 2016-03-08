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
  public partial class ENCO_ZBBMB_List
  {
    public ENCO_ZBBMB_List()
    { }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_ZBBMB(");
      strSql.Append("BBBM,ZBBM,ZBMC,ZBDM,JLDW1,CJ,HC,QYJY,XSYC,SFKBJ,SFMJ,bzsz1,bzsz2,sjzbbm,sjhzbm)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZBBM,:ZBMC,:ZBDM,:JLDW1,:CJ,:HC,:QYJY,:XSYC,:SFKBJ,:SFMJ,:bzsz1,:bzsz2,:sjzbbm,:sjhzbm)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZBMC", OracleDbType.Varchar2,200),
					new OracleParameter(":ZBDM", OracleDbType.Varchar2,50),
					new OracleParameter(":JLDW1", OracleDbType.Varchar2,30),
					new OracleParameter(":CJ", OracleDbType.Double,6),
					new OracleParameter(":HC", OracleDbType.Double,6),
					new OracleParameter(":QYJY", OracleDbType.Varchar2,20),
					new OracleParameter(":XSYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKBJ", OracleDbType.Varchar2,50),
					new OracleParameter(":SFMJ", OracleDbType.Varchar2,50),
					new OracleParameter(":bzsz1", OracleDbType.Varchar2,50),
					new OracleParameter(":bzsz2", OracleDbType.Varchar2,50),
					new OracleParameter(":sjzbbm", OracleDbType.Varchar2,50),
					new OracleParameter(":sjhzbm", OracleDbType.Varchar2,50)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZBMC;
      parameters[3].Value = model.ZBDM;
      parameters[4].Value = model.JLDW1;
      parameters[5].Value = model.CJ;
      parameters[6].Value = model.HC;
      parameters[7].Value = model.QYJY;
      parameters[8].Value = model.XSYC;
      parameters[9].Value = model.SFKBJ;
      parameters[10].Value = model.SFMJ;
      parameters[11].Value = model.BZSZ1;
      parameters[12].Value = model.BZSZ2;
      parameters[13].Value = model.Sjzbbm;
      parameters[14].Value = model.Sjhzbm;

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
    public bool update(StatisticsSystem.Model.ENCO_ZBBMB_List model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_ZBBMB set ");
      strSql.Append("ZBMC=:ZBMC,");
      strSql.Append("ZBDM=:ZBDM,");
      strSql.Append("JLDW1=:JLDW1,");
      strSql.Append("CJ=:CJ,");
      strSql.Append("HC=:HC,");
      strSql.Append("QYJY=:QYJY,");
      strSql.Append("XSYC=:XSYC,");
      strSql.Append("SFKBJ=:SFKBJ,");
      strSql.Append("SFMJ=:SFMJ,");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZBMC", OracleDbType.Varchar2,200),
					new OracleParameter(":ZBDM", OracleDbType.Varchar2,50),
					new OracleParameter(":JLDW1", OracleDbType.Varchar2,30),
					new OracleParameter(":CJ", OracleDbType.Double,6),
					new OracleParameter(":HC", OracleDbType.Double,6),
					new OracleParameter(":QYJY", OracleDbType.Varchar2,20),
					new OracleParameter(":XSYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKBJ", OracleDbType.Varchar2,50),
					new OracleParameter(":SFMJ", OracleDbType.Varchar2,50)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZBMC;
      parameters[3].Value = model.ZBDM;
      parameters[4].Value = model.JLDW1;
      parameters[5].Value = model.CJ;
      parameters[6].Value = model.HC;
      parameters[7].Value = model.QYJY;
      parameters[8].Value = model.XSYC;
      parameters[9].Value = model.SFKBJ;
      parameters[10].Value = model.SFMJ;

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
      strSql.Append("delete from ENCO_ZBBMB ");
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
    public Model.ENCO_ZBBMB_List query(string bbbm)
    {
      string sql = "select * from enco_zbbmb where bbbm=:bbbm";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = bbbm;
      DataSet ds = DbHelperOra.Query(sql, parameters);
      Model.ENCO_ZBBMB_List model = new Model.ENCO_ZBBMB_List(ds.Tables[0].Rows.Count);
      
      int i = 0;
      foreach (DataRow row in ds.Tables[0].Rows)
      {
        if (row != null)
        {
          if (row["BBBM"] != null)
          {
            model.BBBM[i] = row["BBBM"].ToString();
          }
          if (row["ZBBM"] != null)
          {
            model.ZBBM[i] = row["ZBBM"].ToString();
          }
          if (row["ZBMC"] != null)
          {
            model.ZBMC[i] = row["ZBMC"].ToString();
          }
          if (row["ZBDM"] != null)
          {
            model.ZBDM[i] = row["ZBDM"].ToString();
          }
          if (row["JLDW1"] != null)
          {
            model.JLDW1[i] = row["JLDW1"].ToString();
          }
          if (row["JLDW2"] != null)
          {
            model.JLDW2[i] = row["JLDW2"].ToString();
          }
          if (row["JLDW3"] != null)
          {
            model.JLDW3[i] = row["JLDW3"].ToString();
          }
          if (row["CJ"] != null && row["CJ"].ToString() != "")
          {
            model.CJ[i] = decimal.Parse(row["CJ"].ToString());
          }
          if (row["HC"] != null && row["HC"].ToString() != "")
          {
            model.HC[i] = decimal.Parse(row["HC"].ToString());
          }
          if (row["QYJY"] != null)
          {
            model.QYJY[i] = row["QYJY"].ToString();
          }
          if (row["XSYC"] != null)
          {
            model.XSYC[i] = row["XSYC"].ToString();
          }
          if (row["SFKBJ"] != null)
          {
            model.SFKBJ[i] = row["SFKBJ"].ToString();
          }
          if (row["SFMJ"] != null)
          {
            model.SFMJ[i] = row["SFMJ"].ToString();
          }
          if (row["BZSZ1"] != null && row["BZSZ1"].ToString() != "")
          {
            model.BZSZ1[i] = row["BZSZ1"].ToString();
          }
          if (row["BZSZ2"] != null && row["BZSZ2"].ToString() != "")
          {
            model.BZSZ2[i] = row["BZSZ2"].ToString();
          }
        }
        i++;
      }
      return model;
    }
  }
}
