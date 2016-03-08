using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class JYXX_List
  {
    private readonly StatisticsSystem.DAL.JYXX_List dal = new DAL.JYXX_List();
    public JYXX_List()
    { }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXX_List model)
    {
      return dal.Add(model);
    }
  }
}
