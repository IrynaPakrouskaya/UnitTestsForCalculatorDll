using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_IsNegative
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
        public void IsNegativeMSTestString()
        {                      
            Assert.IsTrue(testCalculator.isNegative(numberString));
        }

        [TestMethod]
        public void IsNegativeMSTestDouble()
        {
            Assert.IsTrue(testCalculator.isNegative(numberDouble));
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
