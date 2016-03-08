using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StatisticsSystem.Classes
{
  public class CharList
  {
    private static HashSet<char> hashChar;

    public static HashSet<char> HashChar
    {
      get
      {
        if (hashChar == null)
        {
          hashChar = new HashSet<char>();
          hashChar.Add('A');
          hashChar.Add('B');
          hashChar.Add('C');
          hashChar.Add('D');
          hashChar.Add('E');
          hashChar.Add('F');
          hashChar.Add('G');
          hashChar.Add('H');
          hashChar.Add('I');
          hashChar.Add('J');
          hashChar.Add('K');
          hashChar.Add('L');
          hashChar.Add('M');
          hashChar.Add('N');
          hashChar.Add('O');
          hashChar.Add('P');
          hashChar.Add('Q');
          hashChar.Add('R');
          hashChar.Add('S');
          hashChar.Add('T');
          hashChar.Add('U');
          hashChar.Add('V');
          hashChar.Add('W');
          hashChar.Add('X');
          hashChar.Add('Y');
          hashChar.Add('Z');
          hashChar.Add('!');
          hashChar.Add('@');
          hashChar.Add('#');
          hashChar.Add('$');
          hashChar.Add('%');
          hashChar.Add('^');
          hashChar.Add('&');
          hashChar.Add('<');
          hashChar.Add('>');
          hashChar.Add('?');
          hashChar.Add('[');
          hashChar.Add(']');
        }
        return CharList.hashChar;
      }
      set { CharList.hashChar = value; }
    }
    public CharList()
    {
    }
  }
}
