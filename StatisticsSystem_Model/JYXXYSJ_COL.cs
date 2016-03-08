using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// JYXXYSJ_COL:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class JYXXYSJ_COL
  {
    public JYXXYSJ_COL()
    { }
    #region Model
    private decimal _jyxxid;
    private string _oname;
    private string _obbbm;
    private string _ozd;
    private string _odwbm;
    private string _onf;
    private string _oyf;
    /// <summary>
    /// 
    /// </summary>
    public decimal JYXXID
    {
      set { _jyxxid = value; }
      get { return _jyxxid; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ONAME
    {
      set { _oname = value; }
      get { return _oname; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string OBBBM
    {
      set { _obbbm = value; }
      get { return _obbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string OZD
    {
      set { _ozd = value; }
      get { return _ozd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ODWBM
    {
      set { _odwbm = value; }
      get { return _odwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ONF
    {
      set { _onf = value; }
      get { return _onf; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string OYF
    {
      set { _oyf = value; }
      get { return _oyf; }
    }
    #endregion Model

  }
}

