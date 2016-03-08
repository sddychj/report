using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:TIQU
  /// </summary>
  public partial class TIQU
  {
    public TIQU()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string SOURSETABLE, string TARGETTABLE)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from TIQU");
      strSql.Append(" where SOURSETABLE=:SOURSETABLE and TARGETTABLE=:TARGETTABLE ");
      OracleParameter[] parameters = {
					new OracleParameter(":SOURSETABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20)			};
      parameters[0].Value = SOURSETABLE;
      parameters[1].Value = TARGETTABLE;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.TIQU model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into TIQU(");
      strSql.Append("SOURSETABLE,TARGETTABLE,SORSEDWBM,TARGETDWBM,SOURSENF,SOURSEYF)");
      strSql.Append(" values (");
      strSql.Append(":SOURSETABLE,:TARGETTABLE,:SORSEDWBM,:TARGETDWBM,:SOURSENF,:SOURSEYF)");
      OracleParameter[] parameters = {
					new OracleParameter(":SOURSETABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":SORSEDWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETDWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":SOURSENF", OracleDbType.Varchar2,20),
					new OracleParameter(":SOURSEYF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.SOURSETABLE;
      parameters[1].Value = model.TARGETTABLE;
      parameters[2].Value = model.SORSEDWBM;
      parameters[3].Value = model.TARGETDWBM;
      parameters[4].Value = model.SOURSENF;
      parameters[5].Value = model.SOURSEYF;

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
    public bool Update(StatisticsSystem.Model.TIQU model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update TIQU set ");
      strSql.Append("SORSEDWBM=:SORSEDWBM,");
      strSql.Append("TARGETDWBM=:TARGETDWBM,");
      strSql.Append("SOURSENF=:SOURSENF,");
      strSql.Append("SOURSEYF=:SOURSEYF");
      strSql.Append(" where SOURSETABLE=:SOURSETABLE and TARGETTABLE=:TARGETTABLE ");
      OracleParameter[] parameters = {
					new OracleParameter(":SORSEDWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETDWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":SOURSENF", OracleDbType.Varchar2,20),
					new OracleParameter(":SOURSEYF", OracleDbType.Varchar2,20),
					new OracleParameter(":SOURSETABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.SORSEDWBM;
      parameters[1].Value = model.TARGETDWBM;
      parameters[2].Value = model.SOURSENF;
      parameters[3].Value = model.SOURSEYF;
      parameters[4].Value = model.SOURSETABLE;
      parameters[5].Value = model.TARGETTABLE;

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
    public bool Delete(string SOURSETABLE, string TARGETTABLE)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from TIQU ");
      strSql.Append(" where SOURSETABLE=:SOURSETABLE and TARGETTABLE=:TARGETTABLE ");
      OracleParameter[] parameters = {
					new OracleParameter(":SOURSETABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20)			};
      parameters[0].Value = SOURSETABLE;
      parameters[1].Value = TARGETTABLE;

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
    public StatisticsSystem.Model.TIQU GetModel(string SOURSETABLE, string TARGETTABLE)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select SOURSETABLE,TARGETTABLE,SORSEDWBM,TARGETDWBM,SOURSENF,SOURSEYF from TIQU ");
      strSql.Append(" where SOURSETABLE=:SOURSETABLE and TARGETTABLE=:TARGETTABLE ");
      OracleParameter[] parameters = {
					new OracleParameter(":SOURSETABLE", OracleDbType.Varchar2,20),
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20)			};
      parameters[0].Value = SOURSETABLE;
      parameters[1].Value = TARGETTABLE;

      StatisticsSystem.Model.TIQU model = new StatisticsSystem.Model.TIQU();
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
    public StatisticsSystem.Model.TIQU DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.TIQU model = new StatisticsSystem.Model.TIQU();
      if (row != null)
      {
        if (row["SOURSETABLE"] != null)
        {
          model.SOURSETABLE = row["SOURSETABLE"].ToString();
        }
        if (row["TARGETTABLE"] != null)
        {
          model.TARGETTABLE = row["TARGETTABLE"].ToString();
        }
        if (row["SORSEDWBM"] != null)
        {
          model.SORSEDWBM = row["SORSEDWBM"].ToString();
        }
        if (row["TARGETDWBM"] != null)
        {
          model.TARGETDWBM = row["TARGETDWBM"].ToString();
        }
        if (row["SOURSENF"] != null)
        {
          model.SOURSENF = row["SOURSENF"].ToString();
        }
        if (row["SOURSEYF"] != null)
        {
          model.SOURSEYF = row["SOURSEYF"].ToString();
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
      strSql.Append("select SOURSETABLE,TARGETTABLE,SORSEDWBM,TARGETDWBM,SOURSENF,SOURSEYF ");
      strSql.Append(" FROM TIQU ");
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
    //  strSql.Append("select count(1) FROM TIQU ");
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
        strSql.Append("order by T.TARGETTABLE desc");
      }
      strSql.Append(")AS Row, T.*  from TIQU T ");
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
      parameters[0].Value = "TIQU";
      parameters[1].Value = "TARGETTABLE";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod
    public DataSet GetList_tq(string bblx)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append(@"select a.bbbm TARGETBBBM,a.targetdwmc,a.bbwh targetbbbh,a.bbmc targetbbmc,
  b.bbbm soursetable,b.bbwh soursebbbh,b.bbmc soursebbmc,b.lbmc soursebblx,b.dwmc soursedwmc from 
(select a.*,b.*,c.dwmc targetdwmc
 from tiqu a
   right join dwbmb c on a.targetdwbm=c.dwbm 
   right join code_bbbmb b on a.targettable=b.bbbm
 where b.bblx={0}) a,
(select b.*,c.lbmc,d.dwmc,d.dwbm from tiqu a,code_bbbmb b,enco_bblx c,dwbmb d
   where a.soursetable=b.bbbm and b.bblx=c.id and a.sorsedwbm=d.dwbm) b
where a.soursetable=b.bbbm(+)");

      return DbHelperOra.Query(string.Format(strSql.ToString(), bblx));

    }
    public DataSet Get_tq(string bbbm)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append(@"select a.bbbm,a.targetdwmc,a.targetdwbm,a.bbwh targetbbbh,a.bbmc targetbbmc,
  b.bbbm soursetable,b.bbwh soursebbbh,b.bbmc soursebbmc,b.soursebblx,b.lbmc soursebblx,b.dwmc soursedwmc,b.dwbm soursedwbm from 
(select a.*,b.*,c.dwmc targetdwmc
 from tiqu a
   right join dwbmb c on a.targetdwbm=c.dwbm 
   right join code_bbbmb b on a.targettable=b.bbbm
 where b.bbbm='{0}') a,
(select b.*,c.id soursebblx,c.lbmc,d.dwmc,d.dwbm from tiqu a,code_bbbmb b,enco_bblx c,dwbmb d
   where a.soursetable=b.bbbm and b.bblx=c.id and a.sorsedwbm=d.dwbm) b
where a.soursetable=b.bbbm(+)");

      return DbHelperOra.Query(string.Format(strSql.ToString(), bbbm));

    }

    public bool Delete(string TARGETTABLE)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from TIQU ");
      strSql.Append(" where TARGETTABLE=:TARGETTABLE ");
      OracleParameter[] parameters = {
					new OracleParameter(":TARGETTABLE", OracleDbType.Varchar2,20)			};
      parameters[0].Value = TARGETTABLE;

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

