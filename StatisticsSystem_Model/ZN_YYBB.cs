using System;
namespace Maticsoft.Model
{
  /// <summary>
  /// ZN_YYBB:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class ZN_YYBB
  {
    public ZN_YYBB()
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

