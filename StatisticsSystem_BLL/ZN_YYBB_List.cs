using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
 public class ZN_YYBB_List
  {
   private readonly StatisticsSystem.DAL.ZN_YYBB_List dal = new DAL.ZN_YYBB_List();
    public ZN_YYBB_List()
    { }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.ZN_YYBB_List model)
    {
      return dal.Add(model);
    }
  }
}
