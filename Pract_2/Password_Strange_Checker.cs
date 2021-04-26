using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pract_2
{
  [TestClass]
  public class Password_Strange_Checker
  {
    [TestMethod]
    public static int GetPasswordStrange(string password)
    {
      int result = 0;
      
      if(Math.Max(password.Length, 7) > 7)
      {
        result++;
      }

      return result;
    }

    public static int GetPasswordUpperCase(string password)
    {
      int result = 0;
      
      foreach (char i in password)
      {
        if (char.IsUpper(i))
          result++;
      }

      return result;
    }
    
    public static int GetPasswordLowerCase(string password)
    {
      int result = 0;

      foreach(char i in password)
      {
        if (char.IsLower(i))
          result++;
      }

      return result;
    }

    public static int GetNumber(string password)
    {
      int result = 0;

      if (password.Any(x => char.IsDigit(x)))
        result++;

      return result;
    }

    public static int GetSpecialSymbol(string password)
    {
      int result = 0;

      Regex symbol = new Regex(@"[-!#\$%&'\*\+/=\?\^`\{\}\|~]\w");
      MatchCollection match = symbol.Matches(password);
      if (match.Count > 0)
      {
        result++;
      }

      return result;
    }
  }
}
