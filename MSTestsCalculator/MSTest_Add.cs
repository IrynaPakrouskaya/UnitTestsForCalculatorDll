using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Add
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumber1StringFormat;
        private string inputNumber2StringFormat;
        private double inputNumber1DoubleFormat;
        private double inputNumber2DoubleFormat;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumber1StringFormat = "2.1";
            inputNumber2StringFormat = "-3";
            inputNumber1DoubleFormat = 2.4;
            inputNumber2DoubleFormat = -5;
        }

        [TestMethod]
        public void AddMSTestString()
        {
            double addResult = testCalculator.Add(inputNumber1StringFormat, inputNumber2StringFormat);
            double expectedResult = Convert.ToDouble(inputNumber1StringFormat) + Convert.ToDouble(inputNumber2StringFormat);
            Assert.AreEqual(expectedResult, addResult);
        }

        [TestMethod]
        public void AddMSTestDouble()
        {
            double addResult = testCalculator.Add(inputNumber1DoubleFormat, inputNumber2DoubleFormat);
            double expectedResult = inputNumber1DoubleFormat + inputNumber2DoubleFormat;
            Assert.AreEqual(expectedResult, addResult);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
            inputNumber1StringFormat = null;
            inputNumber2StringFormat = null;
            inputNumber1DoubleFormat = 0;
            inputNumber2DoubleFormat = 0;
        }
    }
}
