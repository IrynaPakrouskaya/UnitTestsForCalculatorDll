using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sqrt
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
        [DataSource("SqrtStringData")]
        public void SqrtMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            string expectedResult = context.DataRow["Result"].ToString();
            double actualResult = testCalculator.Sqrt(input);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("SqrtDoubleData")] 
        public void SqrtMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            double expectedResult = Convert.ToDouble(context.DataRow["Result"]);
            double actualResult = testCalculator.Sqrt(input);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("SqrtExceptionData")]
        public void SqrtMSTestException()
        {
            string input = context.DataRow["inputParameter"].ToString();            
            double actualResult = testCalculator.Sqrt(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
