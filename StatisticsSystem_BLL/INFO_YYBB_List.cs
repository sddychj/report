using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class INFO_YYBB_List
  {
    private readonly StatisticsSystem.DAL.INFO_YYBB_List dal = new DAL.INFO_YYBB_List();
    public INFO_YYBB_List()
    { }


    /// <summary>
    /// 增加一条数据
    /// </summary>
    public bool Add(StatisticsSystem.Model.INFO_YYBB_List model)
    {
      return dal.Add(model);
    }
  }
}
