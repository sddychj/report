using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using LitJson;

namespace StatisticsSystem.Calculate
{
  public class UpdateInfor
  {
    private string _bbbm;

    public string Bbbm
    {
      get { return _bbbm; }
      set { _bbbm = value; }
    }
    private string _zd;

    public string Zd
    {
      get { return _zd; }
      set { _zd = value; }
    }
    private string _zbbm;

    public string Zbbm
    {
      get { return _zbbm; }
      set { _zbbm = value; }
    }
    private string _dwbm;

    public string Dwbm
    {
      get { return _dwbm; }
      set { _dwbm = value; }
    }
    private string _nf;

    public string Nf
    {
      get { return _nf; }
      set { _nf = value; }
    }
    private string _yf;

    public string Yf
    {
      get { return _yf; }
      set { _yf = value; }
    }

    private string _value;

    public string Value
    {
      get { return _value; }
      set { _value = value; }
    }

  }

  public class WriteUpdateInfor
  { 
    public string write()
    {
      List<UpdateInfor> list = new List<UpdateInfor>();
      UpdateInfor update = new UpdateInfor();
      update.Bbbm = "1";
      update.Zbbm = "1";
      update.Zd = "1";
      list.Add(update); 
      update = new UpdateInfor();
      update.Bbbm = "2";
      update.Zbbm = "2";
      update.Zd = "2";
      list.Add(update);
      
      return JsonMapper.ToJson(list);
    }
  
  }
}
