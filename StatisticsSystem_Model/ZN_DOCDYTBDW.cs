using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// ZN_DOCDYTBDW:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ZN_DOCDYTBDW
  {
    public ZN_DOCDYTBDW()
    { }
    #region Model
    private string _docbm;
    private string _dwbm;
    /// <summary>
    /// WORD编码
    /// </summary>
    public string DOCBM
    {
      set { _docbm = value; }
      get { return _docbm; }
    }
    /// <summary>
    /// 单位编码
    /// </summary>
    public string DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    #endregion Model

  }
}

