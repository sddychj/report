using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// 报表类型
  /// </summary>
  [Serializable]
  public partial class ENCO_BBLX
  {
    public ENCO_BBLX()
    { }
    #region Model
    private decimal _id;
    private string _lbmc;
    /// <summary>
    /// 
    /// </summary>
    public decimal ID
    {
      set { _id = value; }
      get { return _id; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string LBMC
    {
      set { _lbmc = value; }
      get { return _lbmc; }
    }
    #endregion Model

  }
}

