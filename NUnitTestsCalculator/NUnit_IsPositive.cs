using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_IsPositive
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, true)]
        [TestCase(-3, false)]
        [TestCase(0, false)]
        public void IsPositiveNUnitTestDouble(double num, bool expectedResult)
        {
            bool actualResult = testCalculator.isPositive(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("1.2", true)]
        [TestCase("-3", false)]
        [TestCase("0", false)]
        public void IsPositiveNUnitTestString(string num, bool expectedResult)
        {
            bool actualResult = testCalculator.isPositive(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
