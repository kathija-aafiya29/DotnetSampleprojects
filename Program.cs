using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nSelect a Program to Run:");
            Console.WriteLine("1. Hello World");
            Console.WriteLine("2. Simple Calculator");
            Console.WriteLine("3. Number Guessing Game");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    HelloWorld();
                    break;
                case 2:
                    SimpleCalculator();
                    break;
                case 3:
                    NumberGuessingGame();
                    break;
                case 4:
                    return; // Exit the program
                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void HelloWorld()
    {
        Console.WriteLine("Hello, World!");
    }

    static void SimpleCalculator()
    {
        Console.Write("Enter first number: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter an operator (+, -, *, /): ");
        char op = Console.ReadLine()[0];

        Console.Write("Enter second number: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = 0;
        switch (op)
        {
            case '+':
                result = num1 + num2;
                break;
            case '-':
                result = num1 - num2;
                break;
            case '*':
                result = num1 * num2;
                break;
            case '/':
                result = num2 != 0 ? num1 / num2 : double.NaN;
                break;
            default:
                Console.WriteLine("Invalid operator!");
                return;
        }
        Console.WriteLine($"Result: {result}");
    }

    static void NumberGuessingGame()
    {
        Random random = new Random();
        int targetNumber = random.Next(1, 101);
        int guess = 0;
        int attempts = 0;

        Console.WriteLine("Guess the number between 1 and 100:");

        while (guess != targetNumber)
        {
            Console.Write("Enter your guess: ");
            guess = Convert.ToInt32(Console.ReadLine());
            attempts++;

            if (guess < targetNumber)
            {
                Console.WriteLine("Too low!");
            }
            else if (guess > targetNumber)
            {
                Console.WriteLine("Too high!");
            }
            else
            {
                Console.WriteLine($"Correct! You guessed the number in {attempts} attempts.");
            }
        }
    }
}
