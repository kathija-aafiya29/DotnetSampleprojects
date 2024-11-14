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
            Console.WriteLine("5. Factorial Calculator");
            Console.WriteLine("6. Palindrome Checker");
            Console.WriteLine("7. Fibonacci Sequence");
            Console.WriteLine("8. Prime Number Checker");
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
                case 5:
                    FactorialCalculator();
                    break;
                case 6:
                    PalindromeChecker();
                    break;
                case 7:
                    FibonacciSequence();
                    break;
                case 8:
                    PrimeNumberChecker();
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
    static void FactorialCalculator()
    {
        Console.Write("Enter a number to find its factorial: ");
        int number = Convert.ToInt32(Console.ReadLine());
        long factorial = 1;

        for (int i = 1; i <= number; i++)
        {
            factorial *= i;
        }

        Console.WriteLine($"Factorial of {number} is: {factorial}");
    }
    static void PalindromeChecker()
    {
        Console.Write("Enter a word or number to check if it's a palindrome: ");
        string input = Console.ReadLine();
        string reversed = new string(input.Reverse().ToArray());

        if (input.Equals(reversed, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{input} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a palindrome.");
        }
    }
    static void FibonacciSequence()
    {
        Console.Write("Enter the number of terms for the Fibonacci sequence: ");
        int terms = Convert.ToInt32(Console.ReadLine());

        int first = 0, second = 1, next;

        Console.WriteLine("Fibonacci sequence:");
        for (int i = 0; i < terms; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
        Console.WriteLine();
    }
    static void PrimeNumberChecker()
    {
        Console.Write("Enter a number to check if it's prime: ");
        int number = Convert.ToInt32(Console.ReadLine());
        bool isPrime = true;

        if (number < 2)
            isPrime = false;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }

        Console.WriteLine(isPrime ? $"{number} is a prime number." : $"{number} is not a prime number.");
    }

}
