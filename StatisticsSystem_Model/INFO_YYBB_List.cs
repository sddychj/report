using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  public partial class INFO_YYBB_List
  {
    public INFO_YYBB_List()
    { }
    public INFO_YYBB_List(int length)
    {
      _bbbm = new string[length];
      _yybbbm = new string[length];
    }
    #region Model
    private string[] _bbbm;
    private string[] _yybbbm;
    /// <summary>
    /// 
    /// </summary>
    public string[] BBBM
    {
      set { _bbbm = value; }
      get { return _bbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] YYBBBM
    {
      set { _yybbbm = value; }
      get { return _yybbbm; }
    }
    #endregion Model
  }
}
