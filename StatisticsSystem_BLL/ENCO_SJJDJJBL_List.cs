using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class ENCO_SJJDJJBL_List
  {
    private readonly StatisticsSystem.DAL.ENCO_SJJDJJBL_List dal = new StatisticsSystem.DAL.ENCO_SJJDJJBL_List();
    public ENCO_SJJDJJBL_List()
    { }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_SJJDJJBL_List model)
    {
      return dal.Add(model);
    }
    public bool update(StatisticsSystem.Model.ENCO_SJJDJJBL_List model)
    {
      return dal.update(model);
    }
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }
  }
}
