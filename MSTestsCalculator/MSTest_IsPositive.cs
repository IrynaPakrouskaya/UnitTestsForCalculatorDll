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
        public void SetupData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            numberString = "-8.9";
            numberDouble = -2.7;
        }

        [TestMethod]
        public void IsPositiveMSTestString()
        {
            Assert.IsFalse(testCalculator.isPositive(numberString));
        }

        [TestMethod]
        public void IsPositiveMSTestDouble()
        {
            Assert.IsFalse(testCalculator.isPositive(numberDouble));
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
            numberString = null;
            numberDouble = 0;
        }
    }
}
