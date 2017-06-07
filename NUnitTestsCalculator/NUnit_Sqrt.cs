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

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(2.7, 1.6431)]        
        [TestCase(0, 0)]
        [TestCase(5, 2.236)]
        public void SqrtNUnitTestDouble(double num, double expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("2.7", "1.6431")]     
        [TestCase("0", "0")]
        [TestCase("5", "2.236")]        
        public void SqrtNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Sqrt(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);            
        }


        [TestCase("-3")]
        [TestCase("test")]
        public void SqrtNUnitTestException(string input)
        {            
            Assert.That(() => testCalculator.Sqrt(input),
                Throws.TypeOf<NotFiniteNumberException>());
        }


        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}

