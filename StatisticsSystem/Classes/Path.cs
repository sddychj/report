using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace StatisticsSystem.Classes
{
  public class Path
  {
    /// <summary>
    /// 获取当前路径
    /// </summary>
    /// <returns></returns>
    public static string GetPath(string version)
    {
      string path = Application.StartupPath + "\\webgridheader_" + version + ".xml";
      return path;
    }
  }
}
