using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using DBUtilityOdp;
using System.Collections.Generic;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ENCO_ZBBMB_DW
  /// </summary>
  public partial class ENCO_ZBBMB_DW
  {
    public ENCO_ZBBMB_DW()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string ZBBM, string DWBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_ZBBMB_DW");
      strSql.Append(" where ZBBM=:ZBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM",OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZBBM;
      parameters[1].Value = DWBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB_DW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_ZBBMB_DW(");
      strSql.Append("ZBBM,DWBM)");
      strSql.Append(" values (");
      strSql.Append(":ZBBM,:DWBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ZBBM;
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
    public bool Update(StatisticsSystem.Model.ENCO_ZBBMB_DW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_ZBBMB_DW set ");
#warning 系统发现缺少更新的字段，请手工确认如此更新是否正确！
      strSql.Append("ZBBM=:ZBBM,");
      strSql.Append("DWBM=:DWBM");
      strSql.Append(" where ZBBM=:ZBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ZBBM;
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
    public bool Delete(string ZBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_ZBBMB_DW ");
      strSql.Append(" where ZBBM=:ZBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZBBM;
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
    public StatisticsSystem.Model.ENCO_ZBBMB_DW GetModel(string ZBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select ZBBM,DWBM from ENCO_ZBBMB_DW ");
      strSql.Append(" where ZBBM=:ZBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZBBM;
      parameters[1].Value = DWBM;

      StatisticsSystem.Model.ENCO_ZBBMB_DW model = new StatisticsSystem.Model.ENCO_ZBBMB_DW();
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
    public StatisticsSystem.Model.ENCO_ZBBMB_DW DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_ZBBMB_DW model = new StatisticsSystem.Model.ENCO_ZBBMB_DW();
      if (row != null)
      {
        if (row["ZBBM"] != null)
        {
          model.ZBBM = row["ZBBM"].ToString();
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
      strSql.Append("select ZBBM,DWBM ");
      strSql.Append(" FROM ENCO_ZBBMB_DW ");
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
      strSql.Append("select count(1) FROM ENCO_ZBBMB_DW ");
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
      strSql.Append(")AS Row, T.*  from ENCO_ZBBMB_DW T ");
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
      parameters[0].Value = "ENCO_ZBBMB_DW";
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

    /// <summary>
    /// 获得数据列表
    /// </summary>
    public DataTable GetZBBM_DW(string bbbm)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select a.ZBBM,c.dwmc ");
      strSql.Append(" FROM ENCO_ZBBMB_DW a,enco_zbbmb b,dwbmb c ");
      strSql.Append(" where a.dwbm=c.dwbm and a.zbbm=b.zbbm ");
      strSql.Append(" and b.bbbm='" + bbbm + "'");
      DataSet ds = DbHelperOra.Query(strSql.ToString());
      return ds.Tables[0];
    }
    public bool Delete(string ZBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_ZBBMB_DW ");
      strSql.Append(" where ZBBM=:ZBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZBBM;

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
    public bool Deletebbbm(string bbbm)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_ZBBMB_DW ");
      strSql.Append(" where bbbm=:bbbm  ");
      OracleParameter[] parameters = {
					new OracleParameter(":bbbm", OracleDbType.Varchar2,20)			};
      parameters[0].Value = bbbm;

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

