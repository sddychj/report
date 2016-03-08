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
  /// 数据访问类:ENCO_JSXXYSJ_COL
  /// </summary>
  public partial class ENCO_JSXXYSJ_COL
  {
    public ENCO_JSXXYSJ_COL()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JSXXID, string ONAME)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_JSXXYSJ_COL");
      strSql.Append(" where JSXXID=:JSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JSXXID;
      parameters[1].Value = ONAME;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_JSXXYSJ_COL model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_JSXXYSJ_COL(");
      strSql.Append("JSXXID,ONAME,OBBBM,OZD,ODWBM,ONF,OYF)");
      strSql.Append(" values (");
      strSql.Append(":JSXXID,:ONAME,:OBBBM,:OZD,:ODWBM,:ONF,:OYF)");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10),
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Varchar2,20),
					new OracleParameter(":OYF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.JSXXID;
      parameters[1].Value = model.ONAME;
      parameters[2].Value = model.OBBBM;
      parameters[3].Value = model.OZD;
      parameters[4].Value = model.ODWBM;
      parameters[5].Value = model.ONF;
      parameters[6].Value = model.OYF;

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
    public bool Update(StatisticsSystem.Model.ENCO_JSXXYSJ_COL model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_JSXXYSJ_COL set ");
      strSql.Append("OBBBM=:OBBBM,");
      strSql.Append("OZD=:OZD,");
      strSql.Append("ODWBM=:ODWBM,");
      strSql.Append("ONF=:ONF,");
      strSql.Append("OYF=:OYF");
      strSql.Append(" where JSXXID=:JSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":OBBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":OZD", OracleDbType.Varchar2,30),
					new OracleParameter(":ODWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":ONF", OracleDbType.Varchar2,20),
					new OracleParameter(":OYF", OracleDbType.Varchar2,20),
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)};
      parameters[0].Value = model.OBBBM;
      parameters[1].Value = model.OZD;
      parameters[2].Value = model.ODWBM;
      parameters[3].Value = model.ONF;
      parameters[4].Value = model.OYF;
      parameters[5].Value = model.JSXXID;
      parameters[6].Value = model.ONAME;

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
    public bool Delete(decimal JSXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_JSXXYSJ_COL ");
      strSql.Append(" where JSXXID=:JSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JSXXID;
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
    public StatisticsSystem.Model.ENCO_JSXXYSJ_COL GetModel(decimal JSXXID, string ONAME)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JSXXID,ONAME,OBBBM,OZD,ODWBM,ONF,OYF from ENCO_JSXXYSJ_COL ");
      strSql.Append(" where JSXXID=:JSXXID and ONAME=:ONAME ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":ONAME", OracleDbType.Varchar2,10)			};
      parameters[0].Value = JSXXID;
      parameters[1].Value = ONAME;

      StatisticsSystem.Model.ENCO_JSXXYSJ_COL model = new StatisticsSystem.Model.ENCO_JSXXYSJ_COL();
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
    public StatisticsSystem.Model.ENCO_JSXXYSJ_COL DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_JSXXYSJ_COL model = new StatisticsSystem.Model.ENCO_JSXXYSJ_COL();
      if (row != null)
      {
        if (row["JSXXID"] != null && row["JSXXID"].ToString() != "")
        {
          model.JSXXID = decimal.Parse(row["JSXXID"].ToString());
        }
        if (row["ONAME"] != null)
        {
          model.ONAME = row["ONAME"].ToString();
        }
        if (row["OBBBM"] != null)
        {
          model.OBBBM = row["OBBBM"].ToString();
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
      strSql.Append("select JSXXID,ONAME,OBBBM,OZD,ODWBM,ONF,OYF ");
      strSql.Append(" FROM ENCO_JSXXYSJ_COL ");
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
      strSql.Append("select count(1) FROM ENCO_JSXXYSJ_COL ");
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
        strSql.Append("order by T.ONAME desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_JSXXYSJ_COL T ");
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
      parameters[0].Value = "ENCO_JSXXYSJ_COL";
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
    public bool Delete(decimal JSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_JSXXYSJ_col ");
      strSql.Append(" where JSXXID=:JSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = JSXXID;

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

