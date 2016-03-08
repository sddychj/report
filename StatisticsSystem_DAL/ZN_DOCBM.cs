using System;
using System.Data;
using System.Text;
//using System.Data.OracleClient;
//using Maticsoft.DBUtility;//Please add references
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Data;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ZN_DOCBM
  /// </summary>
  public partial class ZN_DOCBM
  {
    public ZN_DOCBM()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string DOCBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ZN_DOCBM");
      strSql.Append(" where DOCBM=:DOCBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_DOCBM model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ZN_DOCBM(");
      strSql.Append("DOCBM,DOCMC,DOTMC,DOCZQ)");
      strSql.Append(" values (");
      strSql.Append(":DOCBM,:DOCMC,:DOTMC,:DOCZQ)");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10),
					new OracleParameter(":DOCMC", OracleDbType.Varchar2,100),
					new OracleParameter(":DOTMC", OracleDbType.Varchar2,100),
					new OracleParameter(":DOCZQ", OracleDbType.Varchar2,10)};
      parameters[0].Value = model.DOCBM;
      parameters[1].Value = model.DOCMC;
      parameters[2].Value = model.DOTMC;
      parameters[3].Value = model.DOCZQ;

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
    public bool Update(StatisticsSystem.Model.ZN_DOCBM model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ZN_DOCBM set ");
      strSql.Append("DOCMC=:DOCMC,");
      strSql.Append("DOTMC=:DOTMC,");
      strSql.Append("DOCZQ=:DOCZQ");
      strSql.Append(" where DOCBM=:DOCBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCMC", OracleDbType.Varchar2,100),
					new OracleParameter(":DOTMC", OracleDbType.Varchar2,100),
					new OracleParameter(":DOCZQ", OracleDbType.Varchar2,10),
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10)};
      parameters[0].Value = model.DOCMC;
      parameters[1].Value = model.DOTMC;
      parameters[2].Value = model.DOCZQ;
      parameters[3].Value = model.DOCBM;

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
    public bool Delete(string DOCBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCBM ");
      strSql.Append(" where DOCBM=:DOCBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCBM;

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
    public bool DeleteList(string DOCBMlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ZN_DOCBM ");
      strSql.Append(" where DOCBM in (" + DOCBMlist + ")  ");
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
    public StatisticsSystem.Model.ZN_DOCBM GetModel(string DOCBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select DOCBM,DOCMC,DOTMC,DOCZQ from ZN_DOCBM ");
      strSql.Append(" where DOCBM=:DOCBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":DOCBM", OracleDbType.Varchar2,10)			};
      parameters[0].Value = DOCBM;

      StatisticsSystem.Model.ZN_DOCBM model = new StatisticsSystem.Model.ZN_DOCBM();
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
    public StatisticsSystem.Model.ZN_DOCBM DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ZN_DOCBM model = new StatisticsSystem.Model.ZN_DOCBM();
      if (row != null)
      {
        if (row["DOCBM"] != null)
        {
          model.DOCBM = row["DOCBM"].ToString();
        }
        if (row["DOCMC"] != null)
        {
          model.DOCMC = row["DOCMC"].ToString();
        }
        if (row["DOTMC"] != null)
        {
          model.DOTMC = row["DOTMC"].ToString();
        }
        if (row["DOCZQ"] != null)
        {
          model.DOCZQ = row["DOCZQ"].ToString();
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
      strSql.Append("select a.DOCBM,DOCMC,DOTMC,DOCZQ,DWBM ");
      strSql.Append(" FROM ZN_DOCBM a,ZN_DOCDYTBDW b where a.docbm=b.docbm ");
      if (strWhere.Trim() != "")
      {
        strSql.Append("  " + strWhere);
      }
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM ZN_DOCBM ");
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
        strSql.Append("order by T.DOCBM desc");
      }
      strSql.Append(")AS Row, T.*  from ZN_DOCBM T ");
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
      parameters[0].Value = "ZN_DOCBM";
      parameters[1].Value = "DOCBM";
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

