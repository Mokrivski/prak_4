using System;
using Pract_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace User_Registration_Tests
{
  [TestClass]
  public class PasswordStrangeCheckerTests
  {
    [TestMethod]
    public void GetPasswordStrange_7_1point()
    {
      // arrange
      string password = "Password1";
      int expected = 1;

      //act
      int actual = Password_Strange_Checker.GetPasswordStrange(password);

      //assert
      Assert.AreEqual(expected, actual);
    }

    [TestMethod]
    public void GetPasswordUppercase_1point()
    {
      //Arange
      string password = "Password1";
      int exepted = 1;

      //Act
      int actual = Password_Strange_Checker.GetPasswordUpperCase(password);

      //Assert
      Assert.AreEqual(exepted, actual);
    }

    [TestMethod]
    public void GetPasswordLowerCase_1point()
    {
      //Arange
      string password = "PASSWORd1";
      int exepted = 1;

      //Act
      int actual = Password_Strange_Checker.GetPasswordLowerCase(password);

      //Assert
      Assert.AreEqual(exepted, actual);
    }

    [TestMethod]
    public void GetNumber_1point()
    {
      //Arange
      string password = "Pa33word1";
      int exepted = 1;

      //Act
      int actual = Password_Strange_Checker.GetNumber(password);

      //Assert
      Assert.AreEqual(exepted, actual);
    }

    [TestMethod]
    public void GetSpecialSymbol_1point()
    {
      //Arange
      string password = "Pa$$w!o@rd1";
      int exepted = 1;

      //Act
      int actual = Password_Strange_Checker.GetSpecialSymbol(password);

      //Assert
      Assert.AreEqual(exepted, actual);
    }
  }
}
