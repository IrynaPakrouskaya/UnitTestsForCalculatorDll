using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{

    [TestClass]
    public class MSTest_Cos
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
        [DataSource("CosStringData")] 
        public void CosMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            string expectedResult = context.DataRow["Result"].ToString();
            double actualResult = testCalculator.Cos(input);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult, 0.0001);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("CosDoubleData")] 
        public void CosMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            double expectedResult = Convert.ToDouble(context.DataRow["Result"]);
            double actualResult = testCalculator.Cos(input);
            Assert.AreEqual(expectedResult, actualResult, 0.0001);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
