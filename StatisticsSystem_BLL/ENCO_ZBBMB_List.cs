using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public partial class ENCO_ZBBMB_List
  {
    private readonly StatisticsSystem.DAL.ENCO_ZBBMB_List dal = new StatisticsSystem.DAL.ENCO_ZBBMB_List();
    public ENCO_ZBBMB_List()
    { }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool update(StatisticsSystem.Model.ENCO_ZBBMB_List model)
    {
      return dal.update(model);
    }
    public bool Add(StatisticsSystem.Model.ENCO_ZBBMB_List model)
    {
      return dal.Add(model);
    }
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }
    public Model.ENCO_ZBBMB_List query(string bbbm)
    {
      return dal.query(bbbm);
    }
  }
}
