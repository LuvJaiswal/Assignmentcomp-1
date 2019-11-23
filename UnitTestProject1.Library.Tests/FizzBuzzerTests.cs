using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
namespace UnitTestProject1.Library.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Buzzer_when1_Returns1()
        {
            //Arrange
            int input = 1;

            //Act
            string output=UnitTest1.GetValue(input);

        }

        private static string GetValue(int input)
        {
            throw new NotImplementedException();
        }
    }
}
