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
  /// 数据访问类:ENCO_BBZD_DW
  /// </summary>
  public partial class ENCO_BBZD_DW
  {
    public ENCO_BBZD_DW()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string ZD, string DWBM, string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_BBZD_DW");
      strSql.Append(" where ZD=:ZD and DWBM=:DWBM and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZD", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZD;
      parameters[1].Value = DWBM;
      parameters[2].Value = BBBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD_DW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_BBZD_DW(");
      strSql.Append("ZD,DWBM,CJR,CJSJ,BBBM)");
      strSql.Append(" values (");
      strSql.Append(":ZD,:DWBM,:CJR,:CJSJ,:BBBM)");
      OracleParameter[] parameters = {
					new OracleParameter(":ZD", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":CJR", OracleDbType.Varchar2,20),
					new OracleParameter(":CJSJ", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.ZD;
      parameters[1].Value = model.DWBM;
      parameters[2].Value = model.CJR;
      parameters[3].Value = model.CJSJ;
      parameters[4].Value = model.BBBM;

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
    public bool Update(StatisticsSystem.Model.ENCO_BBZD_DW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_BBZD_DW set ");
      strSql.Append("CJR=:CJR,");
      strSql.Append("CJSJ=:CJSJ");
      strSql.Append(" where ZD=:ZD and DWBM=:DWBM and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":CJR", OracleDbType.Varchar2,20),
					new OracleParameter(":CJSJ", OracleDbType.Varchar2,20),
					new OracleParameter(":ZD", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.CJR;
      parameters[1].Value = model.CJSJ;
      parameters[2].Value = model.ZD;
      parameters[3].Value = model.DWBM;
      parameters[4].Value = model.BBBM;

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
    public bool Delete(string ZD, string DWBM, string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_BBZD_DW ");
      strSql.Append(" where ZD=:ZD and DWBM=:DWBM and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZD", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZD;
      parameters[1].Value = DWBM;
      parameters[2].Value = BBBM;

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
    public StatisticsSystem.Model.ENCO_BBZD_DW GetModel(string ZD, string DWBM, string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select ZD,DWBM,CJR,CJSJ,BBBM from ENCO_BBZD_DW ");
      strSql.Append(" where ZD=:ZD and DWBM=:DWBM and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":ZD", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = ZD;
      parameters[1].Value = DWBM;
      parameters[2].Value = BBBM;

      StatisticsSystem.Model.ENCO_BBZD_DW model = new StatisticsSystem.Model.ENCO_BBZD_DW();
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
    public StatisticsSystem.Model.ENCO_BBZD_DW DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_BBZD_DW model = new StatisticsSystem.Model.ENCO_BBZD_DW();
      if (row != null)
      {
        if (row["ZD"] != null)
        {
          model.ZD = row["ZD"].ToString();
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
        }
        if (row["CJR"] != null)
        {
          model.CJR = row["CJR"].ToString();
        }
        if (row["CJSJ"] != null)
        {
          model.CJSJ = row["CJSJ"].ToString();
        }
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
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
      strSql.Append("select ZD,DWBM,CJR,CJSJ,BBBM ");
      strSql.Append(" FROM ENCO_BBZD_DW ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    //public int GetRecordCount(string strWhere)
    //{
    //  StringBuilder strSql = new StringBuilder();
    //  strSql.Append("select count(1) FROM ENCO_BBZD_DW ");
    //  if (strWhere.Trim() != "")
    //  {
    //    strSql.Append(" where " + strWhere);
    //  }
    //  object obj = DbHelperSQL.GetSingle(strSql.ToString());
    //  if (obj == null)
    //  {
    //    return 0;
    //  }
    //  else
    //  {
    //    return Convert.ToInt32(obj);
    //  }
    //}
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
        strSql.Append("order by T.BBBM desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_BBZD_DW T ");
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
      parameters[0].Value = "ENCO_BBZD_DW";
      parameters[1].Value = "BBBM";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod

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
