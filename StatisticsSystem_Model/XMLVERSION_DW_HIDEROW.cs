using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// XMLVERSION_DW_HIDEROW:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class XMLVERSION_DW_HIDEROW
  {
    public XMLVERSION_DW_HIDEROW()
    { }
    #region Model
    private decimal _year;
    private string _bbbm;
    private string _dwbm;
    private string _hiddenrow;
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
    public string DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string HIDDENROW
    {
      set { _hiddenrow = value; }
      get { return _hiddenrow; }
    }
    #endregion Model

  }
}

