using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Sqrt
    {
        private CSharpCalculator.Calculator testCalculator;

        [OneTimeSetUpAttribute]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(2.7, 1.6431)]
        [TestCase(-3, Double.NaN)]
        [TestCase(0, 0)]
        [TestCase(5, 2.236)]
        public void SqrtNUnitTestDouble(double num, double expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("2.7", "1.6431")]
        [TestCase("-3", "NaN")]
        [TestCase("0", "0")]
        [TestCase("5", "2.236")]
        [TestCase("test", "NaN")]
        public void SqrtNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            try
            {
                Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
            }
            catch (FormatException)
            {
                Console.WriteLine("Unable to convert {0} to Double", expectedResult);
            }
            catch (OverflowException)
            {
                Console.WriteLine("{0} is outside the range of a Double.", expectedResult);
            }
        }

        [OneTimeTearDownAttribute]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}

