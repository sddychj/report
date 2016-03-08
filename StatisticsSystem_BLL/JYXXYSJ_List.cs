using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class JYXXYSJ_List
  {
    private readonly StatisticsSystem.DAL.JYXXYSJ_List dal = new DAL.JYXXYSJ_List();
    public JYXXYSJ_List()
    { }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.JYXXYSJ_List model)
    {
      return dal.Add(model);
    }
  }
}
