using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_IsNegative
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, false)]
        [TestCase(-3, true)]
        [TestCase(0, false)]
        public void IsNegativeNUnitTestDouble(double num, bool expectedResult)
        {  
            bool actualResult = testCalculator.isNegative(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCase("1.2", false)]
        [TestCase("-3", true)]
        [TestCase("0", false)]
        [TestCase("test", Double.NaN)]
        public void IsNegativeNUnitTestString(string num, bool expectedResult)
        {
            bool actualResult = testCalculator.isNegative(num);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
