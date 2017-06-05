using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Sub
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 2.3, -1.1)]
        [TestCase(-3, -2.5, -0.5)]
        [TestCase(8, 7, 1)]
        public void SubNUnitTestDouble(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("1.2", "2.3", "-1.1")]
        [TestCase("-3", "-2.5", "-0.5")]
        [TestCase("8", "7", "1")]
        [TestCase("test", "test", "NaN")]
        public void SubNUnitTestString(string num1, string num2, string expectedResult)
        {
            double actualResult = testCalculator.Sub(num1, num2);           
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);           
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
