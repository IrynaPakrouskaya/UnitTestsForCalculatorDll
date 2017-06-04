using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Cos
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumberString;
        private double inputNumberDouble;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumberString = "90.7";
            inputNumberDouble = -90.7;
        }

        [TestMethod]
        public void CosMSTestString()
        {
            double resultCos = testCalculator.Cos(inputNumberString);
            Assert.AreEqual(Math.Cos(Convert.ToDouble(inputNumberString)), resultCos);
        }

        [TestMethod]
        public void CosMSTestDouble()
        {
            double resultCos = testCalculator.Cos(inputNumberDouble);
            Assert.AreEqual(Math.Cos(inputNumberDouble), resultCos);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
            inputNumberDouble = 0;
            inputNumberString = null;
        }
    }
}
