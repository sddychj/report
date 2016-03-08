using System;
using System.Data;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using DBUtilityOdp;
using System.Data;
using System.Collections.Generic;

namespace StatisticsSystem.DAL
{
  /// <summary>
  /// 数据访问类:ENCO_JSXX
  /// </summary>
  public partial class ENCO_JSXX
  {
    public ENCO_JSXX()
    { }
    #region  BasicMethod

    /// <summary>
    /// 是否存在该记录
    /// </summary>
    public bool Exists(decimal JSXXID)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select count(1) from ENCO_JSXX");
      strSql.Append(" where JSXXID=:JSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = JSXXID;

      return DbHelperOra.Exists(strSql.ToString(), parameters);
    }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_JSXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("insert into ENCO_JSXX(");
      strSql.Append("JSXXID,BBBM,ZBBM,ZD,JSMS,JSSX,DWBM,NF,YF,SFKDW,SFKB,SFTZ)");
      strSql.Append(" values (");
      strSql.Append(":JSXXID,:BBBM,:ZBBM,:ZD,:JSMS,:JSSX,:DWBM,:NF,:YF,:SFKDW,:SFKB,:SFTZ)");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10),
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":ZD", OracleDbType.Varchar2,30),
					new OracleParameter(":JSMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JSSX", OracleDbType.Double,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKDW", OracleDbType.Varchar2,50),
					new OracleParameter(":SFKB", OracleDbType.Varchar2,50),
					new OracleParameter(":SFTZ", OracleDbType.Varchar2,50)};
      parameters[0].Value = model.JSXXID;
      parameters[1].Value = model.BBBM;
      parameters[2].Value = model.ZBBM;
      parameters[3].Value = model.ZD;
      parameters[4].Value = model.JSMS;
      parameters[5].Value = model.JSSX;
      parameters[6].Value = model.DWBM;
      parameters[7].Value = model.NF;
      parameters[8].Value = model.YF;
      parameters[9].Value = model.SFKDW;
      parameters[10].Value = model.SFKB;
      parameters[11].Value = model.SFTZ;

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
    public bool Update(StatisticsSystem.Model.ENCO_JSXX model)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("update ENCO_JSXX set ");
      strSql.Append("BBBM=:BBBM,");
      strSql.Append("ZBBM=:ZBBM,");
      strSql.Append("ZD=:ZD,");
      strSql.Append("JSMS=:JSMS,");
      strSql.Append("JSSX=:JSSX,");
      strSql.Append("DWBM=:DWBM,");
      strSql.Append("NF=:NF,");
      strSql.Append("YF=:YF,");
      strSql.Append("SFKDW=:SFKDW,");
      strSql.Append("SFKB=:SFKB,");
      strSql.Append("SFTZ=:SFTZ");
      strSql.Append(" where JSXXID=:JSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":BBBM", OracleDbType.Varchar2,10),
					new OracleParameter(":ZBBM", OracleDbType.Varchar2,90),
					new OracleParameter(":ZD", OracleDbType.Varchar2,30),
					new OracleParameter(":JSMS", OracleDbType.Varchar2,100),
					new OracleParameter(":JSSX", OracleDbType.Double,10),
					new OracleParameter(":DWBM", OracleDbType.Varchar2,20),
					new OracleParameter(":NF", OracleDbType.Varchar2,20),
					new OracleParameter(":YF", OracleDbType.Varchar2,20),
					new OracleParameter(":SFKDW", OracleDbType.Varchar2,50),
					new OracleParameter(":SFKB", OracleDbType.Varchar2,50),
					new OracleParameter(":SFTZ", OracleDbType.Varchar2,50),
					new OracleParameter(":JSXXID", OracleDbType.Double,10)};
      parameters[0].Value = model.BBBM;
      parameters[1].Value = model.ZBBM;
      parameters[2].Value = model.ZD;
      parameters[3].Value = model.JSMS;
      parameters[4].Value = model.JSSX;
      parameters[5].Value = model.DWBM;
      parameters[6].Value = model.NF;
      parameters[7].Value = model.YF;
      parameters[8].Value = model.SFKDW;
      parameters[9].Value = model.SFKB;
      parameters[10].Value = model.SFTZ;
      parameters[11].Value = model.JSXXID;

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
    public bool Delete(decimal JSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_JSXX ");
      strSql.Append(" where JSXXID=:JSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = JSXXID;

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
    public bool DeleteList(string JSXXIDlist)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_JSXX ");
      strSql.Append(" where JSXXID in (" + JSXXIDlist + ")  ");
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
    public StatisticsSystem.Model.ENCO_JSXX GetModel(decimal JSXXID)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JSXXID,BBBM,ZBBM,ZD,JSMS,JSSX,DWBM,NF,YF,SFKDW,SFKB,SFTZ from ENCO_JSXX ");
      strSql.Append(" where JSXXID=:JSXXID ");
      OracleParameter[] parameters = {
					new OracleParameter(":JSXXID", OracleDbType.Double,10)			};
      parameters[0].Value = JSXXID;

      StatisticsSystem.Model.ENCO_JSXX model = new StatisticsSystem.Model.ENCO_JSXX();
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
    public StatisticsSystem.Model.ENCO_JSXX DataRowToModel(DataRow row)
    {
      StatisticsSystem.Model.ENCO_JSXX model = new StatisticsSystem.Model.ENCO_JSXX();
      if (row != null)
      {
        if (row["JSXXID"] != null && row["JSXXID"].ToString() != "")
        {
          model.JSXXID = decimal.Parse(row["JSXXID"].ToString());
        }
        if (row["BBBM"] != null)
        {
          model.BBBM = row["BBBM"].ToString();
        }
        if (row["ZBBM"] != null)
        {
          model.ZBBM = row["ZBBM"].ToString();
        }
        if (row["ZD"] != null)
        {
          model.ZD = row["ZD"].ToString();
        }
        if (row["JSMS"] != null)
        {
          model.JSMS = row["JSMS"].ToString();
        }
        if (row["JSSX"] != null && row["JSSX"].ToString() != "")
        {
          model.JSSX = decimal.Parse(row["JSSX"].ToString());
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
        if (row["SFKDW"] != null)
        {
          model.SFKDW = row["SFKDW"].ToString();
        }
        if (row["SFKB"] != null)
        {
          model.SFKB = row["SFKB"].ToString();
        }
        if (row["SFTZ"] != null)
        {
          model.SFTZ = row["SFTZ"].ToString();
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
      strSql.Append("select JSXXID,BBBM,ZBBM,ZD,JSMS,JSSX,DWBM,NF,YF,SFKDW,SFKB,SFTZ ");
      strSql.Append(" FROM ENCO_JSXX ");
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
      strSql.Append("select count(1) FROM ENCO_JSXX ");
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
        strSql.Append("order by T.JSXXID desc");
      }
      strSql.Append(")AS Row, T.*  from ENCO_JSXX T ");
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
      parameters[0].Value = "ENCO_JSXX";
      parameters[1].Value = "JSXXID";
      parameters[2].Value = PageSize;
      parameters[3].Value = PageIndex;
      parameters[4].Value = 0;
      parameters[5].Value = 0;
      parameters[6].Value = strWhere;	
      return DbHelperOra.RunProcedure("UP_GetRecordByPage",parameters,"ds");
    }*/

    #endregion  BasicMethod
    #region  ExtensionMethod
    public Dictionary<string, Model.ENCO_JSXX> GetJSXXHash(string BBBM, string year, string month, string dwbm)
    {
      Dictionary<string, Model.ENCO_JSXX> jsxx = new Dictionary<string, Model.ENCO_JSXX>();
      string sql = "select * from enco_jsxx where bbbm=:0 ";
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30)	};
      parameters[0].Value = BBBM;
      if (year == "")
      { sql += " and (nf is null or nf='') "; }
      else
      { sql += " and nf='" + year + "'"; }
      if (month == "")
      { sql += " and (yf is null or yf='') "; }
      else
      { sql += " and yf = '" + month + "'"; }
      if (dwbm == "")
      { sql += " and (dwbm is null or dwbm='') "; }
      else
      { sql += " and dwbm='" + dwbm + "' "; }
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, parameters);
      string key;
      Model.ENCO_JSXX model = new Model.ENCO_JSXX();
      while (dr.Read())
      {
        key = dr["bbbm"].ToString() + "|" + dr["zbbm"] + "|" + dr["zd"].ToString() + "";
        model = new Model.ENCO_JSXX();
        model.JSXXID = int.Parse(dr["jsxxid"].ToString());
        model.BBBM = dr["bbbm"].ToString();
        model.ZBBM = dr["zbbm"].ToString();
        model.ZD = dr["zd"].ToString();
        model.JSMS = dr["jsms"].ToString();
        jsxx.Add(key, model);
      }
      dr.Close();
      return jsxx;
    }

    public StatisticsSystem.Model.ENCO_JSXX GetModel(string bbbm, string zbbm, string zd)
    {
      StringBuilder strSql = new StringBuilder();
      strSql.Append("select JSXXID,BBBM,ZBBM,ZD,JSMS,JSSX,DWBM,NF,YF,SFKDW,SFKB,SFTZ from ENCO_JSXX ");
      strSql.Append(" where bbbm=:0 and zbbm=:1 and zd=:2 ");
      OracleParameter[] parameters = {
					new OracleParameter(":0", OracleDbType.Varchar2,30),
					new OracleParameter(":1", OracleDbType.Varchar2,30),
					new OracleParameter(":2", OracleDbType.Varchar2,30)		};
      parameters[0].Value = bbbm;
      parameters[1].Value = zbbm;
      parameters[2].Value = zd;

      StatisticsSystem.Model.ENCO_JSXX model = new StatisticsSystem.Model.ENCO_JSXX();
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

    public int GetJSXXID()
    {
      int jsxxid = 0;
      string sql = "select decode(max(jsxxid),null,0,max(jsxxid)) id from enco_jsxx";
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql);
      if (dr.Read())
      {
        jsxxid = Convert.ToInt32(dr["id"].ToString()) + 1;
      }
      dr.Close();
      return jsxxid;
    }

    public bool Delete_BBBM(string bbbm)
    {

      StringBuilder strSql = new StringBuilder();
      strSql.Append("delete from ENCO_JSXX ");
      strSql.Append(" where bbbm=:bbbm ");
      OracleParameter[] parameters = {
					new OracleParameter(":bbbm", OracleDbType.Varchar2)			};
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

    public DataSet GetYear()
    {
      string sql = "select distinct nf NF from enco_jsxx order by nf desc ";
      DataSet ds = DbHelperOra.Query(sql);
      for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
      {
        string nf = ds.Tables[0].Rows[i]["nf"].ToString();
        if (nf != "" && nf.Substring(0, 1) == "[")
        {
          ds.Tables[0].Rows[i]["nf"] = nf.Trim("[]".ToCharArray());
        }
      }
      return ds;
    }

    public bool CreateLockcell(string year, string bbbm)
    {
      OracleParameter[] parameters ={
　　     new OracleParameter("v_nf",OracleDbType.Varchar2,10),
            new OracleParameter("v_bbbm",OracleDbType.Varchar2,20)
　　      };
      parameters[0].Value = year;
      parameters[1].Value = bbbm;
      try
      {
        OracleDataReader odr = DbHelperOra.RunProcedure("p_lockcell", parameters);
        odr.Close();
        return true;
      }
      catch
      {
        return false;
      }

    }

    public string CrossQuote(Model.ENCO_JSXXYSJ model1)
    {
      string flag = "";
      OracleParameter[] parameters ={
            new OracleParameter("v_bbbm",OracleDbType.Varchar2,20),
            new OracleParameter("v_zbbm",OracleDbType.Varchar2,20),
            new OracleParameter("v_zd",OracleDbType.Varchar2,20),
            new OracleParameter("v_dwbm",OracleDbType.Varchar2,20),
　　        new OracleParameter("v_nf",OracleDbType.Varchar2,10),
            new OracleParameter("v_yf",OracleDbType.Varchar2,20),
            new OracleParameter("v_flag",OracleDbType.Clob),
            new OracleParameter("cl_1",OracleDbType.Clob)
　　      };
      parameters[0].Value = model1.OBBBM;
      parameters[1].Value = model1.OZBBM;
      parameters[2].Value = model1.OZD;
      parameters[3].Value = model1.ODWBM;
      parameters[4].Value = model1.ONF;
      parameters[5].Value = model1.OYF;
      parameters[6].Value = flag;
      parameters[6].Direction = ParameterDirection.InputOutput;
      parameters[7].Value = "";
      parameters[7].Direction = ParameterDirection.InputOutput;
      try
      {
        OracleDataReader odr = DbHelperOra.RunProcedure("p_check_formula_down", parameters);
        flag = ((Oracle.DataAccess.Types.OracleClob)(parameters[6].Value)).Value.ToString();
        odr.Close();
        return flag;
      }
      catch
      {
        return "";
      }

    }
    #endregion  ExtensionMethod
  }
}

