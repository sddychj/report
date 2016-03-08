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
  /// 数据访问类:JYXX
  /// </summary>
  public partial class JYXX
  {
    public JYXX()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JYXXID)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from JYXX");
      strSql.Append(" where JYXXID=:JYXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8)			};
      parameters[0].Value = JYXXID;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into JYXX(");
      strSql.Append("JYXXID,BBBM,JYMC,JYMS,JYGX,JYSX,DWBM,NF,YF)");
      strSql.Append(" values (");
      strSql.Append(":JYXXID,:BBBM,:JYMC,:JYMS,:JYGX,:JYSX,:DWBM,:NF,:YF)");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":JYMC", OracleDbType.Varchar2,2000),
					new OracleParameter(":JYMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JYGX", OracleDbType.Varchar2,10),
					new OracleParameter(":JYSX", OracleDbType.Double,8),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20)};
      parameters[0].Value = model.JYXXID;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.JYMC;
      parameters[3].Value = model.JYMS;
      parameters[4].Value = model.JYGX;
      parameters[5].Value = model.JYSX;
      parameters[6].Value = model.DWBM;
      parameters[7].Value = model.NF;
      parameters[8].Value = model.YF;

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
    public bool Update(StatisticsSystem.Model.JYXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update JYXX set ");
      strSql.Append("BBBM=:BBBM,");
      strSql.Append("JYMC=:JYMC,");
      strSql.Append("JYMS=:JYMS,");
      strSql.Append("JYGX=:JYGX,");
      strSql.Append("JYSX=:JYSX,");
      strSql.Append("DWBM=:DWBM,");
      strSql.Append("NF=:NF,");
      strSql.Append("YF=:YF");
      strSql.Append(" where JYXXID=:JYXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":JYMC", OracleDbType.Varchar2,2000),
					new OracleParameter(":JYMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JYGX", OracleDbType.Varchar2,10),
					new OracleParameter(":JYSX", OracleDbType.Double,8),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20),
					new OracleParameter(":JYXXID", OracleDbType.Double,8)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.JYMC;
      parameters[2].Value = model.JYMS;
      parameters[3].Value = model.JYGX;
      parameters[4].Value = model.JYSX;
      parameters[5].Value = model.DWBM;
      parameters[6].Value = model.NF;
      parameters[7].Value = model.YF;
      parameters[8].Value = model.JYXXID;

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
    public bool Delete(decimal JYXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from JYXX ");
      strSql.Append(" where JYXXID=:JYXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8)			};
      parameters[0].Value = JYXXID;

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
    public bool DeleteList(string JYXXIDlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from JYXX ");
      strSql.Append(" where JYXXID in (" + JYXXIDlist + ")  ");
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
    public StatisticsSystem.Model.JYXX GetModel(decimal JYXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JYXXID,BBBM,JYMC,JYMS,JYGX,JYSX,DWBM,NF,YF from JYXX ");
      strSql.Append(" where JYXXID=:JYXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JYXXID", OracleDbType.Double,8)			};
      parameters[0].Value = JYXXID;

      StatisticsSystem.Model.JYXX model = new StatisticsSystem.Model.JYXX();
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
    public StatisticsSystem.Model.JYXX DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.JYXX model = new StatisticsSystem.Model.JYXX();
      if (row != null)
      {
        if (row["JYXXID"] != null && row["JYXXID"].ToString() != "")
        {
          model.JYXXID = decimal.Parse(row["JYXXID"].ToString());
        }
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["JYMC"] != null)
        {
          model.JYMC = row["JYMC"].ToString();
        }
        if (row["JYMS"] != null)
        {
          model.JYMS = row["JYMS"].ToString();
        }
        if (row["JYGX"] != null)
        {
          model.JYGX = row["JYGX"].ToString();
        }
        if (row["JYSX"] != null && row["JYSX"].ToString() != "")
        {
          model.JYSX = decimal.Parse(row["JYSX"].ToString());
        }
        if (row["DWBM"] != null)
        {
          model.DWBM = row["DWBM"].ToString();
        }
        if (row["NF"] != null)
        {
          model.NF = row["NF"].ToString();
        }
        if (row["YF"] != null)
        {
          model.YF = row["YF"].ToString();
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
      strSql.Append("select JYXXID,BBBM,JYMC,JYMS,JYGX,JYSX,DWBM,NF,YF ");
      strSql.Append(" FROM JYXX ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }

      strSql.Append(" order by jyxxid");
      return DbHelperOra.Query(strSql.ToString());
    }
    /// <summary>
    /// 
    /// </summary>
    public DataSet GetList_DW(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JYXXID,BBBM,JYMC,JYMS,JYGX,JYSX,a.DWBM,NF,YF,b.DWMC ");
      strSql.Append(" FROM JYXX a left join dwbmb b on a.dwbm=b.dwbm ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }

      strSql.Append(" order by jyxxid");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM JYXX ");
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
        strSql.Append("order by T.JYXXID desc");
      }
      strSql.Append(")AS Row, T.*  from JYXX T ");
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
      parameters[0].Value = "JYXX";
      parameters[1].Value = "JYXXID";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod

    public int GetMaxID()
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select decode(max(jyxxid),null,1,max(jyxxid)+1) FROM JYXX ");
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

