using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Simple Calculator in C#");

        while (true)
        {
            // Prompt user to enter the first number
            Console.Write("Enter the first number: ");
            double num1;
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Error: Enter a valid number.");
            }

            // Prompt user to enter the operation
            Console.Write("Choose an operation (+, -, *, /): ");
            string op = Console.ReadLine();

            // Check for valid operation
            if (op != "+" && op != "-" && op != "*" && op != "/")
            {
                Console.WriteLine("Error: Invalid operation.");
                continue;
            }

            // Prompt user to enter the second number
            Console.Write("Enter the second number: ");
            double num2;
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Error: Enter a valid number.");
            }

            double result = 0;

            // Perform the selected operation
            switch (op)
            {
                case "+":
                    result = num1 + num2;
                    break;
                case "-":
                    result = num1 - num2;
                    break;
                case "*":
                    result = num1 * num2;
                    break;
                case "/":
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                    }
                    else
                    {
                        Console.WriteLine("Error: Division by zero.");
                        continue;
                    }
                    break;
            }

            // Display the result
            Console.WriteLine($"Result: {num1} {op} {num2} = {result}");

            // Ask user if they want to continue
            Console.Write("Do you want to continue (yes/no)? ");
            string choice = Console.ReadLine();
            if (choice.ToLower() != "yes")
                break;
        }
    }
}
