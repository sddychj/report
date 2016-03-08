using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class ExcelExport
  {
    private readonly StatisticsSystem.DAL.ExcelExport dal = new StatisticsSystem.DAL.ExcelExport();

    public bool Update(string sql)
    {
      return dal.Update(sql);
    }
    public bool Insert(string bbbm, string dwbm, string nf, string yf)
    {
      return dal.Insert(bbbm, dwbm, nf, yf);
    }
  }
}
