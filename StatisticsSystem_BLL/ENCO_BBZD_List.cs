using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class ENCO_BBZD_List
  {
    private readonly StatisticsSystem.DAL.ENCO_BBZD_List dal = new StatisticsSystem.DAL.ENCO_BBZD_List();
    public ENCO_BBZD_List()
    { }

    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ENCO_BBZD_List model)
    {
      return dal.Add(model);
    }
    public bool Delete(string BBBM)
    {

      return dal.Delete(BBBM);
    }
    public Model.ENCO_BBZD_List query(string bbbm)
    {
      return dal.Query(bbbm);
    }
  }
}
