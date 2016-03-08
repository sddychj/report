using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class ENCO_JSXXYSJ_List
  {
    private readonly StatisticsSystem.DAL.ENCO_JSXXYSJ_List dal = new StatisticsSystem.DAL.ENCO_JSXXYSJ_List();
    public ENCO_JSXXYSJ_List() { }
    public bool Add(StatisticsSystem.Model.ENCO_JSXXYSJ_List model)
    {
      return dal.Add(model);
    }
    public bool Delete(Model.ENCO_JSXXYSJ_List model)
    {

      return dal.Delete(model);
    }
  }
}
