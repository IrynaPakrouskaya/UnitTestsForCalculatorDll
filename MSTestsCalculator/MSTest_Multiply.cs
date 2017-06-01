using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Multiply
    {
        private CSharpCalculator.Calculator testCalculator;
        private double number1Double;
        private double number2Double;

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            number1Double = 0.8;
            number2Double = -10.9;
        }

        [TestMethod]
        public void multiplyTestDouble()
        {
            double resultDivide = testCalculator.Multiply(number1Double, number2Double);
            double expectedResult = number1Double * number2Double;
            Assert.AreEqual(expectedResult, resultDivide);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            number1Double = 0;
            number2Double = 0;
        }

    }
}
