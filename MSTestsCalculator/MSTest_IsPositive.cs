using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_IsPositive
    {
        private TestContext context;

        public TestContext TestContext
        {
            get { return context; }
            set { context = value; }
        } 

        private CSharpCalculator.Calculator testCalculator;

        [TestInitialize]
        public void SetupData()
        {
            testCalculator = new CSharpCalculator.Calculator();
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("IsPositiveStringData")] 
        public void IsPositiveMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            bool expectedResult = Convert.ToBoolean(context.DataRow["Result"]);
            bool actualResult = testCalculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("IsPositiveDoubleData")] 
        public void IsPositiveMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            bool expectedResult = Convert.ToBoolean(context.DataRow["Result"]);
            bool actualResult = testCalculator.isPositive(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void IsPositiveMSTestException()
        {
            string input = "test";
            bool actualResult = testCalculator.isPositive(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
