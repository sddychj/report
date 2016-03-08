using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// XMLVERSION_DW_LOCKCELL:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class XMLVERSION_DW_LOCKCELL
  {
    public XMLVERSION_DW_LOCKCELL()
    { }
    #region Model
    private decimal _year;
    private string _bbbm;
    private string _lockcell;
    private string _dwbm;
    /// <summary>
    /// 
    /// </summary>
    public decimal YEAR
    {
      set { _year = value; }
      get { return _year; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string BBBM
    {
      set { _bbbm = value; }
      get { return _bbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string LOCKCELL
    {
      set { _lockcell = value; }
      get { return _lockcell; }
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

