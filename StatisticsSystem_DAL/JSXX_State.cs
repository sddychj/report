using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.DAL
{
  public class JSXX_State
  {
    public bool Update()
    {
      string sql = "update jsxx_state set isupdate='true'";
      int rows = DBUtilityOdp.DbHelperOra.ExecuteSql(sql);
      if (rows > 0)
      { return true; }
      else
      { return false; }
    }
  }
}
