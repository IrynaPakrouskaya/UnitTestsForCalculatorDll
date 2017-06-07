using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Divide
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
        [DataSource("DivideDoubleData")] 
        public void DivideMSTestDouble()
        {
            double num1 = Convert.ToDouble(context.DataRow["numberOne"]);
            double num2 = Convert.ToDouble(context.DataRow["numberTwo"]);
            double expectedResult = Convert.ToDouble(context.DataRow["result"]);
            double actualresult = testCalculator.Divide(num1, num2);
            Assert.AreEqual(expectedResult, actualresult, 0.0001);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))] 
        public void DivideMSTestException()
        {
            double num1 = 2.5;
            double num2 = 0;
            double actualResult = testCalculator.Divide(num1, num2);         
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
