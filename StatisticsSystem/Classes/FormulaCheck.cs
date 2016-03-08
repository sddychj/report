using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace StatisticsSystem.Classes
{
  public class FormulaCheck
  {

    /// <summary>
    /// 将公式中字符转为数字，变为公式，校验格式是否正确
    /// </summary>
    /// <param name="formula"></param>
    /// <returns></returns>
    public string ConvertCharToNum(string formula)
    {
      string returnStr = "";
      formula = formula.ToUpper();
      for (int i = 0; i < formula.Length; i++)
      {
        char c = formula[i];
        //if (c >= 'A' && c <= 'Z')
        //{
        //  c = '1';
        //}
        if (Classes.CharList.HashChar.Contains(c))
        {
          c = '1';
        }
        returnStr += c.ToString();
      }
      return returnStr;
    }

    /// <summary>
    /// 检验公式是否能够计算
    /// </summary>
    /// <param name="formula"></param>
    /// <returns></returns>
    public bool CheckFormula(string formula)
    {
      bool flag = false;
      try
      {
        formula = formula.ToUpper();
        for (int i = 0; i < formula.Length; i++)
        {
          char c = formula[i];
          if (c >= '0' && c <= '9')
          { }
          else if (c == '+' || c == '-' || c == '*' || c == '/' || c == '(' || c == ')' || c == '.')
          { }
          else
          {
            return true;
          }
        }
        double d = Classes.Arithmetic.GetCalculateResult(formula);
      }
      catch
      {
        flag = true;
      }
      return flag;
    }

    public bool IsRepeat(string formula)
    {
      bool flag = false;
      Hashtable hash = new Hashtable();
      for (int i = 0; i < formula.Length; i++)
      {
        char c = formula[i];
        if (hash.ContainsKey(c.ToString()))
        {
          flag = true;
          break;
        }
        else
        {
          if (Classes.CharList.HashChar.Contains(c))
          {
            hash.Add(c.ToString(), "");
          }
        }
      }
      return flag;
    }
  }
}
