using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:JYXXYSJ
  /// </summary>
  public partial class JYXXYSJ
  {
    public JYXXYSJ()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JYXXID, string ONAME)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from JYXXYSJ");
      strSql.Append(" where JYXXID=:JYXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JYXXID;
      parameters[1].Value = ONAME;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXXYSJ model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into JYXXYSJ(");
      strSql.Append("JYXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF)");
      strSql.Append(" values (");
      strSql.Append(":JYXXID,:ONAME,:OBBBM,:OZBBM,:OZD,:ODWBM,:ONF,:OYF)");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10),
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Varchar2,20),
					new OracleParameter(":OYF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.JYXXID;
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
    public bool Update(StatisticsSystem.Model.JYXXYSJ model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update JYXXYSJ set ");
      strSql.Append("OBBBM=:OBBBM,");
      strSql.Append("OZBBM=:OZBBM,");
      strSql.Append("OZD=:OZD,");
      strSql.Append("ODWBM=:ODWBM,");
      strSql.Append("ONF=:ONF,");
      strSql.Append("OYF=:OYF");
      strSql.Append(" where JYXXID=:JYXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF",OracleDbType.Varchar2,20),
					new OracleParameter(":OYF",OracleDbType.Varchar2,20),
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)};
      parameters[0].Value = model.OBBBM;
      parameters[1].Value = model.OZBBM;
      parameters[2].Value = model.OZD;
      parameters[3].Value = model.ODWBM;
      parameters[4].Value = model.ONF;
      parameters[5].Value = model.OYF;
      parameters[6].Value = model.JYXXID;
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
    public bool Delete(decimal JYXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from JYXXYSJ ");
      strSql.Append(" where JYXXID=:JYXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JYXXID;
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
    public StatisticsSystem.Model.JYXXYSJ GetModel(decimal JYXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JYXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF from JYXXYSJ ");
      strSql.Append(" where JYXXID=:JYXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JYXXID;
      parameters[1].Value = ONAME;

      StatisticsSystem.Model.JYXXYSJ model = new StatisticsSystem.Model.JYXXYSJ();
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
    public StatisticsSystem.Model.JYXXYSJ DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.JYXXYSJ model = new StatisticsSystem.Model.JYXXYSJ();
      if (row != null)
      {
        if (row["JYXXID"] != null && row["JYXXID"].ToString() != "")
        {
          model.JYXXID = decimal.Parse(row["JYXXID"].ToString());
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
      strSql.Append("select JYXXID,ONAME,OBBBM,OZBBM,OZD,ODWBM,ONF,OYF ");
      strSql.Append(" FROM JYXXYSJ ");
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
      strSql.Append("select count(1) FROM JYXXYSJ ");
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
      strSql.Append(")AS Row, T.*  from JYXXYSJ T ");
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
      parameters[0].Value = "JYXXYSJ";
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
    public bool Delete(decimal JYXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from JYXXYSJ ");
      strSql.Append(" where JYXXID=:JYXXID");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8)		};
      parameters[0].Value = JYXXID;

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

