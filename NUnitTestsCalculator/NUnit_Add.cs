using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Add
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 2.3, 3.5)]
        [TestCase(-3, -2.5, -5.5)]
        public void AddNUnitTestDouble(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("1.2", "2.3", "3.5")]
        [TestCase("-3", "-2.5", "-5.5")]
        [TestCase("test", "test", "NaN")]
        public void AddNUnitTestString(string num1, string num2, string expectedResult)
        {
            double actualResult = testCalculator.Add(num1, num2);         
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);           
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
