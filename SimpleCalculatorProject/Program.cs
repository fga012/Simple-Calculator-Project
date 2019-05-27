using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculatorProject
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                var calculatorEngine = new CalculatorEngine();


                double firstNumber = Convert.ToDouble(Console.ReadLine());
                double secondNumber = Convert.ToDouble(Console.ReadLine());
                string operation = Console.ReadLine();

                double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);

                Console.WriteLine(result);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }

    public class CalculatorEngine
    {
        public double Calculate(string operation, double firstNumber, double secondNumber)
        {
            double result;
            switch (operation.ToLower())
            {
                case "add":
                case "+":
                    result = firstNumber + secondNumber;
                    break;
                case "subtract":
                case "-":
                    result = firstNumber - secondNumber;
                    break;
                case "multiply":
                case "*":
                    result = firstNumber * secondNumber;
                    break;
                case "divide":
                case "/":
                    result = firstNumber / secondNumber;
                    break;
                default:
                    throw new InvalidOperationException("Specified operation not recognized");

            }
            return result;
        }


    }
}
