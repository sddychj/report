using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// ZN_DOCJSXXYSJ:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ZN_DOCJSXXYSJ
  {
    public ZN_DOCJSXXYSJ()
    { }
    #region Model
    private decimal _docjsxxid;
    private string _oname;
    private string _obbbm;
    private string _ozbbm;
    private string _ozd;
    private string _odwbm;
    private string _onf;
    private string _oyf;
    /// <summary>
    /// WORD计算信息ID
    /// </summary>
    public decimal DOCJSXXID
    {
      set { _docjsxxid = value; }
      get { return _docjsxxid; }
    }
    /// <summary>
    /// 元名称
    /// </summary>
    public string ONAME
    {
      set { _oname = value; }
      get { return _oname; }
    }
    /// <summary>
    /// 元数据描述报表编码
    /// </summary>
    public string OBBBM
    {
      set { _obbbm = value; }
      get { return _obbbm; }
    }
    /// <summary>
    /// 元数据描述指标编码
    /// </summary>
    public string OZBBM
    {
      set { _ozbbm = value; }
      get { return _ozbbm; }
    }
    /// <summary>
    /// 元数据描述字段
    /// </summary>
    public string OZD
    {
      set { _ozd = value; }
      get { return _ozd; }
    }
    /// <summary>
    /// 元数据描述单位编码
    /// </summary>
    public string ODWBM
    {
      set { _odwbm = value; }
      get { return _odwbm; }
    }
    /// <summary>
    /// 元数据描述相对年份
    /// </summary>
    public string ONF
    {
      set { _onf = value; }
      get { return _onf; }
    }
    /// <summary>
    /// 元数据描述相对月份
    /// </summary>
    public string OYF
    {
      set { _oyf = value; }
      get { return _oyf; }
    }
    #endregion Model

  }
}

