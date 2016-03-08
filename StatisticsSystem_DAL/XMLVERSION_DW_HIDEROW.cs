using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:XMLVERSION_DW_HIDEROW
  /// </summary>
  public partial class XMLVERSION_DW_HIDEROW
  {
    public XMLVERSION_DW_HIDEROW()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal YEAR, string BBBM, string DWBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from XMLVERSION_DW_HIDEROW");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;
      parameters[2].Value = DWBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into XMLVERSION_DW_HIDEROW(");
      strSql.Append("YEAR,BBBM,DWBM,HIDDENROW)");
      strSql.Append(" values (");
      strSql.Append(":YEAR,:BBBM,:DWBM,:HIDDENROW)");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":HIDDENROW", OracleDbType.Clob,4000)};
      parameters[0].Value = model.YEAR;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.DWBM;
      parameters[3].Value = model.HIDDENROW;

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
    public bool Update(StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update XMLVERSION_DW_HIDEROW set ");
      strSql.Append("HIDDENROW=:HIDDENROW");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":HIDDENROW", OracleDbType.Clob,4000),
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.HIDDENROW;
      parameters[1].Value = model.YEAR;
      parameters[2].Value = model.BBBM;
      parameters[3].Value = model.DWBM;

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
    public bool Delete(decimal YEAR, string BBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from XMLVERSION_DW_HIDEROW ");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;
      parameters[2].Value = DWBM;

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
    public StatisticsSystem.Model.XMLVERSION_DW_HIDEROW GetModel(decimal YEAR, string BBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select YEAR,BBBM,DWBM,HIDDENROW from XMLVERSION_DW_HIDEROW ");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;
      parameters[2].Value = DWBM;

      StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model = new StatisticsSystem.Model.XMLVERSION_DW_HIDEROW();
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
    public StatisticsSystem.Model.XMLVERSION_DW_HIDEROW DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.XMLVERSION_DW_HIDEROW model = new StatisticsSystem.Model.XMLVERSION_DW_HIDEROW();
      if (row != null)
      {
        if (row["YEAR"] != null && row["YEAR"].ToString() != "")
        {
          model.YEAR = decimal.Parse(row["YEAR"].ToString());
        }
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
        }
        if (row["HIDDENROW"] != null)
        {
          model.HIDDENROW = row["HIDDENROW"].ToString();
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
      strSql.Append("select YEAR,BBBM,DWBM,HIDDENROW ");
      strSql.Append(" FROM XMLVERSION_DW_HIDEROW ");
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
      strSql.Append("select count(1) FROM XMLVERSION_DW_HIDEROW ");
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
        strSql.Append("order by T.DWBM desc");
      }
      strSql.Append(")AS Row, T.*  from XMLVERSION_DW_HIDEROW T ");
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
      parameters[0].Value = "XMLVERSION_DW_HIDEROW";
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

    public DataSet GetListDWMC(string bbbm, string year)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select b.DWBM,b.dwmc ");
      strSql.Append(" FROM XMLVERSION_DW_hiderow a,dwbmb b where a.dwbm=b.dwbm and a.bbbm=:0 and a.year=:1");
      OracleParameter[] parameters = {
          new OracleParameter(":0", OracleDbType.Varchar2, 255),
          new OracleParameter(":1", OracleDbType.Varchar2, 255)};

      parameters[0].Value = bbbm;
      parameters[1].Value = year;
      return DbHelperOra.Query(strSql.ToString(), parameters);
    }

    #endregion  ExtensionMethod
  }
}

