using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace SimpleCalculatorProject.Test.Unit
{
    [TestClass]
    public class CalculateEngineTest
    {
        private readonly CalculatorEngine calculatorEngine = new CalculatorEngine();

        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultsForNonSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("add", number1, number2);
            Assert.AreEqual(3, result);


        }
        [TestMethod]
        public void AddTwoNumbersAndReturnValidResultsForSymbolOperation()
        {

            int number1 = 1;
            int number2 = 2;
            double result = calculatorEngine.Calculate("+", number1, number2);
            Assert.AreEqual(3, result);


        }
    }
}
