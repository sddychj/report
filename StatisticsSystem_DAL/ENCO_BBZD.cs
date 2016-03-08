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
  /// 数据访问类:ENCO_BBZD
  /// </summary>
  public partial class ENCO_BBZD
  {
    public ENCO_BBZD()
    { }

    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZD)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_BBZD");
      strSql.Append(" where BBBM=:BBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZD;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_BBZD(");
      strSql.Append("BBBM,ZD,ZDZS,SJLX,SJCD,SJJD,ZDSX,FLYC,SFZD,SFYC,SFHZ)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZD,:ZDZS,:SJLX,:SJCD,:SJJD,:ZDSX,:FLYC,:SFZD,:SFYC,:SFHZ)");
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
					new OracleParameter(":SFHZ", OracleDbType.Varchar2,20)};
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
    public bool Update(StatisticsSystem.Model.ENCO_BBZD model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_BBZD set ");
      strSql.Append("ZDZS=:ZDZS,");
      strSql.Append("SJLX=:SJLX,");
      strSql.Append("SJCD=:SJCD,");
      strSql.Append("SJJD=:SJJD,");
      strSql.Append("ZDSX=:ZDSX,");
      strSql.Append("FLYC=:FLYC,");
      strSql.Append("sfzd=:sfzd,");
      strSql.Append("sfyc=:sfyc");
      strSql.Append(" where BBBM=:BBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZDZS", OracleDbType.Varchar2,50),
					new OracleParameter(":SJLX", OracleDbType.Varchar2,20),
					new OracleParameter(":SJCD", OracleDbType.Varchar2,6),
					new OracleParameter(":SJJD", OracleDbType.Double,6),
					new OracleParameter(":ZDSX", OracleDbType.Double,6),
					new OracleParameter(":FLYC", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SFZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SFYC", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ZDZS;
      parameters[1].Value = model.SJLX;
      parameters[2].Value = model.SJCD;
      parameters[3].Value = model.SJJD;
      parameters[4].Value = model.ZDSX;
      parameters[5].Value = model.FLYC;
      parameters[6].Value = model.BBBM;
      parameters[7].Value = model.Sfzd;
      parameters[8].Value = model.Sfyc;
      parameters[9].Value = model.ZD;

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
    public bool Delete(string BBBM, string ZD)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_BBZD ");
      strSql.Append(" where BBBM=:BBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZD;

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
    public StatisticsSystem.Model.ENCO_BBZD GetModel(string BBBM, string ZD)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZD,ZDZS,SJLX,SJCD,SJJD,ZDSX,FLYC,SFZD,SFYC,SFHZ from ENCO_BBZD ");
      strSql.Append(" where BBBM=:BBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZD;

      StatisticsSystem.Model.ENCO_BBZD model = new StatisticsSystem.Model.ENCO_BBZD();
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
    public StatisticsSystem.Model.ENCO_BBZD DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_BBZD model = new StatisticsSystem.Model.ENCO_BBZD();
      if (row != null)
      {
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["ZD"] != null)
        {
          model.ZD = row["ZD"].ToString();
        }
        if (row["ZDZS"] != null)
        {
          model.ZDZS = row["ZDZS"].ToString();
        }
        if (row["SJLX"] != null)
        {
          model.SJLX = row["SJLX"].ToString();
        }
        if (row["SJCD"] != null && row["SJCD"].ToString() != "")
        {
          model.SJCD = row["SJCD"].ToString();
        }
        if (row["SJJD"] != null && row["SJJD"].ToString() != "")
        {
          model.SJJD = decimal.Parse(row["SJJD"].ToString());
        }
        if (row["ZDSX"] != null && row["ZDSX"].ToString() != "")
        {
          model.ZDSX = decimal.Parse(row["ZDSX"].ToString());
        }
        if (row["FLYC"] != null)
        {
          model.FLYC = row["FLYC"].ToString();
        }
        if (row["SFZD"] != null)
        {
          model.Sfzd = row["SFZD"].ToString();
        }
        if (row["SFYC"] != null)
        {
          model.Sfyc = row["SFYC"].ToString();
        }
        if (row["SFHZ"] != null)
        {
          model.Sfhz = row["SFHZ"].ToString();
        }
        if (row["WIDTH1"] != null && row["WIDTH1"].ToString() != "")
        {
          model.Width1 = decimal.Parse(row["WIDTH1"].ToString());
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
      strSql.Append("select BBBM,ZD,ZDZS,SJLX,SJCD,SJJD,ZDSX,FLYC,SFZD,SFYC,SFHZ,WIDTH1 ");
      strSql.Append(" FROM ENCO_BBZD ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append(" order by zdsx");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM ENCO_BBZD ");
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
      strSql.Append(" SELECT ROW_Double() OVER (");
      if (!string.IsNullOrEmpty(orderby.Trim()))
      {
        strSql.Append("order by T." + orderby);
      }
      else
      {
        strSql.Append("order by T.ZD desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_BBZD T ");
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
      parameters[0].Value = "ENCO_BBZD";
      parameters[1].Value = "ZD";
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

    public DataSet GetList_BBBM(string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZD,ZDZS,SJLX,SJCD,SJJD,ZDSX,FLYC,sfzd,sfyc,sfhz,width1 ");
      strSql.Append(" FROM ENCO_BBZD where BBBM=:0 order by zdsx");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;

      return DbHelperOra.Query(strSql.ToString(), parameters);
    }

    public void GetZBBMB_YYBB_HC(string BBBM, Dictionary<string, Model.ENCO_BBZD> bbzd, Dictionary<string, Model.ENCO_BBZD> bbzd_xh)
    {
      string sql = "select a.* from enco_bbzd a,info_yybb b where a.bbbm=b.yybbbm and b.bbbm=:BBBM";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      string key = "", key_hc = "";
      Model.ENCO_BBZD model = new Model.ENCO_BBZD();
      while (dr.Read())
      {
        key = dr["bbbm"].ToString() + "," + dr["zd"].ToString();
        model = new Model.ENCO_BBZD();
        model.BBBM = dr["bbbm"].ToString();
        model.ZD = dr["zd"].ToString();
        model.ZDSX = int.Parse(dr["zdsx"].ToString());
        bbzd.Add(key, model);
        key_hc = dr["bbbm"].ToString() + "," + dr["zdsx"].ToString();
        bbzd_xh.Add(key_hc, model);
      }
      dr.Close();
    }
    public Dictionary<int, string> GetDic(string BBBM)
    {
      Dictionary<int, string> dic = new Dictionary<int, string>();
      string sql = "select * from enco_bbzd where substr(zd,1,3)='COL' and bbbm=:BBBM order by zdsx";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;

      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql, parameters);
      int i = 0;
      while (dr.Read())
      {
        dic.Add(i++, dr["zd"].ToString());
      }
      dr.Close();
      return dic;
    }
    public Dictionary<string, int> GetDic_zdsx(string BBBM)
    {
      Dictionary<string, int> dic = new Dictionary<string, int>();
      string sql = "select * from enco_bbzd where substr(zd,1,3)='COL' and bbbm=:BBBM order by zdsx";
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;

      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql, parameters);
      int i = 0;
      while (dr.Read())
      {
        dic.Add(dr["zdsx"].ToString(), i++);
      }
      dr.Close();
      return dic;
    }
    #endregion  ExtensionMethod
  }
}
