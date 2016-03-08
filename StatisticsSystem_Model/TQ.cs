using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// TIQU:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class TIQU
  {
    public TIQU()
    { }
    #region Model
    private string _soursetable;
    private string _targettable;
    private string _sorsedwbm;
    private string _targetdwbm;
    private string _soursenf;
    private string _sourseyf;
    /// <summary>
    /// 
    /// </summary>
    public string SOURSETABLE
    {
      set { _soursetable = value; }
      get { return _soursetable; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string TARGETTABLE
    {
      set { _targettable = value; }
      get { return _targettable; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string SORSEDWBM
    {
      set { _sorsedwbm = value; }
      get { return _sorsedwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string TARGETDWBM
    {
      set { _targetdwbm = value; }
      get { return _targetdwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string SOURSENF
    {
      set { _soursenf = value; }
      get { return _soursenf; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string SOURSEYF
    {
      set { _sourseyf = value; }
      get { return _sourseyf; }
    }
    #endregion Model

  }
}

