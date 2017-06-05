using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class Pow
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(-8.3, 8.3, Double.NaN)]
        [TestCase(0, 0, Double.NaN)]
        [TestCase(2, -2, 0.25)]
        [TestCase(5, 3, 125)]
        [TestCase(-6.5, 2, 42.25)]
        public void PowNUnitTestDouble(double num, double pow, double expectedResult)
        {
            double actualResult = testCalculator.Pow(num, pow);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("-8.3", "8.3", "NaN")]
        [TestCase("0", "0", "NaN")]
        [TestCase("2", "-2", "0.25")]
        [TestCase("5", "3", "125")]
        [TestCase("-6.5", "2", "42.25")]
        [TestCase("test", "test", "NaN")]
        public void PowNUnitTestString(string num, string pow, string expectedResult)
        {
            double actualResult = testCalculator.Pow(num, pow);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);           
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}

