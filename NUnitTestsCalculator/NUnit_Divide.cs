using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace NUnitTestsCalculator
{
    [TestFixture]
    public class NUnit_Divide
    {
        private CSharpCalculator.Calculator testCalculator;

        [SetUp]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestCase(1.2, 2.3, 0.5217)]
        [TestCase(-3, -2.5, 1.2)]
        public void DivideNUnitTestDouble(double num1, double num2, double expectedResult)
        {
            double actualResult = testCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [Test]
        public void DivideNUnitTestException()
        {
            double num1 = 7;
            double num2 = 0;
            Assert.That(() => testCalculator.Divide(num1, num2),
                Throws.TypeOf<NotFiniteNumberException>());
        }
        
        [TearDown]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
