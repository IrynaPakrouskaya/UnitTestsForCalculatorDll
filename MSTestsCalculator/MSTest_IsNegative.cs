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
        public void setupData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            numberString = "-8.9";
            numberDouble = -2.7;
        }

        [TestMethod]
        public void isNegativeMSTestString()
        {                      
            Assert.IsTrue(testCalculator.isNegative(numberString));
        }

        [TestMethod]
        public void isNegativeMSTestDouble()
        {
            Assert.IsTrue(testCalculator.isNegative(numberDouble));
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
