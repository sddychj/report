using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  public partial class ENCO_ZBBMB_DW_List
  {
    public ENCO_ZBBMB_DW_List()
    { }
    public ENCO_ZBBMB_DW_List(int length)
    {
      _zbbm = new string[length];
      _dwbm = new string[length];
    }
    #region Model
    private string[] _zbbm;
    private string[] _dwbm;
    /// <summary>
    /// 
    /// </summary>
    public string[] ZBBM
    {
      set { _zbbm = value; }
      get { return _zbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    #endregion Model
  }
}
