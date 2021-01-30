using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace OddEven.Tests
{
    [TestClass]
    public class TestsOddEven
    {
        [TestMethod]
         public void CanPrintFrom1To50()
        {
            OddEvenClass oddEven = new OddEvenClass();
            int startRange = 1;
            int endRange = 50;
            var result = oddEven.PrintOddEven(startRange, endRange);
            Assert.IsNotNull(result, string.Format("{0}", result));
        }

        [TestMethod]
        public void CanPrintFrom1To100()
        {
            OddEvenClass oddEven = new OddEvenClass();
            int startRange = 1;
            int endRange = 100;
            var result = oddEven.PrintOddEven(startRange, endRange);
            Assert.IsNotNull(result, string.Format("{0}", result));
        }

        [TestMethod]
        public void CanPrintOddEvenForSingleNumber1()
        {
            OddEvenClass oddEven = new OddEvenClass();
            int number = 1;
            var actualresult = oddEven.PrintSingleOddEven(number);
            var expectedresult = "Odd";
            Assert.AreEqual(expectedresult, actualresult);
        }
        [TestMethod]
        public void CanPrintOddEvenForSingleNumber3()
        {
            OddEvenClass oddEven = new OddEvenClass();
            int number = 3;
            var actualresult = oddEven.PrintSingleOddEven(number);
            var expectedresult = "3";
            Assert.AreEqual(expectedresult, actualresult);
        }

        [TestMethod]
        public void CanPrintOddEvenForSingleNumber4()
        {
            OddEvenClass oddEven = new OddEvenClass();
            int number = 4;
            var actualresult = oddEven.PrintSingleOddEven(number);
            var expectedresult = "Even";
            Assert.AreEqual(expectedresult, actualresult);
        }
    }
}
