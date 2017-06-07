using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sub
    {
        private TestContext context;

        public TestContext TestContext
        {
            get { return context; }
            set { context = value; }
        } 
        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();   
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("SubStringData")]  
        public void SubMSTestString()
        {
            string num1 = context.DataRow["numberOne"].ToString();
            string num2 = context.DataRow["numberTwo"].ToString();
            string expectedResult = context.DataRow["result"].ToString();
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("SubDoubleData")]
        public void SubMSTestDouble()
        {
            double num1 = Convert.ToDouble(context.DataRow["numberOne"]);
            double num2 = Convert.ToDouble(context.DataRow["numberTwo"]);
            double expectedResult = Convert.ToDouble(context.DataRow["result"]);
            double actualResult = testCalculator.Sub(num1, num2);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void SubMSTestException()
        {
            string num1 = "test";
            string num2 = "test";
            double actalResult = testCalculator.Sub(num1, num2);
        }

        [TestCleanup]
        public void ClenupData()
        {
            testCalculator = null;
        }
    }
}
