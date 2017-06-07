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
        
        [SetUp]
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
        public void AbsNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Abs(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);             
        }

        [Test] 
        public void AbsNUnitTestException()
        {
            string input = "test";
            Assert.That(() => testCalculator.Abs(input),
                Throws.TypeOf<NotFiniteNumberException>());  
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }    
    }
}
