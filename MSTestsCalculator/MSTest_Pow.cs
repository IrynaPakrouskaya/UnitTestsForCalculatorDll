using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Pow
    {
        private CSharpCalculator.Calculator testCalculator;

        private TestContext context;

        public TestContext TestContext
        {
            get { return context; }
            set { context = value; }
        } 

        [TestInitialize]
        public void SetUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("PowStringData")] 
        public void PowMSTestString()
        {
            string num1 = context.DataRow["numberOne"].ToString();
            string num2 = context.DataRow["numberTwo"].ToString();
            string expectedResult = context.DataRow["result"].ToString();
            double actualResult = testCalculator.Pow(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("PowDoubleData")] 
        public void PowMSTestDouble()
        {
            double num1 = Convert.ToDouble(context.DataRow["numberOne"]);
            double num2 = Convert.ToDouble(context.DataRow["numberTwo"]);
            double expectedResult = Convert.ToDouble(context.DataRow["result"]);
            double actualresult = testCalculator.Pow(num1, num2);
            Assert.AreEqual(expectedResult, actualresult, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]        
        [DataSource("PowExceptionData")]
        public void PowMSTestException()
        {
            string num1 = context.DataRow["numberOne"].ToString();
            string num2 = context.DataRow["numberTwo"].ToString();            
            double actualResult = testCalculator.Pow(num1, num2);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
