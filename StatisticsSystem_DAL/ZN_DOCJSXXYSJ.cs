using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Data;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ZN_DOCJSXXYSJ
  /// </summary>
  public partial class ZN_DOCJSXXYSJ
  {
    public ZN_DOCJSXXYSJ()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal DOCJSXXID, string ONAME)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ZN_DOCJSXXYSJ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCJSXXID;
      parameters[1].Value = ONAME;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_DOCJSXXYSJ model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ZN_DOCJSXXYSJ(");
      strSql.Append("DOCJSXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF)");
      strSql.Append(" values (");
      strSql.Append(":DOCJSXXID,:ONAME,:OBBBM,:OZBBM,:OZD,:ODWBM,:ONF,:OYF)");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10),
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Varchar2,20),
					new OracleParameter(":OYF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.DOCJSXXID;
      parameters[1].Value = model.ONAME;
      parameters[2].Value = model.OBBBM;
      parameters[3].Value = model.OZBBM;
      parameters[4].Value = model.OZD;
      parameters[5].Value = model.ODWBM;
      parameters[6].Value = model.ONF;
      parameters[7].Value = model.OYF;

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
    public bool Update(StatisticsSystem.Model.ZN_DOCJSXXYSJ model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ZN_DOCJSXXYSJ set ");
      strSql.Append("OBBBM=:OBBBM,");
      strSql.Append("OZBBM=:OZBBM,");
      strSql.Append("OZD=:OZD,");
      strSql.Append("ODWBM=:ODWBM,");
      strSql.Append("ONF=:ONF,");
      strSql.Append("OYF=:OYF");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Varchar2,20),
					new OracleParameter(":OYF", OracleDbType.Varchar2,20),
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)};
      parameters[0].Value = model.OBBBM;
      parameters[1].Value = model.OZBBM;
      parameters[2].Value = model.OZD;
      parameters[3].Value = model.ODWBM;
      parameters[4].Value = model.ONF;
      parameters[5].Value = model.OYF;
      parameters[6].Value = model.DOCJSXXID;
      parameters[7].Value = model.ONAME;

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
    public bool Delete(decimal DOCJSXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCJSXXYSJ ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCJSXXID;
      parameters[1].Value = ONAME;

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
    public StatisticsSystem.Model.ZN_DOCJSXXYSJ GetModel(decimal DOCJSXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select DOCJSXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF from ZN_DOCJSXXYSJ ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCJSXXID;
      parameters[1].Value = ONAME;

      StatisticsSystem.Model.ZN_DOCJSXXYSJ model = new StatisticsSystem.Model.ZN_DOCJSXXYSJ();
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
    public StatisticsSystem.Model.ZN_DOCJSXXYSJ DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ZN_DOCJSXXYSJ model = new StatisticsSystem.Model.ZN_DOCJSXXYSJ();
      if (row != null)
      {
        if (row["DOCJSXXID"] != null && row["DOCJSXXID"].ToString() != "")
        {
          model.DOCJSXXID = decimal.Parse(row["DOCJSXXID"].ToString());
        }
        if (row["ONAME"] != null)
        {
          model.ONAME = row["ONAME"].ToString();
        }
        if (row["OBBBM"] != null)
        {
          model.OBBBM = row["OBBBM"].ToString();
        }
        if (row["OZBBM"] != null)
        {
          model.OZBBM = row["OZBBM"].ToString();
        }
        if (row["OZD"] != null)
        {
          model.OZD = row["OZD"].ToString();
        }
        if (row["ODWBM"] != null)
        {
          model.ODWBM = row["ODWBM"].ToString();
        }
        if (row["ONF"] != null)
        {
          model.ONF = row["ONF"].ToString();
        }
        if (row["OYF"] != null)
        {
          model.OYF = row["OYF"].ToString();
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
      strSql.Append("select DOCJSXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF ");
      strSql.Append(" FROM ZN_DOCJSXXYSJ ");
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
      strSql.Append("select count(1) FROM ZN_DOCJSXXYSJ ");
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
        strSql.Append("order by T.ONAME desc");
      }
      strSql.Append(")AS Row, T.*  from ZN_DOCJSXXYSJ T ");
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
      parameters[0].Value = "ZN_DOCJSXXYSJ";
      parameters[1].Value = "ONAME";
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
    /// 删除一条数据
    /// </summary>
    public bool Delete(decimal DOCJSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCJSXXYSJ ");
      strSql.Append(" where DOCJSXXID=:DOCJSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCJSXXID", OracleDbType.Double,10)	};
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

    #endregion  ExtensionMethod
  }
}

