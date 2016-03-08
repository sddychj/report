using System;
namespace StatisticsSystem.Model
{
  /// <summary>
  /// XMLVERSION:实体类(属性说明自动提取数据库字段的描述信息)
  /// </summary>
  [Serializable]
  public partial class XMLVERSION
  {
    public XMLVERSION()
    { }
    #region Model
    private decimal _year;
    private string _bbbm;
    private string _caption;
    private string _coordinates;
    private string _hiddencolumn;
    private string _hiddenrow;
    private string _notalloweditrow;
    private string _lockcell;
    private string _columnwidth;
    private string _namehierarchy;
    private string _selectfield;
    private string _orderby;
    private int _rowcount;
    private int _columncount;
    private string _NotAllowEditColumn;
    private string _Title;

    public string Title
    {
      get { return _Title; }
      set { _Title = value; }
    }

    public string NotAllowEditColumn
    {
      get { return _NotAllowEditColumn; }
      set { _NotAllowEditColumn = value; }
    }

    public int COLUMNCOUNT
    {
      get { return _columncount; }
      set { _columncount = value; }
    }

    public int ROWCOUNT
    {
      get { return _rowcount; }
      set { _rowcount = value; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal YEAR
    {
      set { _year = value; }
      get { return _year; }
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
    public string CAPTION
    {
      set { _caption = value; }
      get { return _caption; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string COORDINATES
    {
      set { _coordinates = value; }
      get { return _coordinates; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string HIDDENCOLUMN
    {
      set { _hiddencolumn = value; }
      get { return _hiddencolumn; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string HIDDENROW
    {
      set { _hiddenrow = value; }
      get { return _hiddenrow; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NOTALLOWEDITROW
    {
      set { _notalloweditrow = value; }
      get { return _notalloweditrow; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string LOCKCELL
    {
      set { _lockcell = value; }
      get { return _lockcell; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string COLUMNWIDTH
    {
      set { _columnwidth = value; }
      get { return _columnwidth; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string NAMEHIERARCHY
    {
      set { _namehierarchy = value; }
      get { return _namehierarchy; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string SELECTFIELD
    {
      set { _selectfield = value; }
      get { return _selectfield; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string ORDERBY
    {
      set { _orderby = value; }
      get { return _orderby; }
    }
    #endregion Model

  }
}

