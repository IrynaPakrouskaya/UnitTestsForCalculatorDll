using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Multiply
    {
        private CSharpCalculator.Calculator testCalculator;

        [OneTimeSetUpAttribute]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 2.3, 2.76)]
        [TestCase(-3, -2.5, 7.5)]
        [TestCase(7, 0, 0)]
        public void MultiplyNUnitTestDouble(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Multiply(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [OneTimeTearDownAttribute]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
