using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Abs
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumberStringFormat;
        private double inputNumberDoubleFormat;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumberStringFormat = "-8";
            inputNumberDoubleFormat = -3.2;
        }

        [TestMethod]
        public void AbsMSTestString()
        {
            double absResult = testCalculator.Abs(inputNumberStringFormat);
            Assert.AreEqual(Math.Abs(Convert.ToDouble(inputNumberStringFormat)), absResult);
        }

        [TestMethod]
        public void AbsMSTestDouble()
        {
            double absResult = testCalculator.Abs(inputNumberDoubleFormat);
            Assert.AreEqual(Math.Abs(inputNumberDoubleFormat), absResult);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
            inputNumberStringFormat = null;
            inputNumberDoubleFormat = 0;
        }
    }
}
