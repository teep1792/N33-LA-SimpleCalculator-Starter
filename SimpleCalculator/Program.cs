using System;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Boolean t = true;
            while (t)
            {
                try
                {
                    // Class to convert user input


                    // Class to perform actual calculations
                    CalculatorEngine calculatorEngine = new CalculatorEngine();


                    Console.WriteLine("Input a number");
                    double firstNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.WriteLine("Input a number");
                    double secondNumber = InputConverter.ConvertInputToNumeric(Console.ReadLine());
                    Console.WriteLine("Input an operator");
                    string operation = Console.ReadLine();

                    double result = calculatorEngine.Calculate(operation, firstNumber, secondNumber);
                    double resultr = Math.Round(result, 2);
                    string line = String.Format("The result of {0}{1}{2} is : {3}", firstNumber, operation, secondNumber, resultr);
                    
                    Console.WriteLine(line);
                    t = false;
                    Console.ReadLine();






                }
                catch (Exception ex)
                {
                    // Normally, we'd log this error to a file.
                    Console.WriteLine("Make sure to input Numbers in the first two cases\nand an operator such as '+', '-', '*', '/', 'add', 'substract', 'multiply' or 'divide'");
                    Console.ReadLine();
                    t = true;
                }
            }

        }
    }
}
