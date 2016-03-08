using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  class ENCO_ZBBMB_DW_List
  {
    private readonly StatisticsSystem.DAL.ENCO_ZBBMB_DW_List dal = new StatisticsSystem.DAL.ENCO_ZBBMB_DW_List();
    public ENCO_ZBBMB_DW_List()
    { }
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB_DW_List model)
    {
      return dal.Add(model);
    }
  }
}
