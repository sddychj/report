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
  /// 数据访问类:CODE_BBBMB
  /// </summary>
  public partial class CODE_BBBMB
  {
    public CODE_BBBMB()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from CODE_BBBMB");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)			};
      parameters[0].Value = BBBM;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.CODE_BBBMB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into CODE_BBBMB(");
      strSql.Append("BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX,ROWCOUNT,COLUMNCOUNT,CAPTION,COORDINATES)");
      strSql.Append(" values (");
      strSql.Append(":BBBM,:BBMC,:BBWH,:BBZQ,:YQSBSJ,:BBLX,:DQZT,:PXXH,:CGZZSX,:LS,:PLFX,:ROWCOUNT,:COLUMNCOUNT,:CAPTION,:COORDINATES)");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30),
					new OracleParameter(":BBMC", OracleDbType.Varchar2,100),
					new OracleParameter(":BBWH", OracleDbType.Varchar2,30),
					new OracleParameter(":BBZQ", OracleDbType.Varchar2,20),
					new OracleParameter(":YQSBSJ", OracleDbType.Varchar2,50),
					new OracleParameter(":BBLX", OracleDbType.Varchar2,20),
					new OracleParameter(":DQZT", OracleDbType.Varchar2,20),
					new OracleParameter(":PXXH", OracleDbType.Double,6),
					new OracleParameter(":CGZZSX", OracleDbType.Varchar2,20),
					new OracleParameter(":LS", OracleDbType.Double,3),
					new OracleParameter(":PLFX", OracleDbType.Varchar2,20),
					new OracleParameter(":ROWCOUNT", OracleDbType.Double,10),
					new OracleParameter(":COLUMNCOUNT", OracleDbType.Double,10),
					new OracleParameter(":CAPTION", OracleDbType.Varchar2,500),
					new OracleParameter(":COORDINATES", OracleDbType.Varchar2,500)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.BBMC;
      parameters[2].Value = model.BBWH;
      parameters[3].Value = model.BBZQ;
      parameters[4].Value = model.YQSBSJ;
      parameters[5].Value = model.BBLX;
      parameters[6].Value = model.DQZT;
      parameters[7].Value = model.PXXH;
      parameters[8].Value = model.CGZZSX;
      parameters[9].Value = model.LS;
      parameters[10].Value = model.PLFX;
      parameters[11].Value = model.ROWCOUNT;
      parameters[12].Value = model.COLUMNCOUNT;
      parameters[13].Value = model.CAPTION;
      parameters[14].Value = model.COORDINATES;

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
    public bool Update(StatisticsSystem.Model.CODE_BBBMB model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update CODE_BBBMB set ");
      strSql.Append("BBMC=:BBMC,");
      strSql.Append("BBWH=:BBWH,");
      strSql.Append("BBZQ=:BBZQ,");
      strSql.Append("YQSBSJ=:YQSBSJ,");
      strSql.Append("BBLX=:BBLX,");
      strSql.Append("DQZT=:DQZT,");
      strSql.Append("PXXH=:PXXH,");
      strSql.Append("CGZZSX=:CGZZSX,");
      strSql.Append("LS=:LS,");
      strSql.Append("PLFX=:PLFX,");
      strSql.Append("ROWCOUNT=:ROWCOUNT,");
      strSql.Append("COLUMNCOUNT=:COLUMNCOUNT,");
      strSql.Append("CAPTION=:CAPTION,");
      strSql.Append("COORDINATES=:COORDINATES");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBMC", OracleDbType.Varchar2,100),
					new OracleParameter(":BBWH", OracleDbType.Varchar2,30),
					new OracleParameter(":BBZQ", OracleDbType.Varchar2,20),
					new OracleParameter(":YQSBSJ", OracleDbType.Varchar2,50),
					new OracleParameter(":BBLX", OracleDbType.Varchar2,20),
					new OracleParameter(":DQZT", OracleDbType.Varchar2,20),
					new OracleParameter(":PXXH", OracleDbType.Double,6),
					new OracleParameter(":CGZZSX", OracleDbType.Varchar2,20),
					new OracleParameter(":LS", OracleDbType.Double,3),
					new OracleParameter(":PLFX", OracleDbType.Varchar2,20),
					new OracleParameter(":ROWCOUNT", OracleDbType.Double,10),
					new OracleParameter(":COLUMNCOUNT", OracleDbType.Double,10),
					new OracleParameter(":CAPTION", OracleDbType.Varchar2,500),
					new OracleParameter(":COORDINATES", OracleDbType.Varchar2,500),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)};
      parameters[0].Value = model.BBMC;
      parameters[1].Value = model.BBWH;
      parameters[2].Value = model.BBZQ;
      parameters[3].Value = model.YQSBSJ;
      parameters[4].Value = model.BBLX;
      parameters[5].Value = model.DQZT;
      parameters[6].Value = model.PXXH;
      parameters[7].Value = model.CGZZSX;
      parameters[8].Value = model.LS;
      parameters[9].Value = model.PLFX;
      parameters[10].Value = model.ROWCOUNT;
      parameters[11].Value = model.COLUMNCOUNT;
      parameters[12].Value = model.CAPTION;
      parameters[13].Value = model.COORDINATES;
      parameters[14].Value = model.BBBM;

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
    public bool Delete(string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from CODE_BBBMB ");
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
    /// <summary>
    /// 批量删除数据
    /// </summary>
    public bool DeleteList(string BBBMlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from CODE_BBBMB ");
      strSql.Append(" where BBBM in (" + BBBMlist + ")  ");
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
    public StatisticsSystem.Model.CODE_BBBMB GetModel(string BBBM)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX,ROWCOUNT,COLUMNCOUNT,CAPTION,COORDINATES from CODE_BBBMB ");
      strSql.Append(" where BBBM=:BBBM ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,30)			};
      parameters[0].Value = BBBM;

      StatisticsSystem.Model.CODE_BBBMB model = new StatisticsSystem.Model.CODE_BBBMB();
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
    public StatisticsSystem.Model.CODE_BBBMB DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.CODE_BBBMB model = new StatisticsSystem.Model.CODE_BBBMB();
      if (row != null)
      {
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["BBMC"] != null)
        {
          model.BBMC = row["BBMC"].ToString();
        }
        if (row["BBWH"] != null)
        {
          model.BBWH = row["BBWH"].ToString();
        }
        if (row["BBZQ"] != null)
        {
          model.BBZQ = row["BBZQ"].ToString();
        }
        if (row["YQSBSJ"] != null)
        {
          model.YQSBSJ = row["YQSBSJ"].ToString();
        }
        if (row["BBLX"] != null)
        {
          model.BBLX = row["BBLX"].ToString();
        }
        if (row["DQZT"] != null)
        {
          model.DQZT = row["DQZT"].ToString();
        }
        if (row["PXXH"] != null && row["PXXH"].ToString() != "")
        {
          model.PXXH = decimal.Parse(row["PXXH"].ToString());
        }
        if (row["CGZZSX"] != null)
        {
          model.CGZZSX = row["CGZZSX"].ToString();
        }
        if (row["LS"] != null && row["LS"].ToString() != "")
        {
          model.LS = decimal.Parse(row["LS"].ToString());
        }
        if (row["PLFX"] != null)
        {
          model.PLFX = row["PLFX"].ToString();
        }
        //if (row["ROWCOUNT"] != null)
        //{
        //  model.ROWCOUNT =Int32.Parse(row["ROWCOUNT"].ToString());
        //}
        //if (row["COLUMNCOUNT"] != null)
        //{
        //  model.COLUMNCOUNT =Int32.Parse(row["COLUMNCOUNT"].ToString());
        //}
        if (row["CAPTION"] != null)
        {
          model.CAPTION = row["CAPTION"].ToString();
        }
        if (row["COORDINATES"] != null)
        {
          model.COORDINATES = row["COORDINATES"].ToString();
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
      strSql.Append("select BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX,bbwh||bbmc bbwhmc ");
      strSql.Append(" FROM CODE_BBBMB ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(" where " + strWhere);
      }
      strSql.Append(" order by pxxh");
      return DbHelperOra.Query(strSql.ToString());
    }

    /// <summary>
    /// 获取记录总数
    /// </summary>
    public int GetRecordCount(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) FROM CODE_BBBMB ");
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
      strSql.Append(")AS Row, T.*  from CODE_BBBMB T ");
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
      parameters[0].Value = "CODE_BBBMB";
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
    public DataSet GetList_BBBM(string BBBM)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX ");
      strSql.Append(" FROM CODE_BBBMB  where BBBM=:0");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30)		};
      parameters[0].Value = BBBM;
      return DbHelperOra.Query(strSql.ToString(), parameters);
    }

    public Dictionary<string, string> GetDic()
    {
      Dictionary<string, string> dic = new Dictionary<string, string>();
      string sql = "select * from code_bbbmb";
      OracleDataReader dr = DBUtilityOdp.DbHelperOra.ExecuteReader(sql);
      while (dr.Read())
      {
        dic.Add(dr["bbwh"].ToString(), dr["bbbm"].ToString());
      }
      dr.Close();
      return dic;
    }

    public DataSet GetList_BBLX(string strWhere)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX,b.LBMC ");
      strSql.Append(" FROM CODE_BBBMB a,enco_bblx b where a.bblx=b.id ");
      if (strWhere.Trim() != "")
      {
        strSql.Append(strWhere);
      }
      strSql.Append(" order by b.id,a.pxxh");
      return DbHelperOra.Query(strSql.ToString());
    }

    public int GetMaxBBBM()
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select max(to_number(substr(bbbm,3,4))) from code_bbbmb t ");
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

    public int GetMaxXH()
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select decode(max(pxxh),null,1,max(pxxh)+1) from code_bbbmb t ");
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

    //获取报表列表，本单位创建的，报表类型
    public DataSet GetList_BBLX_DW(string dw, string bblx)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select a.BBBM,BBMC,BBWH,BBZQ,YQSBSJ,BBLX,DQZT,PXXH,CGZZSX,LS,PLFX ");
      strSql.Append(" FROM CODE_BBBMB a,bbdytbdw b  where a.bbbm=b.bbbm and a.bblx=:0 and b.dwbm=:1 order by a.pxxh");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30)	,
					new OracleParameter(":1", OracleDbType.Varchar2,30)			};
      parameters[0].Value = bblx;
      parameters[1].Value = dw;
      return DbHelperOra.Query(strSql.ToString(), parameters);
    }
    #endregion  ExtensionMethod
  }
}
