using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_IsNegative
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
        [DataSource("IsNegativeStringData")] 
        public void IsNegativeMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            bool expectedResult = Convert.ToBoolean(context.DataRow["Result"]);
            bool actualResult = testCalculator.isNegative(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("IsNegativeDoubleData")] 
        public void IsNegativeMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            bool expectedResult = Convert.ToBoolean(context.DataRow["Result"]);
            bool actualResult = testCalculator.isNegative(input); 
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))] 
        public void IsNegativeMSTestException()
        {
            string input = "test";
            bool actualResult = testCalculator.isNegative(input);          
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
