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

        [OneTimeSetUpAttribute]
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
        [TestCase("test", "test", "test")]
        public void AddNUnitTestString(string num1, string num2, string expectedResult)
        {
            double actualResult = testCalculator.Add(num1, num2);
            try
            {
                Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
            }           
            catch(FormatException)
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
