using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:BBDYTBDW
  /// </summary>
  public partial class BBDYTBDW
  {
    public BBDYTBDW()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM, string DWBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from BBDYTBDW");
      strSql.Append(" where BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = DWBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.BBDYTBDW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into BBDYTBDW(");
      strSql.Append("BBBM,DWBM,SUMDW,isglzb)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:DWBM,:SUMDW,:isglzb)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":SUMDW", OracleDbType.Varchar2,20),
					new OracleParameter(":isglzb", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.DWBM;
      parameters[2].Value = model.SUMDW;
      parameters[3].Value = model.Isglzb;

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
    public bool Update(StatisticsSystem.Model.BBDYTBDW model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update BBDYTBDW set ");
      strSql.Append("SUMDW=:SUMDW");
      strSql.Append(" where BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":SUMDW", OracleDbType.Varchar2,20),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.SUMDW;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.DWBM;

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
    public bool Delete(string BBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from BBDYTBDW ");
      strSql.Append(" where BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
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
    public StatisticsSystem.Model.BBDYTBDW GetModel(string BBBM, string DWBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,DWBM,SUMDW from BBDYTBDW ");
      strSql.Append(" where BBBM=:BBBM and DWBM=:DWBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20)			};
      parameters[0].Value = BBBM;
      parameters[1].Value = DWBM;

      StatisticsSystem.Model.BBDYTBDW model = new StatisticsSystem.Model.BBDYTBDW();
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
    public StatisticsSystem.Model.BBDYTBDW DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.BBDYTBDW model = new StatisticsSystem.Model.BBDYTBDW();
      if (row != null)
      {
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
        }
        if (row["SUMDW"] != null)
        {
          model.SUMDW = row["SUMDW"].ToString();
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
      strSql.Append("select BBBM,DWBM,SUMDW,isglzb ");
      strSql.Append(" FROM BBDYTBDW ");
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
      strSql.Append("select count(1) FROM BBDYTBDW ");
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
      strSql.Append(")AS Row, T.*  from BBDYTBDW T ");
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
      parameters[0].Value = "BBDYTBDW";
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
    public bool InsertZB(string bbbm, string dwbm, string user)
    {
      //bool flag = false;
      //只删除由本管理员创建指标
      string sql = @"delete from enco_zbbmb_dw where bbbm=:bbbm and dwbm=:dwbm and dwbm in 
        (select bzsz1 from enco_zbbmb where bbbm=:bbbm and bzsz1=:dwbm)";
      OracleParameter[] parameters = {
          new OracleParameter(":bbbm", OracleDbType.Varchar2, 50),
          new OracleParameter(":dwbm", OracleDbType.Varchar2, 50)};
      parameters[0].Value = bbbm;
      parameters[1].Value = dwbm;
      int i = DbHelperOra.ExecuteSql(sql, parameters);
      sql = @"
insert into enco_zbbmb_dw(zbbm,dwbm,cjr,cjsj,bbbm) 
select zbbm,:dwbm,:cjr,:cjsj,:bbbm from enco_zbbmb where bbbm=:bbbm and bzsz1=:dwbm";
      parameters = new OracleParameter[4]{
          new OracleParameter(":dwbm", OracleDbType.Varchar2, 50),
          new OracleParameter(":cjr",  OracleDbType.Varchar2, 50),
          new OracleParameter(":cjsj", OracleDbType.Varchar2, 50),
          new OracleParameter(":bbbm", OracleDbType.Varchar2, 50)
          };
      parameters[0].Value = dwbm;
      parameters[1].Value = "";
      parameters[2].Value = "";
      parameters[3].Value = bbbm;
      i = DbHelperOra.ExecuteSql(sql, parameters);
      return i > 0 ? true : false;
    }
    public bool InsertCol(string bbbm, string dwbm, string user)
    {
      string sql = @"insert into enco_bbzd_dw(zd,dwbm,cjr,cjsj,bbbm)
select zd,:dwbm,:cjr,:cjsj,:bbbm from enco_bbzd where bbbm=:bbbm and zdsx<14 and sfyc='是'";
      OracleParameter[] parameters = new OracleParameter[4]{
          new OracleParameter(":dwbm", OracleDbType.Varchar2, 50),
          new OracleParameter(":cjr",  OracleDbType.Varchar2, 50),
          new OracleParameter(":cjsj", OracleDbType.Varchar2, 50),
          new OracleParameter(":bbbm", OracleDbType.Varchar2, 50)
          };
      parameters[0].Value = dwbm;
      parameters[1].Value = "";
      parameters[2].Value = "";
      parameters[3].Value = bbbm;
      int i = DbHelperOra.ExecuteSql(sql, parameters);
      return i > 0 ? true : false;

    }
    public bool Delete(string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from BBDYTBDW ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,50)		};
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
    #endregion  ExtensionMethod
  }
}

