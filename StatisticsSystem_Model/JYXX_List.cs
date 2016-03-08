using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Model
{
  public class JYXX_List
  {
    public JYXX_List(int length)
    {
      _jyxxid = new decimal[length];
      _bbbm = new string[length];
      _jymc = new string[length];
      _jyms = new string[length];
      _jygx = new string[length];
      _jysx = new decimal[length];
      _dwbm = new string[length];
      _nf = new string[length];
      _yf = new string[length];
    }
    #region Model
    private decimal[] _jyxxid;
    private string[] _bbbm;
    private string[] _jymc;
    private string[] _jyms;
    private string[] _jygx;
    private decimal[] _jysx;
    private string[] _dwbm;
    private string[] _nf;
    private string[] _yf;
    /// <summary>
    /// 校验信息ID
    /// </summary>
    public decimal[] JYXXID
    {
      set { _jyxxid = value; }
      get { return _jyxxid; }
    }
    /// <summary>
    /// 报表编码
    /// </summary>
    public string[] BBBM
    {
      set { _bbbm = value; }
      get { return _bbbm; }
    }
    /// <summary>
    /// 校验名称
    /// </summary>
    public string[] JYMC
    {
      set { _jymc = value; }
      get { return _jymc; }
    }
    /// <summary>
    /// 校验描述
    /// </summary>
    public string[] JYMS
    {
      set { _jyms = value; }
      get { return _jyms; }
    }
    /// <summary>
    /// 与0的关系
    /// </summary>
    public string[] JYGX
    {
      set { _jygx = value; }
      get { return _jygx; }
    }
    /// <summary>
    /// 校验顺序
    /// </summary>
    public decimal[] JYSX
    {
      set { _jysx = value; }
      get { return _jysx; }
    }
    /// <summary>
    /// 单位编码
    /// </summary>
    public string[] DWBM
    {
      set { _dwbm = value; }
      get { return _dwbm; }
    }
    /// <summary>
    /// 年份
    /// </summary>
    public string[] NF
    {
      set { _nf = value; }
      get { return _nf; }
    }
    /// <summary>
    /// 月份
    /// </summary>
    public string[] YF
    {
      set { _yf = value; }
      get { return _yf; }
    }
    #endregion Model
  }
}
