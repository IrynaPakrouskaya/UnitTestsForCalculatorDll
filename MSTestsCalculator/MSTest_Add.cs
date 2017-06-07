using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestsCalculator
{
    [TestClass]
    public class MSTest_Add
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
        [DataSource("AddDoubleData")]   
        public void AddMSTestDouble()
        {
            double num1 = Convert.ToDouble(context.DataRow["numberOne"]);
            double num2 = Convert.ToDouble(context.DataRow["numberTwo"]);
            double expectedResult = Convert.ToDouble(context.DataRow["result"]);
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [DeploymentItem("C:\\Users\\Ирина\\Desktop\\TA\\lecture4_UnitTestingFrameworks\\UnitTestsForCalculatorProject\\MSTestsCalculator\\CalculatorTestData.xml")]
        [DataSource("AddStringData")]   
        public void AddMSTestString()
        {
            string num1 = context.DataRow["numberOne"].ToString();
            string num2 = context.DataRow["numberTwo"].ToString();
            string expectedResult = context.DataRow["result"].ToString();
            double actualResult = testCalculator.Add(num1, num2);
            Assert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [ExpectedException(typeof(NotFiniteNumberException))]  
        public void AddMSTestException()
        {
            string num1 = "test";
            string num2 = "test";
            double actalResult = testCalculator.Add(num1, num2);               
        }

        [TestCleanup]
        public void CleanupData()
        {
            testCalculator = null;
        }
    }
}
