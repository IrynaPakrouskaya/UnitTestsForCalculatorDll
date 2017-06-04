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
        [DataSource("AbsData")]    
        public void AbsMSTestDouble()
        {
            double input = Double.Parse(context.DataRow["InputParameter"].ToString());
            double expectedResult = Double.Parse(context.DataRow["Result"].ToString());
            double actualResult = testCalculator.Abs(input);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;            
        }
    }
}
