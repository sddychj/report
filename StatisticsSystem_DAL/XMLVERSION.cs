using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:XMLVERSION
  /// </summary>
  public partial class XMLVERSION
  {
    public XMLVERSION()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal YEAR, string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from XMLVERSION");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.XMLVERSION model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into XMLVERSION(");
      strSql.Append("YEAR,BBBM,CAPTION,COORDINATES,HIDDENCOLUMN,HIDDENROW,NOTALLOWEDITROW,LOCKCELL,COLUMNWIDTH,NAMEHIERARCHY,SELECTFIELD,ORDERBY,ROWCOUNT,COLUMNCOUNT,NotAllowEditColumn,title)");
      strSql.Append(" values (");
      strSql.Append(":YEAR,:BBBM,:CAPTION,:COORDINATES,:HIDDENCOLUMN,:HIDDENROW,:NOTALLOWEDITROW,:LOCKCELL,:COLUMNWIDTH,:NAMEHIERARCHY,:SELECTFIELD,:ORDERBY,:ROWCOUNT,:COLUMNCOUNT,:NotAllowEditColumn,:title)");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100),
					new OracleParameter(":CAPTION", OracleDbType.Varchar2,4000),
					new OracleParameter(":COORDINATES", OracleDbType.Varchar2,4000),
					new OracleParameter(":HIDDENCOLUMN", OracleDbType.Varchar2,500),
					new OracleParameter(":HIDDENROW", OracleDbType.Clob),
					new OracleParameter(":NOTALLOWEDITROW", OracleDbType.Varchar2,500),
					new OracleParameter(":LOCKCELL", OracleDbType.Clob),
					new OracleParameter(":COLUMNWIDTH", OracleDbType.Varchar2,500),
					new OracleParameter(":NAMEHIERARCHY", OracleDbType.Varchar2,500),
					new OracleParameter(":SELECTFIELD", OracleDbType.Varchar2,500),
					new OracleParameter(":ORDERBY", OracleDbType.Varchar2,500),
                                     new OracleParameter(":ROWCOUNT",OracleDbType.Int32),                                     
                                     new OracleParameter(":COLUMNCOUNT",OracleDbType.Int32),
                                     new OracleParameter(":NotAllowEditColumn",OracleDbType.Varchar2,500),
                                     new OracleParameter(":title",OracleDbType.Varchar2,500)};
      parameters[0].Value = model.YEAR;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.CAPTION;
      parameters[3].Value = model.COORDINATES;
      parameters[4].Value = model.HIDDENCOLUMN;
      parameters[5].Value = model.HIDDENROW;
      parameters[6].Value = model.NOTALLOWEDITROW;
      parameters[7].Value = model.LOCKCELL;
      parameters[8].Value = model.COLUMNWIDTH;
      parameters[9].Value = model.NAMEHIERARCHY;
      parameters[10].Value = model.SELECTFIELD;
      parameters[11].Value = model.ORDERBY;
      parameters[12].Value = model.ROWCOUNT;
      parameters[13].Value = model.COLUMNCOUNT;
      parameters[14].Value = model.NotAllowEditColumn;
      parameters[15].Value = model.Title;

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
    public bool Update(StatisticsSystem.Model.XMLVERSION model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update XMLVERSION set ");
      strSql.Append("CAPTION=:CAPTION,");
      strSql.Append("COORDINATES=:COORDINATES,");
      strSql.Append("HIDDENCOLUMN=:HIDDENCOLUMN,");
      strSql.Append("HIDDENROW=:HIDDENROW,");
      strSql.Append("NOTALLOWEDITROW=:NOTALLOWEDITROW,");
      strSql.Append("LOCKCELL=:LOCKCELL, ");
      strSql.Append("COLUMNWIDTH=:COLUMNWIDTH,");
      strSql.Append("NAMEHIERARCHY=:NAMEHIERARCHY,");
      strSql.Append("SELECTFIELD=:SELECTFIELD,");
      strSql.Append("ORDERBY=:ORDERBY,");
      strSql.Append("ROWCOUNT=:ROWCOUNT,");
      strSql.Append("COLUMNCOUNT=:COLUMNCOUNT,");
      strSql.Append("NotAllowEditColumn=:NotAllowEditColumn,");
      strSql.Append("title=:title ");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM ");
      OracleParameter[] parameters = {
          new OracleParameter(":CAPTION", OracleDbType.Varchar2,500),
          new OracleParameter(":COORDINATES", OracleDbType.Varchar2,4000),
          new OracleParameter(":HIDDENCOLUMN", OracleDbType.Varchar2,4000),
          new OracleParameter(":HIDDENROW", OracleDbType.Clob),
          new OracleParameter(":NOTALLOWEDITROW", OracleDbType.Varchar2,500),
          new OracleParameter(":LOCKCELL", OracleDbType.Clob),
          new OracleParameter(":COLUMNWIDTH", OracleDbType.Varchar2,500),
          new OracleParameter(":NAMEHIERARCHY", OracleDbType.Varchar2,500),
          new OracleParameter(":SELECTFIELD", OracleDbType.Varchar2,500),
          new OracleParameter(":ORDERBY", OracleDbType.Varchar2,500),
                                     new OracleParameter(":ROWCOUNT",OracleDbType.Int32),                                     
                                     new OracleParameter(":COLUMNCOUNT",OracleDbType.Int32),
                                     new OracleParameter(":NotAllowEditColumn",OracleDbType.Varchar2,500),
                                     new OracleParameter(":title",OracleDbType.Varchar2,500),
          new OracleParameter(":YEAR", OracleDbType.Int32),
          new OracleParameter(":BBBM", OracleDbType.Varchar2,100)};
      parameters[0].Value = model.CAPTION;
      parameters[1].Value = model.COORDINATES;
      parameters[2].Value = model.HIDDENCOLUMN;
      parameters[3].Value = model.HIDDENROW;
      parameters[4].Value = model.NOTALLOWEDITROW;
      parameters[5].Value = model.LOCKCELL;
      parameters[6].Value = model.COLUMNWIDTH;
      parameters[7].Value = model.NAMEHIERARCHY;
      parameters[8].Value = model.SELECTFIELD;
      parameters[9].Value = model.ORDERBY;
      parameters[10].Value = model.ROWCOUNT;
      parameters[11].Value = model.COLUMNCOUNT;
      parameters[12].Value = model.NotAllowEditColumn;
      parameters[13].Value = model.Title;
      parameters[14].Value = model.YEAR;
      parameters[15].Value = model.BBBM;
      int rows = DbHelperOra.ExecuteSql(strSql.ToString(), parameters);
      //int rows = DbHelperOra.ExecuteSql(strSql.ToString());
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
    public bool Delete(decimal YEAR, string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from XMLVERSION ");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;

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
    public StatisticsSystem.Model.XMLVERSION GetModel(decimal YEAR, string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select YEAR,BBBM,CAPTION,COORDINATES,HIDDENCOLUMN,HIDDENROW,NOTALLOWEDITROW,LOCKCELL,COLUMNWIDTH,NAMEHIERARCHY,SELECTFIELD,ORDERBY,ROWCOUNT,COLUMNCOUNT,title,NOTALLOWEDITCOLUMN from XMLVERSION ");
      strSql.Append(" where YEAR=:YEAR and BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":YEAR", OracleDbType.Double,4),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,100)			};
      parameters[0].Value = YEAR;
      parameters[1].Value = BBBM;

      StatisticsSystem.Model.XMLVERSION model = new StatisticsSystem.Model.XMLVERSION();
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
    public StatisticsSystem.Model.XMLVERSION DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.XMLVERSION model = new StatisticsSystem.Model.XMLVERSION();
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
        if (row["CAPTION"] != null)
        {
          model.CAPTION = row["CAPTION"].ToString();
        }
        if (row["COORDINATES"] != null)
        {
          model.COORDINATES = row["COORDINATES"].ToString();
        }
        if (row["HIDDENCOLUMN"] != null)
        {
          model.HIDDENCOLUMN = row["HIDDENCOLUMN"].ToString();
        }
        if (row["HIDDENROW"] != null)
        {
          model.HIDDENROW = row["HIDDENROW"].ToString();
        }
        if (row["NOTALLOWEDITROW"] != null)
        {
          model.NOTALLOWEDITROW = row["NOTALLOWEDITROW"].ToString();
        }
        if (row["LOCKCELL"] != null)
        {
          model.LOCKCELL = row["LOCKCELL"].ToString();
        }
        if (row["COLUMNWIDTH"] != null)
        {
          model.COLUMNWIDTH = row["COLUMNWIDTH"].ToString();
        }
        if (row["NAMEHIERARCHY"] != null)
        {
          model.NAMEHIERARCHY = row["NAMEHIERARCHY"].ToString();
        }
        if (row["SELECTFIELD"] != null)
        {
          model.SELECTFIELD = row["SELECTFIELD"].ToString();
        }
        if (row["ORDERBY"] != null)
        {
          model.ORDERBY = row["ORDERBY"].ToString();
        }
        if (row["ROWCOUNT"] != null)
        {
          model.ROWCOUNT = int.Parse(row["ROWCOUNT"].ToString());
        }
        if (row["COLUMNCOUNT"] != null)
        {
          model.COLUMNCOUNT = int.Parse(row["COLUMNCOUNT"].ToString());
        }
        if (row["title"] != null)
        {
          model.Title = row["title"].ToString();
        }
        if (row["NOTALLOWEDITCOLUMN"] != null)
        {
          model.NotAllowEditColumn = row["NOTALLOWEDITCOLUMN"].ToString();
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
      strSql.Append("select YEAR,BBBM,CAPTION,COORDINATES,HIDDENCOLUMN,HIDDENROW,NOTALLOWEDITROW,LOCKCELL,COLUMNWIDTH,NAMEHIERARCHY,SELECTFIELD,ORDERBY,ROWCOUNT,COLUMNCOUNT,title,NOTALLOWEDITCOLUMN ");
      strSql.Append(" FROM XMLVERSION ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append(" order by bbbm");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM XMLVERSION ");
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
        strSql.Append("order by T.BBBM desc");
      }
      strSql.Append(")AS Row, T.*  from XMLVERSION T ");
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
      parameters[0].Value = "XMLVERSION";
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
    public DataSet GetMaxVersion()
    {
      string sql = "select max(year) year from xmlversion order by year desc";
      DataSet ds = DbHelperOra.Query(sql);
      return ds;
    }

    public DataSet GetListVersion()
    {
      string sql = "select distinct year year from xmlversion order by year desc";
      DataSet ds = DbHelperOra.Query(sql);
      return ds;
    }

    public bool CreateNewVersion(string version)
    {
      bool flag = false;
      StringBuilder sql = new StringBuilder();
      sql.Append("begin ");
      //sql.Append("delete from xmlversion where year=:0;");
      sql.Append(@"insert into  xmlversion (year,BBBM,CAPTION,COORDINATES,HIDDENCOLUMN,HIDDENROW,NOTALLOWEDITROW,COLUMNWIDTH,NAMEHIERARCHY,
       SELECTFIELD,ORDERBY,ROWCOUNT,COLUMNCOUNT,NOTALLOWEDITCOLUMN,TITLE,LOCKCELL) 
      select :0,BBBM,CAPTION,COORDINATES,HIDDENCOLUMN,HIDDENROW,NOTALLOWEDITROW,COLUMNWIDTH,NAMEHIERARCHY,
       SELECTFIELD,ORDERBY,ROWCOUNT,COLUMNCOUNT,NOTALLOWEDITCOLUMN,TITLE,LOCKCELL from xmlversion 
      where year=:0-1;");
      sql.Append("end;");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Double,4)			};
      parameters[0].Value = version;
      int rows = DbHelperOra.ExecuteSql(sql.ToString(), parameters);
      //if (rows > 0)
      flag = true;
      return flag;
    }

    //此版本是否可用
    public bool IsQY(string version)
    {
      bool flag = false;
      string sql = "select status from cs_version where version=:0";
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,20)			};
      parameters[0].Value = version;
      object status = DbHelperOra.GetSingle(sql, parameters);
      if (status != null)
      {
        if (status.ToString() == "启用")
        {
          flag = true;
        }
      }
      return flag;
    }
    #endregion  ExtensionMethod
  }
}

