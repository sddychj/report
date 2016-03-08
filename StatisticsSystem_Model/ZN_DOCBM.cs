using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// ZN_DOCBM:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ZN_DOCBM
  {
    public ZN_DOCBM()
    { }
    #region Model
    private string _docbm;
    private string _docmc;
    private string _dotmc;
    private string _doczq;
    /// <summary>
    /// WORD编码
    /// </summary>
    public string DOCBM
    {
      set { _docbm = value; }
      get { return _docbm; }
    }
    /// <summary>
    /// WORD名称
    /// </summary>
    public string DOCMC
    {
      set { _docmc = value; }
      get { return _docmc; }
    }
    /// <summary>
    /// 模板名称
    /// </summary>
    public string DOTMC
    {
      set { _dotmc = value; }
      get { return _dotmc; }
    }
    /// <summary>
    /// 周期
    /// </summary>
    public string DOCZQ
    {
      set { _doczq = value; }
      get { return _doczq; }
    }
    #endregion Model

  }
}

