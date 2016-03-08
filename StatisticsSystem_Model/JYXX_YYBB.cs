using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// JYXX_YYBB:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class JYXX_YYBB
  {
    public JYXX_YYBB()
    { }
    #region Model
    private string _bbbm;
    private string _yybbbm;
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
    public string YYBBBM
    {
      set { _yybbbm = value; }
      get { return _yybbbm; }
    }
    #endregion Model

  }
}

