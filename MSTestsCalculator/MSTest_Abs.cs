using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestsCalculator
{
    [TestClass]    
    public class Abs
    {
        public CSharpCalculator.Calculator testCalculator;
        public string inputNumberStringFormat;
        public double inputNumberDoubleFormat;                   

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator(); 
            inputNumberStringFormat = "-8";
            inputNumberDoubleFormat = -3.2;
        }        
                
        [TestMethod]
        public void absTestString(string inputNumberStringFormat)
        {
            double absResult = testCalculator.Abs(inputNumberStringFormat);
            Assert.AreEqual(Math.Abs(Convert.ToDouble(inputNumberStringFormat)), absResult);         
        }

        [TestMethod]
        public void absTestDouble(double inputNumberDoubleFormat)
        {
            double absResult = testCalculator.Abs(inputNumberDoubleFormat);
            Assert.AreEqual(Math.Abs(inputNumberDoubleFormat), absResult);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            inputNumberStringFormat = null;
            inputNumberDoubleFormat = 0;
        }
    }
}
