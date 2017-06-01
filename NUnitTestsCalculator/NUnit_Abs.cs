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
        [Test]
        public void testAbsNUnit()
        {
            //Arrange
            CSharpCalculator.Calculator testCalculator = new CSharpCalculator.Calculator();

            //Act
            double absResult = testCalculator.Abs("-2");

            //Assert
            Assert.AreEqual(2, absResult);
        }
    }
}
