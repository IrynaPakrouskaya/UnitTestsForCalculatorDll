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
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumberStringFormat = "-8";
            inputNumberDoubleFormat = -3.2;
        }

        [TestMethod]
        public void absTestString()
        {
            double absResult = testCalculator.Abs(inputNumberStringFormat);
            Assert.AreEqual(Math.Abs(Convert.ToDouble(inputNumberStringFormat)), absResult);
        }

        [TestMethod]
        public void absTestDouble()
        {
            double absResult = testCalculator.Abs(inputNumberDoubleFormat);
            Assert.AreEqual(Math.Abs(inputNumberDoubleFormat), absResult);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            inputNumberStringFormat = null;
            inputNumberDoubleFormat = 0;
        }
    }
}
