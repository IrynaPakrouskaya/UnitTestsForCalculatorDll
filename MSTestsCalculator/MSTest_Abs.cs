using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Abs
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
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\AbsData.xml")]
        [DataSource("AbsDoubleData")]    
        public void AbsMSTestDouble()
        {
            double input = Convert.ToDouble(context.DataRow["InputParameter"]);
            double expectedResult = Convert.ToDouble(context.DataRow["Result"]);
            double actualResult = testCalculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\AbsData.xml")]
        [DataSource("AbsStringData")]
        public void AbsMSTestString()
        {
            string input = context.DataRow["InputParameter"].ToString();
            string expectedResult = context.DataRow["Result"].ToString();
            double actualResult = testCalculator.Abs(input);
            Assert.AreEqual(Convert.ToDouble(expectedResult), actualResult);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;            
        }
    }
}
