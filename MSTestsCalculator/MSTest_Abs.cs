using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;



namespace UnitTestsCalculator
{
    [TestClass]    
    public class Abs
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumberStringFormat;
        private double inputNumberDoubleFormat;                   

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator(); 
            inputNumberStringFormat = "-8";
            inputNumberDoubleFormat = -3.2;
        }        
                
        [TestMethod]
        public void absTestString()
        {
            double absResult = testCalculator.Abs(inputNumberStringFormat);
            Assert.AreEqual(Math.Abs(Convert.ToDouble(inputNumberStringFormat)), absResult);         
        }

        [TestMethod]
        public void absTestDouble()
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

    [TestClass]
    public class Add
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumber1StringFormat;
        private string inputNumber2StringFormat;
        private double inputNumber1DoubleFormat;
        private double inputNumber2DoubleFormat;

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumber1StringFormat = "2.1";
            inputNumber2StringFormat = "-3";
            inputNumber1DoubleFormat = 2.4;
            inputNumber2DoubleFormat = -5;               
        }

        [TestMethod]
        public void addTestString()
        {
            double addResult = testCalculator.Add(inputNumber1StringFormat, inputNumber2StringFormat);
            double expectedResult = Convert.ToDouble(inputNumber1StringFormat) + Convert.ToDouble(inputNumber2StringFormat);
            Assert.AreEqual(5, addResult);
        }

        [TestMethod]
        public void addTestDouble()
        {
            double addResult = testCalculator.Add(inputNumber1DoubleFormat, inputNumber2DoubleFormat);
            double expectedResult = inputNumber1DoubleFormat + inputNumber2DoubleFormat;
            Assert.AreEqual(expectedResult, addResult);
        }

        [TestCleanup]
        public void clenupData()
        {
            testCalculator = null;
            inputNumber1StringFormat = null;
            inputNumber2StringFormat = null;
            inputNumber1DoubleFormat = 0;
            inputNumber2DoubleFormat = 0;   
        }
    }

    [TestClass]
    public class Cos
    {
        private CSharpCalculator.Calculator testCalculator;
        private string inputNumberString;
        private double inputNumberDouble;

        [TestInitialize]
        public void setUpData()
        {
            testCalculator = new CSharpCalculator.Calculator();
            inputNumberString = "90.7";
            inputNumberDouble = -90.7;
        }
        
        [TestMethod]
        public void cosTestString()
        {            
            double resultCos = testCalculator.Cos(inputNumberString);
            Assert.AreEqual(Math.Cos(Convert.ToDouble(inputNumberString)), resultCos);
        }

        [TestMethod]
        public void cosTestDouble()
        {
            double resultCos = testCalculator.Cos(inputNumberDouble);
            Assert.AreEqual(Math.Cos(inputNumberDouble), resultCos);
        }

        [TestCleanup]
        public void cleanupData()
        {
            testCalculator = null;
            inputNumberDouble = 0;
            inputNumberString = null;
        }       
    }
   
}
