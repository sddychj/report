using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// ENCO_ZBBMB_DW:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ENCO_ZBBMB_DW
  {
    public ENCO_ZBBMB_DW()
    { }
    #region Model
    private string _zbbm;
    private string _dwbm;
    /// <summary>
    /// 
    /// </summary>
    public string ZBBM
    {
      set { _zbbm = value; }
      get { return _zbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    #endregion Model

  }
}

