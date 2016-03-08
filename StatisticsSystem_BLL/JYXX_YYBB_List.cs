using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class JYXX_YYBB_List
  {
    private readonly StatisticsSystem.DAL.JYXX_YYBB_List dal = new DAL.JYXX_YYBB_List();
    public JYXX_YYBB_List()
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
