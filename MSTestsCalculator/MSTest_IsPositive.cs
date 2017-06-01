using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_IsPositive
    {
        private CSharpCalculator.Calculator testCalculator;
        private string numberString;
        private double numberDouble;

        [TestInitialize]
        public void setupData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            numberString = "-8.9";
            numberDouble = -2.7;
        }

        [TestMethod]
        public void isPositiveMSTestString()
        {
            Assert.IsFalse(testCalculator.isPositive(numberString));
        }

        [TestMethod]
        public void isPositiveMSTestDouble()
        {
            Assert.IsFalse(testCalculator.isPositive(numberDouble));
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            numberString = null;
            numberDouble = 0;
        }
    }
}
