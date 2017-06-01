using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sin
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
        public void sinMSTestString()
        {
            double resultCos = testCalculator.Sin(inputNumberString);
            Assert.AreEqual(Math.Sin(Convert.ToDouble(inputNumberString)), resultCos);
        }

        [TestMethod]
        public void sinMSTestDouble()
        {
            double resultCos = testCalculator.Sin(inputNumberDouble);
            Assert.AreEqual(Math.Sin(inputNumberDouble), resultCos);
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
