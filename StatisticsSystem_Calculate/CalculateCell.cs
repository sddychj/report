using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
//using Oracle.DataAccess.Client;
//using Oracle.DataAccess.Types;
using System.Data.OracleClient;
using System.Text.RegularExpressions;
using LitJson;
//using DBUtility;

namespace StatisticsSystem.Calculate
{
  public class CalculateCell
  {
    private static Dictionary<string, string> _dic_jsxx;
    private static Dictionary<string, string> _dic_jsxxysj;

    private static bool GetJSXXState()
    {
      bool flag = true;
      string s_sql = "select * from jsxx_state";
      OracleDataReader dr = DbHelperOra.ExecuteReader(s_sql);
      if (dr.Read())
      {
        flag = dr["isupdate"].ToString() == "true" ? true : false;
      }
      dr.Close();
      UpdateState();
      return flag;
    }

    private static bool UpdateState()
    {
      string sql = "update jsxx_state set isupdate='false'";
      int rows = DbHelperOra.ExecuteSql(sql);
      if (rows > 0)
      { return true; }
      else
      { return false; }
    }

    private static int update(string bbbm, string zbbm, string zd, string dwbm, string nf, string yf, string result, List<UpdateInfor> updateInfor)
    {
      int resultInt = 0;
      string s_sql = "update {0} set {1}={2} where zbbm='{3}' and dwbm='{4}' and nf='{5}' and yf='{6}'";
      s_sql = string.Format(s_sql, bbbm, zd, result, zbbm, dwbm, nf, yf);
      resultInt = DbHelperOra.ExecuteSql(s_sql);
      if (resultInt > 0)
      {
        UpdateInfor update = new UpdateInfor();
        update.Bbbm = bbbm;
        update.Zbbm = zbbm;
        update.Zd = zd;
        update.Dwbm = dwbm;
        update.Nf = nf;
        update.Yf = yf;
        update.Value = result.ToString();
        updateInfor.Add(update);
      }
      return resultInt;
    }

    private static string select(string bbbm, string zbbm, string zd, string dwbm, string nf, string yf)
    {
      string result = "0";
      string s_sql = "select {0} from {1} where zbbm='{2}' and dwbm='{3}' and nf={4} and yf={5}";
      s_sql = string.Format(s_sql, zd, bbbm, zbbm, dwbm, nf, yf);
      OracleDataReader dr = DbHelperOra.ExecuteReader(s_sql);
      if (dr.Read())
      {
        result = dr[zd].ToString() == "" ? "0" : dr[zd].ToString();
      }
      dr.Close();
      return result;
    }

    public static string calculate(string bbbm, string zbbm, string zd, string dwbm, string nf, string yf)
    {
      int i_result = 0;
      //if (GetJSXXState() || dic_jsxx == null || dic_jsxxysj == null)
      //{
      //  dic_jsxx = GetHash_jsxx();
      //  dic_jsxxysj = GetHash_jsxxysj();
      //}
      List<UpdateInfor> updateInfor = new List<UpdateInfor>();

      //string s = System.Configuration.ConfigurationManager.AppSettings["odp"].ToString();
      i_result += DIGUI(bbbm, zbbm, zd, dwbm, nf, yf, dic_jsxx, dic_jsxxysj, updateInfor);
      string returnStr = JsonMapper.ToJson(updateInfor);
      //string returnStr = "";
      return returnStr;
    }

    private static int DIGUI(string bbbm, string zbbm, string zd, string dwbm, string nf, string yf,
      Dictionary<string, string> dic_jsxx, Dictionary<string, string> dic_jsxxysj, List<UpdateInfor> updateInfor)
    {
      int i_result = 0;
      Dictionary<string, string> dic_jsxxysj_current = GetHash_jsxxysj(bbbm, zbbm, zd, dwbm);
      string s_jsxxid = "";
      string s_jsms = "", result = "";
      string[] sl_jsxxysj_current_key = null, sl_jsxxysj_value = null, sl_jsxx_value = null;
      char c;
      StringBuilder sb_expression = new StringBuilder();

      foreach (KeyValuePair<string, string> item in dic_jsxxysj_current)
      {
        sl_jsxxysj_current_key = item.Key.Split(new char[] { '|' });
        s_jsxxid = sl_jsxxysj_current_key[0];
        sl_jsxx_value = dic_jsxx[s_jsxxid].Split(new char[] { '|' });
        s_jsms = sl_jsxx_value[3];
        for (int i = 0; i < s_jsms.Length; i++)
        {
          c = s_jsms[i];
          if (Regex.IsMatch(c.ToString(), "^[A-Za-z]+$"))
          {
            sl_jsxxysj_value = dic_jsxxysj[s_jsxxid + "|" + c.ToString()].Split(new char[] { '|' });
            sb_expression.Append(select(
              sl_jsxxysj_value[0], sl_jsxxysj_value[1], sl_jsxxysj_value[2],
              sl_jsxxysj_value[3] == "" ? dwbm : sl_jsxxysj_value[3],
              GetNFSelect(sl_jsxxysj_value[4], nf).ToString(),
              GetNFSelect(sl_jsxxysj_value[5], yf).ToString()));
          }
          else
          {
            sb_expression.Append(c.ToString());
          }
        }
        result = Arithmetic.GetCalculateResult(sb_expression.ToString()).ToString();
        i_result += update(sl_jsxx_value[0], sl_jsxx_value[1], sl_jsxx_value[2],
          sl_jsxx_value[4] == "" ? dwbm : sl_jsxx_value[4],
          sl_jsxx_value[5] == "" ? nf : sl_jsxx_value[5],
          sl_jsxx_value[6] == "" ? yf : sl_jsxx_value[6],
          result, updateInfor);
        //i_result += DIGUI(sl_jsxx_value[0], sl_jsxx_value[1], sl_jsxx_value[2], dwbm, nf, yf, dic_jsxx, dic_jsxxysj, updateInfor);
        sb_expression.Clear();
      }
      return i_result;
    }

    private static int GetNFSelect(string onf, string nf)
    {
      int nfSel = 0;
      if (onf == "")
      {
        nfSel = int.Parse(nf);
      }
      else if (onf.Substring(0, 1) == "[")
      {
        nfSel = int.Parse(onf.Substring(1, onf.Length - 1));
      }
      else
      {
        return int.Parse(onf) + int.Parse(nf);
      }
      return nfSel;
    }

    public static Dictionary<string, string> dic_jsxx
    {
      get
      {
        if (_dic_jsxx == null)
        {
          if (GetJSXXState() || _dic_jsxx == null)
          {
            _dic_jsxx = GetHash_jsxx();
          }
        }
        return _dic_jsxx;
      }
      set
      {
      }
    }

    public static Dictionary<string, string> dic_jsxxysj
    {
      get
      {
        if (_dic_jsxxysj == null)
        {
          if (GetJSXXState() || _dic_jsxxysj == null)
          {
            _dic_jsxxysj = GetHash_jsxxysj();
          }
        }
        return _dic_jsxxysj;
      }
      set
      {
      }
    }

    private static Dictionary<string, string> GetHash_jsxx()
    {
      Dictionary<string, string> dic_jsxx = new Dictionary<string, string>();
      string sql = @"select * from enco_jsxx t";
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql);
      string s1 = "", s2 = "";
      while (dr.Read())
      {
        s1 = dr["jsxxid"].ToString();
        s2 = dr["bbbm"].ToString() + "|" + dr["zbbm"].ToString() + "|" + dr["zd"].ToString() + "|" + dr["jsms"].ToString()
           + "|" + dr["dwbm"].ToString() + "|" + dr["nf"].ToString() + "|" + dr["yf"].ToString();
        dic_jsxx.Add(s1, s2);
      }
      dr.Close();
      return dic_jsxx;
    }

    private static Dictionary<string, string> GetHash_jsxxysj()
    {
      Dictionary<string, string> dic_jsxx = new Dictionary<string, string>();
      string sql = @"select * from enco_jsxxysj t ";
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql);
      string s1 = "", s2 = "";
      while (dr.Read())
      {
        s1 = dr["jsxxid"].ToString() + "|" + dr["oname"].ToString();
        s2 = dr["obbbm"].ToString() + "|" + dr["ozbbm"].ToString() + "|" + dr["ozd"].ToString()
          + "|" + dr["odwbm"].ToString() + "|" + dr["onf"].ToString() + "|" + dr["oyf"].ToString();
        dic_jsxx.Add(s1, s2);
      }
      dr.Close();
      return dic_jsxx;
    }

    private static Dictionary<string, string> GetHash_jsxxysj(string bbbm, string zbbm, string zd, string dwbm)
    {
      Dictionary<string, string> dic_jsxx = new Dictionary<string, string>();
      string sql = @"select * from enco_jsxxysj t where obbbm=:0 and (odwbm=:1 or odwbm is null) and ozbbm=:2 and ozd=:3 
              and onf is null and oyf is null";
      OracleParameter[] cmdParams = new OracleParameter[] { new OracleParameter(":0", OracleType.VarChar, 10) ,
             new OracleParameter(":1", OracleType.VarChar, 20),new OracleParameter(":2", OracleType.VarChar, 20),
            new OracleParameter(":3", OracleType.VarChar, 20)};
      cmdParams[0].Value = bbbm;
      cmdParams[1].Value = dwbm;
      cmdParams[2].Value = zbbm;
      cmdParams[3].Value = zd;
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql, cmdParams);
      string s1 = "", s2 = "";
      if (dr.Read())
      {
        s1 = dr["jsxxid"].ToString() + "|" + dr["oname"].ToString();
        s2 = dr["obbbm"].ToString() + "|" + dr["ozbbm"].ToString() + "|" + dr["ozd"].ToString()
          + "|" + dr["odwbm"].ToString() + "|" + dr["onf"].ToString() + "|" + dr["oyf"].ToString();
        dic_jsxx.Add(s1, s2);
      }
      dr.Close();
      //dic_jsxx.Add("1023|A", "CL0002|CL00020007|COL6||||");
      return dic_jsxx;
    }

    private static Hashtable GetHash_jsxx_t()
    {
      Hashtable dic_jsxx = new Hashtable();
      string sql = @"select * from enco_jsxxysj t";
      OracleDataReader dr = DbHelperOra.ExecuteReader(sql);
      string s1 = "", s2 = "";
      while (dr.Read())
      {
        s1 = dr["jsxxid"].ToString() + "|" + dr["oname"].ToString();
        s2 = dr["obbbm"].ToString() + "|" + dr["ozbbm"].ToString() + "|" + dr["ozd"].ToString()
          + "|" + dr["odwbm"].ToString() + "|" + dr["onf"].ToString() + "|" + dr["oyf"].ToString() + "_";
        dic_jsxx.Add(s1, s2);
      }
      dr.Close();
      return dic_jsxx;
    }

    public static void UpdateTest()
    {
      string sql = "update cl0002 set col6=4 where dwbm='HG' and zbbm='CL00020007' and nf=2014 and yf=12";
      DbHelperOra.ExecuteSql(sql);
    }
  }
}
