using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace StatisticsSystem.Classes
{
  public class Arithmetic
  {
    private static Dictionary<string, int> _operatorLevel;

    public static double GetValue(double left, double right, char _operator)
    {
      switch (_operator)
      {
        case '+':
          return left + right;
        case '-':
          return left - right;
        case '*':
          return left * right;
        case '/':
          if (right == 0)
            return 0;
          return left / right;
      }
      return 0;
    }

    public static double GetResult(string source)
    {
      Stack<string> stack = new Stack<string>();
      var list = source.Split(' ');
      for (int i = 0; i < list.Length; i++)
      {
        string current = list[i];
        if (Regex.IsMatch(current, "^([0-9]{1,}){1}"))
        {
          stack.Push(current);
        }
        else if (OperatorLevel.ContainsKey(current))
        {
          double right = double.Parse(stack.Pop());
          double left = double.Parse(stack.Pop());
          stack.Push(GetValue(left, right, current[0]).ToString());
        }
      }
      return double.Parse(stack.Pop());
    }

    public static string ConvertToRPN(string source)
    {
      StringBuilder result = new StringBuilder();
      Stack<string> stack = new Stack<string>();
      string[] list = source.Split(' ');
      for (int i = 0; i < list.Length; i++)
      {
        string current = list[i];
        if (Regex.IsMatch(current, "^([0-9]{1,}){1}"))
        {
          result.Append(current + " ");
        }
        else if (OperatorLevel.ContainsKey(current))
        {
          if (stack.Count > 0)
          {
            var prev = stack.Peek();
            if (prev == "(")
            {
              stack.Push(current);
              continue;
            }
            if (current == "(")
            {
              stack.Push(current);
              continue;
            }
            if (current == ")")
            {
              while (stack.Count > 0 && stack.Peek() != "(")
              {
                result.Append(stack.Pop() + " ");
              }
              //Pop the "("  
              stack.Pop();
              continue;
            }
            if (OperatorLevel[current] < OperatorLevel[prev])
            {
              while (stack.Count > 0)
              {
                var top = stack.Peek();
                if (top != "(" &&
                    top != ")")
                {
                  result.Append(stack.Pop() + " ");
                }
                else
                {
                  break;
                }
              }
              stack.Push(current);
            }
            else
            {
              stack.Push(current);
            }
          }
          else
          {
            stack.Push(current);
          }
        }
      }
      if (stack.Count > 0)
      {
        while (stack.Count > 0)
        {
          var top = stack.Pop();
          if (top != "(" && top != ")")
          {
            result.Append(top + " ");
          }
        }
      }
      return result.ToString();
    }

    public static string InsertBlank(string source)
    {
      StringBuilder sb = new StringBuilder();
      var list = source.ToCharArray();
      foreach (var temp in list)
      {
        if (OperatorLevel.ContainsKey(temp.ToString()))
        {
          sb.Append(" ");
          sb.Append(temp.ToString());
          sb.Append(" ");
        }
        else
        {
          sb.Append(temp);
        }
      }
      return sb.ToString();
    }

    public static Dictionary<string, int> OperatorLevel
    {
      get
      {
        if (_operatorLevel == null)
        {
          _operatorLevel = new Dictionary<string, int>();
          _operatorLevel.Add("+", 0);
          _operatorLevel.Add("-", 0);
          _operatorLevel.Add("(", 1);
          _operatorLevel.Add("*", 1);
          _operatorLevel.Add("/", 1);
          _operatorLevel.Add(")", 0);
        }
        return _operatorLevel;
      }
    }

    public static double GetCalculateResult(string sourceExpression)
    {
      if (sourceExpression == "")
        return 0;
      string s1 = Arithmetic.InsertBlank(sourceExpression);
      string rpnExperssion = Arithmetic.ConvertToRPN(Arithmetic.InsertBlank(sourceExpression));
      double d_result = Arithmetic.GetResult(rpnExperssion);
      return d_result;
    }
  }
}
