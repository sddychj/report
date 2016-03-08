using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  /// <summary>
  /// ENCO_BBZD_DW:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ENCO_BBZD_DW
  {
    public ENCO_BBZD_DW()
    { }
    #region Model
    private string _zd;
    private string _dwbm;
    private string _cjr;
    private string _cjsj;
    private string _bbbm;
    /// <summary>
    /// 
    /// </summary>
    public string ZD
    {
      set { _zd = value; }
      get { return _zd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string CJR
    {
      set { _cjr = value; }
      get { return _cjr; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string CJSJ
    {
      set { _cjsj = value; }
      get { return _cjsj; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string BBBM
    {
      set { _bbbm = value; }
      get { return _bbbm; }
    }
    #endregion Model

  }
}
