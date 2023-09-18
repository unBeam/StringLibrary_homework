using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using StringLibrary;

namespace StringLibrary_test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void OnlyDigits_EmptyString_ReturnedFalse()
        {
            //Arrange
            string emptyString = "";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_SymbolString_ReturnedFalse()
        {
            //Arrange
            string emptyString = "$";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_BigString_ReturnedFalse()
        {
            //Arrange
            string emptyString = "55555555555555555555";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_MinusString_ReturnedFalse()
        {
            //Arrange
            string emptyString = "5-5";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_DotString_ReturnedFalse()
        {
            //Arrange
            string emptyString = ".";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_WithoutNumbersString_ReturnedFalse()
        {
            //Arrange
            string emptyString = "-=_-";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsFalse(actual);
        }

        [TestMethod]
        public void OnlyDigits_NumberString_ReturnedTrue()
        {
            //Arrange
            string emptyString = "1";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void OnlyDigits_PositiveNumberString_ReturnedTrue()
        {
            //Arrange
            string emptyString = "1";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsTrue(actual);
        }
        [TestMethod]
        public void OnlyDigits_NumberDotString_ReturnedTrue()
        {
            //Arrange
            string emptyString = "2.345";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void OnlyDigits_MinusDotString_ReturnedTrue()
        {
            //Arrange
            string emptyString = "-3,23";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsTrue(actual);
        }

        [TestMethod]
        public void OnlyDigits_FirstDotString_ReturnedTrue()
        {
            //Arrange
            string emptyString = ".23";
            //Act
            StringClass stringClass = new StringClass();
            bool actual = stringClass.OnlyDigits(emptyString);
            //Assert
            Assert.IsTrue(actual);
        }

    }
}
