using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ZN_DOCJSXX
  /// </summary>
  public partial class ZN_DOCJSXX
  {
    public ZN_DOCJSXX()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal DOCJSXXID)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ZN_DOCJSXX");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = DOCJSXXID;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_DOCJSXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ZN_DOCJSXX(");
      strSql.Append("DOCJSXXID,DOCBM,SQMC,JSMS,JSSX,DWBM,NF,YF)");
      strSql.Append(" values (");
      strSql.Append(":DOCJSXXID,:DOCBM,:SQMC,:JSMS,:JSSX,:DWBM,:NF,:YF)");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":SQMC", OracleDbType.Varchar2,90),
					new OracleParameter(":JSMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JSSX", OracleDbType.Double,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.DOCJSXXID;
      parameters[1].Value = model.DOCBM;
      parameters[2].Value = model.SQMC;
      parameters[3].Value = model.JSMS;
      parameters[4].Value = model.JSSX;
      parameters[5].Value = model.DWBM;
      parameters[6].Value = model.NF;
      parameters[7].Value = model.YF;

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
    public bool Update(StatisticsSystem.Model.ZN_DOCJSXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ZN_DOCJSXX set ");
      strSql.Append("DOCBM=:DOCBM,");
      strSql.Append("SQMC=:SQMC,");
      strSql.Append("JSMS=:JSMS,");
      strSql.Append("JSSX=:JSSX,");
      strSql.Append("DWBM=:DWBM,");
      strSql.Append("NF=:NF,");
      strSql.Append("YF=:YF");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":SQMC", OracleDbType.Varchar2,90),
					new OracleParameter(":JSMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JSSX", OracleDbType.Double,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20),
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10)};
      parameters[0].Value = model.DOCBM;
      parameters[1].Value = model.SQMC;
      parameters[2].Value = model.JSMS;
      parameters[3].Value = model.JSSX;
      parameters[4].Value = model.DWBM;
      parameters[5].Value = model.NF;
      parameters[6].Value = model.YF;
      parameters[7].Value = model.DOCJSXXID;

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
    public bool Delete(decimal DOCJSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCJSXX ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = DOCJSXXID;

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
    /// 批量删除数据
    /// </summary>
    public bool DeleteList(string DOCJSXXIDlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCJSXX ");
      strSql.Append(" where DOCJSXXID in (" + DOCJSXXIDlist + ")  ");
      int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
    public StatisticsSystem.Model.ZN_DOCJSXX GetModel(decimal DOCJSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select DOCJSXXID,DOCBM,SQMC,JSMS,JSSX,DWBM,NF,YF from ZN_DOCJSXX ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = DOCJSXXID;

      StatisticsSystem.Model.ZN_DOCJSXX model = new StatisticsSystem.Model.ZN_DOCJSXX();
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
    public StatisticsSystem.Model.ZN_DOCJSXX DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ZN_DOCJSXX model = new StatisticsSystem.Model.ZN_DOCJSXX();
      if (row != null)
      {
        if (row["DOCJSXXID"] != null && row["DOCJSXXID"].ToString() != "")
        {
          model.DOCJSXXID = decimal.Parse(row["DOCJSXXID"].ToString());
        }
        if (row["DOCBM"] != null)
        {
          model.DOCBM = row["DOCBM"].ToString();
        }
        if (row["SQMC"] != null)
        {
          model.SQMC = row["SQMC"].ToString();
        }
        if (row["JSMS"] != null)
        {
          model.JSMS = row["JSMS"].ToString();
        }
        if (row["JSSX"] != null && row["JSSX"].ToString() != "")
        {
          model.JSSX = decimal.Parse(row["JSSX"].ToString());
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
        }
        if (row["NF"] != null)
        {
          model.NF = row["NF"].ToString();
        }
        if (row["YF"] != null)
        {
          model.YF = row["YF"].ToString();
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
      strSql.Append("select DOCJSXXID,DOCBM,SQMC,JSMS,JSSX,DWBM,NF,YF ");
      strSql.Append(" FROM ZN_DOCJSXX ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append("  order by DOCJSXXID ");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM ZN_DOCJSXX ");
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
        strSql.Append("order by T.DOCJSXXID desc");
      }
      strSql.Append(")AS Row, T.*  from ZN_DOCJSXX T ");
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
      parameters[0].Value = "ZN_DOCJSXX";
      parameters[1].Value = "DOCJSXXID";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataSet GetList_DOCBM(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select DOCJSXXID,a.DOCBM,SQMC,JSMS,JSSX,DWBM,NF,YF,b.docmc ");
      strSql.Append(" FROM ZN_DOCJSXX a ,zn_docbm b where a.docbm=b.docbm ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" and " + strWhere);
      }
      return DbHelperOra.Query(strSql.ToString());
    }

    public int GetMaxID()
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select decode(max(docjsxxid),null,1,max(docjsxxid)+1) FROM zn_docjsxx ");
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
    #endregion  ExtensionMethod
  }
}

