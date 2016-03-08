using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  [Serializable]
  public partial class ENCO_ZBBMB_List
  {
    public ENCO_ZBBMB_List()
    { }
    public ENCO_ZBBMB_List(int length)
    {
      _bbbm = new string[length];
      _zbbm = new string[length];
      _zbmc = new string[length];
      _zbdm = new string[length];
      _jldw1 = new string[length];
      _jldw2 = new string[length];
      _jldw3 = new string[length];
      _cj = new decimal[length];
      _hc = new decimal[length];
      _qyjy = new string[length];
      _xsyc = new string[length];
      _sfkbj = new string[length];
      _sfmj = new string[length];
      _bzsz1 = new string[length];
      _bzsz2 = new string[length];
      _sjzbbm = new string[length];
      _sjhzbm = new string[length];
    }
    #region Model
    private string[] _bbbm;
    private string[] _zbbm;
    private string[] _zbmc;
    private string[] _zbdm;
    private string[] _jldw1;
    private string[] _jldw2;
    private string[] _jldw3;
    private decimal[] _cj;
    private decimal[] _hc;
    private string[] _qyjy;
    private string[] _xsyc;
    private string[] _sfkbj;
    private string[] _sfmj;
    private string[] _bzsz1;
    private string[] _bzsz2;
    private string[] _sjzbbm;
    private string[] _sjhzbm;

    public string[] Sjhzbm
    {
      get { return _sjhzbm; }
      set { _sjhzbm = value; }
    }
    public string[] Sjzbbm
    {
      get { return _sjzbbm; }
      set { _sjzbbm = value; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] BBBM
    {
      set { _bbbm = value; }
      get { return _bbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ZBBM
    {
      set { _zbbm = value; }
      get { return _zbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ZBMC
    {
      set { _zbmc = value; }
      get { return _zbmc; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ZBDM
    {
      set { _zbdm = value; }
      get { return _zbdm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] JLDW1
    {
      set { _jldw1 = value; }
      get { return _jldw1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] JLDW2
    {
      set { _jldw2 = value; }
      get { return _jldw2; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] JLDW3
    {
      set { _jldw3 = value; }
      get { return _jldw3; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal[] CJ
    {
      set { _cj = value; }
      get { return _cj; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal[] HC
    {
      set { _hc = value; }
      get { return _hc; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] QYJY
    {
      set { _qyjy = value; }
      get { return _qyjy; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] XSYC
    {
      set { _xsyc = value; }
      get { return _xsyc; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] SFKBJ
    {
      set { _sfkbj = value; }
      get { return _sfkbj; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] SFMJ
    {
      set { _sfmj = value; }
      get { return _sfmj; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] BZSZ1
    {
      set { _bzsz1 = value; }
      get { return _bzsz1; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] BZSZ2
    {
      set { _bzsz2 = value; }
      get { return _bzsz2; }
    }
    #endregion Model

  }
}
