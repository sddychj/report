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
  /// <summary>
  /// 数据访问类:ENCO_ZBBMB
  /// </summary>
  public partial class ENCO_ZBBMB
  {
    public ENCO_ZBBMB()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_ZBBMB");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_ZBBMB(");
      strSql.Append("BBBM,ZBBM,ZBMC,ZBDM,JLDW1,JLDW2,JLDW3,CJ,HC,QYJY,XSYC,SFKBJ,SFMJ,BZSZ1,BZSZ2)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZBBM,:ZBMC,:ZBDM,:JLDW1,:JLDW2,:JLDW3,:CJ,:HC,:QYJY,:XSYC,:SFKBJ,:BZZF2,:BZSZ1,:BZSZ2)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZBMC", OracleDbType.Varchar2,200),
					new OracleParameter(":ZBDM", OracleDbType.Varchar2,50),
					new OracleParameter(":JLDW1", OracleDbType.Varchar2,30),
					new OracleParameter(":JLDW2", OracleDbType.Varchar2,30),
					new OracleParameter(":JLDW3", OracleDbType.Varchar2,30),
					new OracleParameter(":CJ", OracleDbType.Double,6),
					new OracleParameter(":HC", OracleDbType.Double,6),
					new OracleParameter(":QYJY", OracleDbType.Varchar2,20),
					new OracleParameter(":XSYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKBJ", OracleDbType.Varchar2,50),
					new OracleParameter(":BZZF2", OracleDbType.Varchar2,50),
					new OracleParameter(":BZSZ1", OracleDbType.Varchar2,50),
					new OracleParameter(":BZSZ2", OracleDbType.Varchar2,50)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZBMC;
      parameters[3].Value = model.ZBDM;
      parameters[4].Value = model.JLDW1;
      parameters[5].Value = model.JLDW2;
      parameters[6].Value = model.JLDW3;
      parameters[7].Value = model.CJ;
      parameters[8].Value = model.HC;
      parameters[9].Value = model.QYJY;
      parameters[10].Value = model.XSYC;
      parameters[11].Value = model.SFKBJ;
      parameters[12].Value = model.SFMJ;
      parameters[13].Value = model.BZSZ1;
      parameters[14].Value = model.BZSZ2;

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
    /// <summary>
    /// 更新一条数据
    /// </summary>
    public bool Update(StatisticsSystem.Model.ENCO_ZBBMB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_ZBBMB set ");
      strSql.Append("ZBMC=:ZBMC,");
      strSql.Append("ZBDM=:ZBDM,");
      strSql.Append("JLDW1=:JLDW1,");
      strSql.Append("JLDW2=:JLDW2,");
      strSql.Append("JLDW3=:JLDW3,");
      strSql.Append("CJ=:CJ,");
      strSql.Append("HC=:HC,");
      strSql.Append("QYJY=:QYJY,");
      strSql.Append("XSYC=:XSYC,");
      strSql.Append("SFKBJ=:SFKBJ,");
      strSql.Append("SFMJ=:SFMJ,");
      strSql.Append("BZSZ1=:BZSZ1,");
      strSql.Append("BZSZ2=:BZSZ2");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBMC", OracleDbType.Varchar2,200),
					new OracleParameter(":ZBDM", OracleDbType.Varchar2,50),
					new OracleParameter(":JLDW1", OracleDbType.Varchar2,30),
					new OracleParameter(":JLDW2", OracleDbType.Varchar2,30),
					new OracleParameter(":JLDW3", OracleDbType.Varchar2,30),
					new OracleParameter(":CJ", OracleDbType.Double,6),
					new OracleParameter(":HC", OracleDbType.Double,6),
					new OracleParameter(":QYJY", OracleDbType.Varchar2,20),
					new OracleParameter(":XSYC", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKBJ", OracleDbType.Varchar2,50),
					new OracleParameter(":BZZF2", OracleDbType.Varchar2,50),
					new OracleParameter(":BZSZ1", OracleDbType.Varchar2,50),
					new OracleParameter(":BZSZ2", OracleDbType.Varchar2,50),
					new OracleParameter(":BBBM", OracleDbType.Varchar2),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2)};
      parameters[0].Value = model.ZBMC;
      parameters[1].Value = model.ZBDM;
      parameters[2].Value = model.JLDW1;
      parameters[3].Value = model.JLDW2;
      parameters[4].Value = model.JLDW3;
      parameters[5].Value = model.CJ;
      parameters[6].Value = model.HC;
      parameters[7].Value = model.QYJY;
      parameters[8].Value = model.XSYC;
      parameters[9].Value = model.SFKBJ;
      parameters[10].Value = model.SFMJ;
      parameters[11].Value = model.BZSZ1;
      parameters[12].Value = model.BZSZ2;
      parameters[13].Value = model.BBBM;
      parameters[14].Value = model.ZBBM;

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

    /// <summary>
    /// 删除一条数据
    /// </summary>
    public bool Delete(string BBBM, string ZBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_ZBBMB ");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;

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


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_ZBBMB GetModel(string BBBM, string ZBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZBBM,ZBMC,ZBDM,JLDW1,JLDW2,JLDW3,CJ,HC,QYJY,XSYC,SFKBJ,SFMJ,BZSZ1,BZSZ2,sjzbbm,SJHZBM from ENCO_ZBBMB ");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;

      StatisticsSystem.Model.ENCO_ZBBMB model = new StatisticsSystem.Model.ENCO_ZBBMB();
      DataSet ds = DbHelperOra.Query(strSql.ToString(), parameters);
      if (ds.Tables[0].Rows.Count > 0)
      {
        return DataRowToModel(ds.Tables[0].Rows[0]);
      }
      else
      {
        return null;
      }
    }


    /// <summary>
    /// 得到一个对象实体
    /// </summary>
    public StatisticsSystem.Model.ENCO_ZBBMB DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_ZBBMB model = new StatisticsSystem.Model.ENCO_ZBBMB();
      if (row != null)
      {
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["ZBBM"] != null)
        {
          model.ZBBM = row["ZBBM"].ToString();
        }
        if (row["ZBMC"] != null)
        {
          model.ZBMC = row["ZBMC"].ToString();
        }
        if (row["ZBDM"] != null)
        {
          model.ZBDM = row["ZBDM"].ToString();
        }
        if (row["JLDW1"] != null)
        {
          model.JLDW1 = row["JLDW1"].ToString();
        }
        if (row["JLDW2"] != null)
        {
          model.JLDW2 = row["JLDW2"].ToString();
        }
        if (row["JLDW3"] != null)
        {
          model.JLDW3 = row["JLDW3"].ToString();
        }
        if (row["CJ"] != null && row["CJ"].ToString() != "")
        {
          model.CJ = decimal.Parse(row["CJ"].ToString());
        }
        if (row["HC"] != null && row["HC"].ToString() != "")
        {
          model.HC = decimal.Parse(row["HC"].ToString());
        }
        if (row["QYJY"] != null)
        {
          model.QYJY = row["QYJY"].ToString();
        }
        if (row["XSYC"] != null)
        {
          model.XSYC = row["XSYC"].ToString();
        }
        if (row["SFKBJ"] != null)
        {
          model.SFKBJ = row["SFKBJ"].ToString();
        }
        if (row["SFMJ"] != null)
        {
          model.SFMJ = row["SFMJ"].ToString();
        }
        if (row["BZSZ1"] != null && row["BZSZ1"].ToString() != "")
        {
          model.BZSZ1 = row["BZSZ1"].ToString();
        }
        if (row["BZSZ2"] != null && row["BZSZ2"].ToString() != "")
        {
          model.BZSZ2 = row["BZSZ2"].ToString();
        }
        if (row["SJZBBM"] != null)
        {
          model.Sjzbbm = row["SJZBBM"].ToString();
        }
        if (row["SJHZBM"] != null)
        {
          model.Sjhzbm = row["SJHZBM"].ToString();
        }
      }
      return model;
    }

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZBBM,ZBMC,ZBDM,JLDW1,JLDW2,JLDW3,CJ,HC,QYJY,XSYC,SFKBJ,SFMJ,BZSZ1,BZSZ2,sjzbbm,sjhzbm ");
      strSql.Append(" FROM ENCO_ZBBMB ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append(" order by hc");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM ENCO_ZBBMB ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      object obj = DbHelperOra.GetSingle(strSql.ToString());
      if (obj == null)
      {
        return 0;
      }
      else
      {
        return Convert.ToInt32(obj);
      }
    }
    /// <summary>
    /// 分页获取数据列表
    /// </summary>
    public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("SELECT * FROM ( ");
      strSql.Append(" SELECT ROW_NUMBER() OVER (");
      if (!string.IsNullOrEmpty(orderby.Trim()))
      {
        strSql.Append("order by T." + orderby);
      }
      else
      {
        strSql.Append("order by T.ZBBM desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_ZBBMB T ");
      if (!string.IsNullOrEmpty(strWhere.Trim()))
      {
        strSql.Append(" WHERE " + strWhere);
      }
      strSql.Append(" ) TT");
      strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
      return DbHelperOra.Query(strSql.ToString());
    }

    /*
    /// <summary>
    /// 分页获取数据列表
    /// </summary>
    public DataSet GetList(int PageSize,int PageIndex,string strWhere)
    {
      OracleParameter[] parameters = {
          new OracleParameter(":tblName", OracleDbType.Varchar2, 255),
          new OracleParameter(":fldName", OracleDbType.Varchar2, 255),
          new OracleParameter(":PageSize", OracleDbType.Double),
          new OracleParameter(":PageIndex", OracleDbType.Double),
          new OracleParameter(":IsReCount", OracleDbType.Clob),
          new OracleParameter(":OrderType", OracleDbType.Clob),
          new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
          };
      parameters[0].Value = "ENCO_ZBBMB";
      parameters[1].Value = "ZBBM";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod
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

    public Dictionary<string, Model.ENCO_ZBBMB> GetZBBMB_YYBB(string BBBM)
    {
      Dictionary<string, Model.ENCO_ZBBMB> hash = new Dictionary<string, Model.ENCO_ZBBMB>();
      string sql = "select a.* from enco_zbbmb a,info_yybb b where a.bbbm=b.yybbbm and b.bbbm=:BBBM";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      string key = "";
      Model.ENCO_ZBBMB model = new Model.ENCO_ZBBMB();
      while (dr.Read())
      {
        key = dr["bbbm"].ToString() + "," + dr["zbbm"].ToString();
        model = new Model.ENCO_ZBBMB();
        model.BBBM = dr["bbbm"].ToString();
        model.ZBBM = dr["zbbm"].ToString();
        model.HC = int.Parse(dr["hc"].ToString());
      }
      dr.Close();
      return hash;
    }

    public Dictionary<int, string> GetZBBMB_hc(string BBBM)
    {
      Dictionary<int, string> hash = new Dictionary<int, string>();
      string sql = "select a.* from enco_zbbmb a where bbbm=:BBBM order by hc";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      while (dr.Read())
      {
        hash.Add(int.Parse(dr["hc"].ToString()), dr["zbbm"].ToString());
      }
      dr.Close();
      return hash;
    }

    public Dictionary<string, string> GetZBBMB_jy(string BBBM)
    {
      Dictionary<string, string> hash = new Dictionary<string, string>();
      string sql = "select a.* from enco_zbbmb a where bbbm=:BBBM and qyjy='禁用' order by hc";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      while (dr.Read())
      {
        hash.Add(dr["zbbm"].ToString(), dr["zbbm"].ToString());
      }
      dr.Close();
      return hash;
    }

    public void GetZBBMB_YYBB_HC(string BBBM, Dictionary<string, Model.ENCO_ZBBMB> zbbmb, Dictionary<string, Model.ENCO_ZBBMB> zbbmb_hc)
    {
      string sql = "select a.* from enco_zbbmb a,info_yybb b where a.bbbm=b.yybbbm and b.bbbm=:BBBM";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      string key = "", key_hc = "";
      Model.ENCO_ZBBMB model = new Model.ENCO_ZBBMB();
      while (dr.Read())
      {
        key = dr["bbbm"].ToString() + "," + dr["zbbm"].ToString();
        model = new Model.ENCO_ZBBMB();
        model.BBBM = dr["bbbm"].ToString();
        model.ZBBM = dr["zbbm"].ToString();
        model.HC = int.Parse(dr["hc"].ToString());
        zbbmb.Add(key, model);
        key_hc = dr["bbbm"].ToString() + "," + dr["hc"].ToString();
        zbbmb_hc.Add(key_hc, model);
      }
      dr.Close();
    }
    #endregion  ExtensionMethod
  }
}
