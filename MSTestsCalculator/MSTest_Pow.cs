using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Pow
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumber1String;
        private string inputNumber2String;
        private double inputNumber1Double;
        private double inputNumber2Double;

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumber1String = "9.7";
            inputNumber2String = "-1.2";
            inputNumber1Double = 3;
            inputNumber2Double = 3;
        }

        [TestMethod]
        public void powMSTestString()
        {
            double resultCos = testCalculator.Pow(inputNumber1String, inputNumber2String);
            double expectedResult = Math.Pow(Convert.ToDouble(inputNumber1String), Convert.ToDouble(inputNumber2String));
            Assert.AreEqual(expectedResult, resultCos);
        }

        [TestMethod]
        public void powMSTestDouble()
        {
            double resultCos = testCalculator.Pow(inputNumber1Double, inputNumber2Double);
            Assert.AreEqual(Math.Pow(inputNumber1Double, inputNumber2Double), resultCos);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            inputNumber1String = null;
            inputNumber2String = null;
            inputNumber1Double = 0;
            inputNumber2Double = 0;
        }
    }
}
