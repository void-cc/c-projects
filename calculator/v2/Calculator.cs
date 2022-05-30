using System;

namespace Calculator
{
    class Calculator
    {
        public static double DoOperation(double val1, double val2, string op)
        {
            double result = double.NaN; // Default value is "not-a-number" if an operation, such as division, could result in an error.

            // Use a switch statement to do the math.
            switch (op)
            {
                case "A":
                case "a":
                    result = val1 + val2;
                    break;
                case "B":
                case "b":
                    result = val1 - val2;
                    break;
                case "C":
                case "c":
                    result = val1 * val2;
                    break;
                case "D":
                case "d":
                    // Ask the user to enter a non-zero divisor.
                    if (val2 != 0)
                    {
                        result = val1 / val2;
                    }
                    break;
                // Return text for an incorrect option entry.
                default:
                    break;
            }
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool endApp = false;
            // Display title as the C# console calculator app.
            Console.WriteLine("Calculator\r");
            Console.WriteLine("----------\n");

            while (!endApp)
            {
                // Declare variables and set to empty.
                string numInput1 = "";
                string numInput2 = "";
                double result = 0;

                // Ask the user to type the first number.
                Console.Write("Type a number, and then press Enter: ");
                numInput1 = Console.ReadLine();

                double cleanval1 = 0;
                while (!double.TryParse(numInput1, out cleanval1))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput1 = Console.ReadLine();
                }

                // Ask the user to type the second number.
                Console.Write("Type another number, and then press Enter: ");
                numInput2 = Console.ReadLine();

                double cleanval2 = 0;
                while (!double.TryParse(numInput2, out cleanval2))
                {
                    Console.Write("This is not valid input. Please enter an integer value: ");
                    numInput2 = Console.ReadLine();
                }

                // Ask the user to choose an operator.
                Console.WriteLine("What sort of calculation would you like to perform:");
                Console.WriteLine("|- a - Add");
                Console.WriteLine("|- b - Subtract");
                Console.WriteLine("|- c - Multiply");
                Console.WriteLine("|- d - Divide");
                Console.Write("choose your option? ");

                string op = Console.ReadLine();

                try
                {
                    result = Calculator.DoOperation(cleanval1, cleanval2, op);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("This operation will result in a mathematical error. Please try again\n");
                    }
                    else Console.WriteLine("Your result: {0:0.##}\n", result);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Oh no! An exception occurred trying to do the math.\n - Details: " + e.Message);
                }

                Console.WriteLine("------------------------\n");

                // Wait for the user to respond before closing.
                Console.Write("Press 'x' and Enter to close the app, or press Enter to continue: ");
                if (Console.ReadLine() == "x") endApp = true;

                Console.WriteLine("\n");
            }
            return;
        }
    }
}
