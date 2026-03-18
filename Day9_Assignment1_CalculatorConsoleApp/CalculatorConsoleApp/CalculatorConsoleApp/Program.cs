using System;

namespace CalculatorConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            calculator calculator = new calculator();

            Console.WriteLine("Enter first number:");
            double num1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter second number:");
            double num2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Choose operation: +, -, *, /");
            string operation = Console.ReadLine();

            try
            {
                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = calculator.Add(num1, num2);
                        break;

                    case "-":
                        result = calculator.Subtract(num1, num2);
                        break;

                    case "*":
                        result = calculator.Multiply(num1, num2);
                        break;

                    case "/":
                        result = calculator.Divide(num1, num2);
                        break;

                    default:
                        Console.WriteLine("Invalid Operation");
                        return;
                }

                Console.WriteLine("Result: " + result);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.ReadLine();
        }
    }
}