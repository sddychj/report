using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Data;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ENCO_BBLX
  /// </summary>
  public partial class ENCO_BBLX
  {
    public ENCO_BBLX()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal ID)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_BBLX");
      strSql.Append(" where ID=:ID ");
      OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleDbType.Double,4)			};
      parameters[0].Value = ID;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBLX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_BBLX(");
      strSql.Append("ID,LBMC)");
      strSql.Append(" values (");
      strSql.Append(":ID,:LBMC)");
      OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleDbType.Double,4),
					new OracleParameter(":LBMC", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ID;
      parameters[1].Value = model.LBMC;

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
    public bool Update(StatisticsSystem.Model.ENCO_BBLX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_BBLX set ");
      strSql.Append("LBMC=:LBMC");
      strSql.Append(" where ID=:ID ");
      OracleParameter[] parameters = {
					new OracleParameter(":LBMC", OracleDbType.Varchar2,50),
					new OracleParameter(":ID", OracleDbType.Double,4)};
      parameters[0].Value = model.LBMC;
      parameters[1].Value = model.ID;

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
    public bool Delete(decimal ID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_BBLX ");
      strSql.Append(" where ID=:ID ");
      OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleDbType.Double,4)			};
      parameters[0].Value = ID;

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
    public bool DeleteList(string IDlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_BBLX ");
      strSql.Append(" where ID in (" + IDlist + ")  ");
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
    public StatisticsSystem.Model.ENCO_BBLX GetModel(decimal ID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select ID,LBMC from ENCO_BBLX ");
      strSql.Append(" where ID=:ID ");
      OracleParameter[] parameters = {
					new OracleParameter(":ID", OracleDbType.Double,4)			};
      parameters[0].Value = ID;

      StatisticsSystem.Model.ENCO_BBLX model = new StatisticsSystem.Model.ENCO_BBLX();
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
    public StatisticsSystem.Model.ENCO_BBLX DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_BBLX model = new StatisticsSystem.Model.ENCO_BBLX();
      if (row != null)
      {
        if (row["ID"] != null && row["ID"].ToString() != "")
        {
          model.ID = decimal.Parse(row["ID"].ToString());
        }
        if (row["LBMC"] != null)
        {
          model.LBMC = row["LBMC"].ToString();
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
      strSql.Append("select ID,LBMC ");
      strSql.Append(" FROM ENCO_BBLX ");
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
      strSql.Append("select count(1) FROM ENCO_BBLX ");
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
        strSql.Append("order by T.ID desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_BBLX T ");
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
      parameters[0].Value = "ENCO_BBLX";
      parameters[1].Value = "ID";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod
    public int GetMaxID(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select MAX(ID)+1 FROM ENCO_BBLX ");
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

    #endregion  ExtensionMethod
  }
}
