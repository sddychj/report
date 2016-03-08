using System;
using System.Data;
using System.Text;
//using System.Data.OracleClient;
//using Maticsoft.DBUtility;//Please add references
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using DBUtilityOdp;
namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:JYXX_YYBB
  /// </summary>
  public partial class JYXX_YYBB
  {
    public JYXX_YYBB()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string YYBBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from JYXX_YYBB");
      strSql.Append(" where BBBM=:BBBM and YYBBBM=:YYBBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = YYBBBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXX_YYBB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into JYXX_YYBB(");
      strSql.Append("BBBM,YYBBBM)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:YYBBBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.YYBBBM;

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
    public bool Update(StatisticsSystem.Model.JYXX_YYBB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update JYXX_YYBB set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
      strSql.Append("BBBM=:BBBM,");
      strSql.Append("YYBBBM=:YYBBBM");
      strSql.Append(" where BBBM=:BBBM and YYBBBM=:YYBBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.YYBBBM;

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
    public bool Delete(string BBBM, string YYBBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from JYXX_YYBB ");
      strSql.Append(" where BBBM=:BBBM and YYBBBM=:YYBBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = YYBBBM;

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
    public StatisticsSystem.Model.JYXX_YYBB GetModel(string BBBM, string YYBBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,YYBBBM from JYXX_YYBB ");
      strSql.Append(" where BBBM=:BBBM and YYBBBM=:YYBBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":YYBBBM", OracleDbType.Varchar2,30)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = YYBBBM;

      StatisticsSystem.Model.JYXX_YYBB model = new StatisticsSystem.Model.JYXX_YYBB();
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
    public StatisticsSystem.Model.JYXX_YYBB DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.JYXX_YYBB model = new StatisticsSystem.Model.JYXX_YYBB();
      if (row != null)
      {
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["YYBBBM"] != null)
        {
          model.YYBBBM = row["YYBBBM"].ToString();
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
      strSql.Append("select BBBM,YYBBBM ");
      strSql.Append(" FROM JYXX_YYBB ");
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
      strSql.Append("select count(1) FROM JYXX_YYBB ");
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
        strSql.Append("order by T.YYBBBM desc");
      }
      strSql.Append(")AS Row, T.*  from JYXX_YYBB T ");
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
      parameters[0].Value = "JYXX_YYBB";
      parameters[1].Value = "YYBBBM";
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
    public bool Delete(string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from jyxx_YYBB ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)			};
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
      strSql.Append("select a.BBBM,YYBBBM,b.BBMC,B.BBWH,c.lbmc ");
      strSql.Append(" FROM jyxx_YYBB a,code_bbbmb b,enco_bblx c where a.bbbm=:0 and a.YYBBBM=b.bbbm and b.bblx=c.id");
      strSql.Append(" order by c.id,b.pxxh");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;

      return DbHelperOra.Query(strSql.ToString(), parameters);
    }
    #endregion  ExtensionMethod
  }
}

