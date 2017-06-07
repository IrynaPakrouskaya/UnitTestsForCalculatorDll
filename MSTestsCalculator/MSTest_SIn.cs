using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Sin
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
        [DataSource("SinStringData")]
        public void SinMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            string expectedResult = context.DataRow["Result"].ToString();
            double actualResult = testCalculator.Sin(input);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("SinDoubleData")] 
        public void SinMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            double expectedResult = Convert.ToDouble(context.DataRow["Result"]);
            double actualResult = testCalculator.Sin(input);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);        
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]
        public void SinMSTestException()
        {
            string input = "test";
            double actualResult = testCalculator.Sin(input);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
