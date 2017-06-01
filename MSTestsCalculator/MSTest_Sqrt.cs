using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sqrt
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumberString;
        private double inputNumberDouble;

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumberString = "90.7";
            inputNumberDouble = -90.7;
        }

        [TestMethod]
        public void sqrtMSTestString()
        {
            double actualResult = testCalculator.Sqrt(inputNumberString);
            Assert.AreEqual(Math.Sqrt(Convert.ToDouble(inputNumberString)), actualResult);
        }

        [TestMethod]
        public void sqrtMSTestDouble()
        {
            double actualResult = testCalculator.Sqrt(inputNumberDouble);
            Assert.AreEqual(Math.Sqrt(inputNumberDouble), actualResult);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            inputNumberDouble = 0;
            inputNumberString = null;
        }
    }
}
