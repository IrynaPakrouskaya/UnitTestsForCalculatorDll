using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class Abs
    {
        private CSharpCalculator.Calculator testCalculator;
        
        [OneTimeSetUpAttribute]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase (-8.3, 8.3)]
        [TestCase(0, 0)]
        [TestCase(2, 2)]        
        public void AbsNUnitTestDouble(double num, double expectedResult)
        {            
            double actualResult = testCalculator.Abs(num);            
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("-8.3", "8.3")]
        [TestCase("0", "0")]
        [TestCase("2", "2")]
        [TestCase("test", "test")]
        public void AbsNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Abs(num);
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

        [OneTimeTearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }    
    }
}
