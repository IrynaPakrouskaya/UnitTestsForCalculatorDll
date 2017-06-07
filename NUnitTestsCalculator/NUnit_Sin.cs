using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Sin
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 0.932)]
        [TestCase(-3, -0.1411)]
        [TestCase(0, 0)]
        public void SinNUnitTestDouble(double num, double expectedResult)
        {
            double actualResult = testCalculator.Sin(num);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCase("1.2", "0.932")]
        [TestCase("-3", "-0.1411")]
        [TestCase("0", "0")]     
        public void SinNUnitTestString(string num, string expectedResult)
        {
            double actualResult = testCalculator.Sin(num);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);           
        }

        [Test]
        public void SinNUnitTestException()
        {
            string input = "test";
            Assert.That(() => testCalculator.Sin(input),
                Throws.TypeOf<NotFiniteNumberException>());
        }

        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
