using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.BLL
{
  public class login
  {
    private readonly StatisticsSystem.DAL.login dal = new StatisticsSystem.DAL.login();
    public login()
    { }

    public bool checklogin(string username, string password)
    {
      return dal.checklogin(username, password);
    }

    public bool update(string username, string password)
    {
      return dal.update(username, password);
    }
    public string GetUserid(string loginname)
    {
      return dal.GetUSERID(loginname);
    }
  }
}
