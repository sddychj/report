using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

namespace StatisticsSystem.BLL
{
  public class DWBMB
  {
    private readonly StatisticsSystem.DAL.DWBMB dal = new StatisticsSystem.DAL.DWBMB();

    public Dictionary<string, string> GetDic()
    {
      return dal.GetDic();
    }

    public DataSet GetList(string strWhere)
    {
      DataSet ds = dal.GetList(strWhere);
      DataRow dr = ds.Tables[0].NewRow();
      dr["dwbm"] = "";
      dr["dwmc"] = "";
      ds.Tables[0].Rows.InsertAt(dr, 0);
      return ds;
    }
    public DataSet GetList_xssx(string strWhere)
    {
      DataSet ds = dal.GetList_xssx();
      DataRow dr = ds.Tables[0].NewRow();
      dr["dwbm"] = "";
      dr["dwmc"] = "";
      ds.Tables[0].Rows.InsertAt(dr, 0);
      return ds;
    }

    public Dictionary<string, string> GetDicDWMC()
    {
      return dal.GetDicDWMC();
    }

    public string GetDW(string userid)
    {
      return dal.GetDW(userid);
    }
  }
}
