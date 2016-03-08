using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  [Serializable]
  public partial class ENCO_BBZD_List
  {
    public ENCO_BBZD_List()
    { }
    public ENCO_BBZD_List(int length)
    {
      _bbbm = new string[length];
      _zd = new string[length];
      _zdzs = new string[length];
      _sjlx = new string[length];
      _sjcd = new string[length];
      _sjjd = new decimal[length];
      _zdsx = new decimal[length];
      _flyc = new string[length];
      _sfzd = new string[length];
      _sfyc = new string[length];
      _sfhz = new string[length];
      _width1 = new decimal[length];
    }
    #region Model
    private string[] _bbbm;
    private string[] _zd;
    private string[] _zdzs;
    private string[] _sjlx;
    private string[] _sjcd;
    private decimal[] _sjjd;
    private decimal[] _zdsx;
    private string[] _flyc;
    private string[] _sfyc;
    private string[] _sfzd;
    private string[] _sfhz;
    private decimal[] _width1;

    public decimal[] WIDTH1
    {
      get { return _width1; }
      set { _width1 = value; }
    }

    public string[] Sfhz
    {
      get { return _sfhz; }
      set { _sfhz = value; }
    }

    public string[] Sfzd
    {
      get { return _sfzd; }
      set { _sfzd = value; }
    }

    public string[] Sfyc
    {
      get { return _sfyc; }
      set { _sfyc = value; }
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
    public string[] ZD
    {
      set { _zd = value; }
      get { return _zd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ZDZS
    {
      set { _zdzs = value; }
      get { return _zdzs; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] SJLX
    {
      set { _sjlx = value; }
      get { return _sjlx; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] SJCD
    {
      set { _sjcd = value; }
      get { return _sjcd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal[] SJJD
    {
      set { _sjjd = value; }
      get { return _sjjd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public decimal[] ZDSX
    {
      set { _zdsx = value; }
      get { return _zdsx; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] FLYC
    {
      set { _flyc = value; }
      get { return _flyc; }
    }
    #endregion Model

  }
}
