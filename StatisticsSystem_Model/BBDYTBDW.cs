using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// BBDYTBDW:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class BBDYTBDW
  {
    public BBDYTBDW()
    { }
    #region Model
    private string _bbbm;
    private string _dwbm;
    private string _sumdw;
    private string _isglzb;

    public string Isglzb
    {
      get { return _isglzb; }
      set { _isglzb = value; }
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
    public string SUMDW
    {
      set { _sumdw = value; }
      get { return _sumdw; }
    }
    #endregion Model

  }
}

