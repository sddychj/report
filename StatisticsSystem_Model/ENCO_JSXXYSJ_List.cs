using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  public class ENCO_JSXXYSJ_List
  {
    public ENCO_JSXXYSJ_List()
    { }
    public ENCO_JSXXYSJ_List(int length)
    {
      _jsxxid = new decimal[length];
      _oname = new string[length];
      _obbbm = new string[length];
      _ozbbm = new string[length];
      _ozd = new string[length];
      _odwbm = new string[length];
      _onf = new string[length];
      _oyf = new string[length];
    }
    #region Model
    private decimal[] _jsxxid;
    private string[] _oname;
    private string[] _obbbm;
    private string[] _ozbbm;
    private string[] _ozd;
    private string[] _odwbm;
    private string[] _onf;
    private string[] _oyf;
    /// <summary>
    /// 
    /// </summary>
    public decimal[] JSXXID
    {
      set { _jsxxid = value; }
      get { return _jsxxid; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ONAME
    {
      set { _oname = value; }
      get { return _oname; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] OBBBM
    {
      set { _obbbm = value; }
      get { return _obbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] OZBBM
    {
      set { _ozbbm = value; }
      get { return _ozbbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] OZD
    {
      set { _ozd = value; }
      get { return _ozd; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ODWBM
    {
      set { _odwbm = value; }
      get { return _odwbm; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] ONF
    {
      set { _onf = value; }
      get { return _onf; }
    }
    /// <summary>
    /// 
    /// </summary>
    public string[] OYF
    {
      set { _oyf = value; }
      get { return _oyf; }
    }
    #endregion Model
  }
}
