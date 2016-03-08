using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// ZN_DOCJSXX:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ZN_DOCJSXX
  {
    public ZN_DOCJSXX()
    { }
    #region Model
    private decimal _docjsxxid;
    private string _docbm;
    private string _sqmc;
    private string _jsms;
    private decimal? _jssx;
    private string _dwbm;
    private string _nf;
    private string _yf;
    /// <summary>
    /// WORD计算信息ID
    /// </summary>
    public decimal DOCJSXXID
    {
      set { _docjsxxid = value; }
      get { return _docjsxxid; }
    }
    /// <summary>
    /// WORD编码
    /// </summary>
    public string DOCBM
    {
      set { _docbm = value; }
      get { return _docbm; }
    }
    /// <summary>
    /// 书签名称
    /// </summary>
    public string SQMC
    {
      set { _sqmc = value; }
      get { return _sqmc; }
    }
    /// <summary>
    /// 计算描述
    /// </summary>
    public string JSMS
    {
      set { _jsms = value; }
      get { return _jsms; }
    }
    /// <summary>
    /// 计算顺序
    /// </summary>
    public decimal? JSSX
    {
      set { _jssx = value; }
      get { return _jssx; }
    }
    /// <summary>
    /// 单位编码
    /// </summary>
    public string DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    /// <summary>
    /// 年份
    /// </summary>
    public string NF
    {
      set { _nf = value; }
      get { return _nf; }
    }
    /// <summary>
    /// 月份
    /// </summary>
    public string YF
    {
      set { _yf = value; }
      get { return _yf; }
    }
    #endregion Model

  }
}

