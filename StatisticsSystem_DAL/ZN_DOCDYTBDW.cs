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
  /// 数据访问类:ZN_DOCDYTBDW
  /// </summary>
  public partial class ZN_DOCDYTBDW
  {
    public ZN_DOCDYTBDW()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string DOCBM, string DWBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ZN_DOCDYTBDW");
      strSql.Append(" where DOCBM=:DOCBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = DOCBM;
      parameters[1].Value = DWBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_DOCDYTBDW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ZN_DOCDYTBDW(");
      strSql.Append("DOCBM,DWBM)");
      strSql.Append(" values (");
      strSql.Append(":DOCBM,:DWBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.DOCBM;
      parameters[1].Value = model.DWBM;

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
    public bool Update(StatisticsSystem.Model.ZN_DOCDYTBDW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ZN_DOCDYTBDW set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
      strSql.Append("DOCBM=:DOCBM,");
      strSql.Append("DWBM=:DWBM");
      strSql.Append(" where DOCBM=:DOCBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.DOCBM;
      parameters[1].Value = model.DWBM;

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
    public bool Delete(string DOCBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCDYTBDW ");
      strSql.Append(" where DOCBM=:DOCBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = DOCBM;
      parameters[1].Value = DWBM;

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
    public StatisticsSystem.Model.ZN_DOCDYTBDW GetModel(string DOCBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select DOCBM,DWBM from ZN_DOCDYTBDW ");
      strSql.Append(" where DOCBM=:DOCBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = DOCBM;
      parameters[1].Value = DWBM;

      StatisticsSystem.Model.ZN_DOCDYTBDW model = new StatisticsSystem.Model.ZN_DOCDYTBDW();
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
    public StatisticsSystem.Model.ZN_DOCDYTBDW DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ZN_DOCDYTBDW model = new StatisticsSystem.Model.ZN_DOCDYTBDW();
      if (row != null)
      {
        if (row["DOCBM"] != null)
        {
          model.DOCBM = row["DOCBM"].ToString();
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
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
      strSql.Append("select DOCBM,DWBM ");
      strSql.Append(" FROM ZN_DOCDYTBDW ");
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
      strSql.Append("select count(1) FROM ZN_DOCDYTBDW ");
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
        strSql.Append("order by T.DWBM desc");
      }
      strSql.Append(")AS Row, T.*  from ZN_DOCDYTBDW T ");
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
          new OracleParameter(":PageSize", OracleDbType.Number),
          new OracleParameter(":PageIndex", OracleDbType.Number),
          new OracleParameter(":IsReCount", OracleDbType.Clob),
          new OracleParameter(":OrderType", OracleDbType.Clob),
          new OracleParameter(":strWhere", OracleDbType.Varchar2,1000),
          };
      parameters[0].Value = "ZN_DOCDYTBDW";
      parameters[1].Value = "DWBM";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod

    #endregion  ExtensionMethod
  }
}

