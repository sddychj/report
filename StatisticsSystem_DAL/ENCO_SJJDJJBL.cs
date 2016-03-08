using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Collections.Generic;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ENCO_SJJDJJBL
  /// </summary>
  public partial class ENCO_SJJDJJBL
  {
    public ENCO_SJJDJJBL()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string ZBBM, string ZD)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_SJJDJJBL");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;
      parameters[2].Value = ZD;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_SJJDJJBL model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_SJJDJJBL(");
      strSql.Append("BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:ZBBM,:ZD,:SJLX,:SJCD,:SJJD,:JJBL)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20),
					new OracleParameter(":SJLX", OracleDbType.Varchar2,20),
					new OracleParameter(":SJCD", OracleDbType.Double,6),
					new OracleParameter(":SJJD", OracleDbType.Double,6),
					new OracleParameter(":JJBL", OracleDbType.Double,5)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZD;
      parameters[3].Value = model.SJLX;
      parameters[4].Value = model.SJCD;
      parameters[5].Value = model.SJJD;
      parameters[6].Value = model.JJBL;

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
    public bool Update(StatisticsSystem.Model.ENCO_SJJDJJBL model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_SJJDJJBL set ");
      strSql.Append("SJLX=:SJLX,");
      strSql.Append("SJCD=:SJCD,");
      strSql.Append("SJJD=:SJJD,");
      strSql.Append("JJBL=:JJBL");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":SJLX", OracleDbType.Varchar2,20),
					new OracleParameter(":SJCD", OracleDbType.Double,6),
					new OracleParameter(":SJJD", OracleDbType.Double,6),
					new OracleParameter(":JJBL", OracleDbType.Double,5),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.SJLX;
      parameters[1].Value = model.SJCD;
      parameters[2].Value = model.SJJD;
      parameters[3].Value = model.JJBL;
      parameters[4].Value = model.BBBM;
      parameters[5].Value = model.ZBBM;
      parameters[6].Value = model.ZD;

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
    public bool Delete(string BBBM, string ZBBM, string ZD)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_SJJDJJBL ");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;
      parameters[2].Value = ZD;

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
    public StatisticsSystem.Model.ENCO_SJJDJJBL GetModel(string BBBM, string ZBBM, string ZD)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL from ENCO_SJJDJJBL ");
      strSql.Append(" where BBBM=:BBBM and ZBBM=:ZBBM and ZD=:ZD ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":ZD", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = ZBBM;
      parameters[2].Value = ZD;

      StatisticsSystem.Model.ENCO_SJJDJJBL model = new StatisticsSystem.Model.ENCO_SJJDJJBL();
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
    public StatisticsSystem.Model.ENCO_SJJDJJBL DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_SJJDJJBL model = new StatisticsSystem.Model.ENCO_SJJDJJBL();
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
        if (row["ZD"] != null)
        {
          model.ZD = row["ZD"].ToString();
        }
        if (row["SJLX"] != null)
        {
          model.SJLX = row["SJLX"].ToString();
        }
        if (row["SJCD"] != null && row["SJCD"].ToString() != "")
        {
          model.SJCD = decimal.Parse(row["SJCD"].ToString());
        }
        if (row["SJJD"] != null && row["SJJD"].ToString() != "")
        {
          model.SJJD = decimal.Parse(row["SJJD"].ToString());
        }
        if (row["JJBL"] != null && row["JJBL"].ToString() != "")
        {
          model.JJBL = decimal.Parse(row["JJBL"].ToString());
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
      strSql.Append("select BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL ");
      strSql.Append(" FROM ENCO_SJJDJJBL ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM ENCO_SJJDJJBL ");
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
      strSql.Append(")AS Row, T.*  from ENCO_SJJDJJBL T ");
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
      parameters[0].Value = "ENCO_SJJDJJBL";
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
      strSql.Append("delete from ENCO_SJJDJJBL ");
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
      strSql.Append("select BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL ");
      strSql.Append(" FROM ENCO_SJJDJJBL ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      return DbHelperOra.Query(strSql.ToString(), parameters);
    }

    public Dictionary<string, Model.ENCO_SJJDJJBL> GetHashList_BBBM(string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,ZBBM,ZD,SJLX,SJCD,SJJD,JJBL ");
      strSql.Append(" FROM ENCO_SJJDJJBL ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      Dictionary<string, Model.ENCO_SJJDJJBL> hash = new Dictionary<string, Model.ENCO_SJJDJJBL>();
      OracleDataReader dr = DbHelperOra.ExecuteReader(strSql.ToString(), parameters);
      string key = "";
      Model.ENCO_SJJDJJBL model = new Model.ENCO_SJJDJJBL();
      while (dr.Read())
      {
        key = dr["BBBM"].ToString() + "," + dr["zbbm"].ToString() + "," + dr["zd"].ToString();
        model = new Model.ENCO_SJJDJJBL();
        model.BBBM = dr["bbbm"].ToString();
        model.ZBBM = dr["zbbm"].ToString();
        model.ZD = dr["zd"].ToString();
        //model.SJLX = dr["sjlx"].ToString();
        //model.SJCD = int.Parse(dr["sjjd"].ToString());
        model.SJJD = int.Parse(dr["sjjd"].ToString());
        //model.JJBL = decimal.Parse(dr["jjbl"].ToString());
        hash.Add(key, model);
      }
      dr.Close();
      return hash;
    }
    #endregion  ExtensionMethod
  }
}

