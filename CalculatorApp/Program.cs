using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter the first number: ");
                if (!double.TryParse(Console.ReadLine(), out double num1))
                {
                    Console.WriteLine("Error: input is not a number.");
                    continue;
                }

                Console.WriteLine("Choose an operation by entering the number:");
                Console.WriteLine("1. Addition (+)");
                Console.WriteLine("2. Subtraction (-)");
                Console.WriteLine("3. Multiplication (*)");
                Console.WriteLine("4. Division (/)");

                Console.Write("Enter your choice (1-4): ");
                if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 1 || choice > 4)
                {
                    Console.WriteLine("Number must be between 1 and 4.");
                    continue;
                }

                Console.Write("Enter the second number: ");
                if (!double.TryParse(Console.ReadLine(), out double num2))
                {
                    Console.WriteLine("Error: input is not a number.");
                    continue;
                }

                double result = 0;
                bool isValid = true;

                switch (choice)
                {
                    case 1:
                        result = num1 + num2;
                        break;
                    case 2:
                        result = num1 - num2;
                        break;
                    case 3:
                        result = num1 * num2;
                        break;
                    case 4:
                        if (num2 == 0)
                        {
                            Console.WriteLine("Cannot divide by 0.");
                            isValid = false;
                        }
                        else
                        {
                            result = num1 / num2;
                        }
                        break;
                    default:
                        isValid = false;
                        break;
                }

                if (isValid)
                {
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Invalid operation or input. Please try again.");
                }

            }
        }
    }
}