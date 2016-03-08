using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class ENCO_JSXX_List
  {
    private readonly StatisticsSystem.DAL.ENCO_JSXX_List dal = new StatisticsSystem.DAL.ENCO_JSXX_List();
    public ENCO_JSXX_List() { }

    public bool Add(StatisticsSystem.Model.ENCO_JSXX_List model)
    {
      return dal.Add(model);
    }

    public bool Delete(StatisticsSystem.Model.ENCO_JSXX_List model)
    {
      return dal.Delete(model);
    }
  }
}
