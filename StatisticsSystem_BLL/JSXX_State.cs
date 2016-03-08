using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
 
  public class JSXX_State
  {
    private readonly DAL.JSXX_State dal = new DAL.JSXX_State();
    public bool Update()
    {
      return dal.Update();
    }
  }
}
