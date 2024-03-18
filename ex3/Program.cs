using System;
using System.Linq;


namespace ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
                while (true)
                {
                    Console.WriteLine("Number Checker Menu");
                    Console.WriteLine("1. Even or Odd Checker");
                    Console.WriteLine("2. Palindrome Checker");
                    Console.WriteLine("3. Prime Number Checker");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter your choice (1-4): ");
                    int choice = int.Parse(Console.ReadLine());

                    switch (choice)
                    {
                        case 1:
                            CheckEvenOrOdd();
                            break;

                        case 2:
                            CheckPalindrome();
                            break;

                        case 3:
                            CheckPrimeNumber();
                            break;

                        case 4:
                            Console.WriteLine("Exiting the program. Goodbye!");
                            return;

                        default:
                            Console.WriteLine("Invalid choice. Please choose a number between 1 and 4.");
                            break;
                    }

                    Console.WriteLine();
                }
            }

            static void CheckEvenOrOdd()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (number % 2 == 0)
                {
                    Console.WriteLine($"{number} is an even number.");
                }
                else
                {
                    Console.WriteLine($"{number} is an odd number.");
                }
            }

            static void CheckPalindrome()
            {
                Console.Write("Enter a word or phrase: ");
                string input = Console.ReadLine().ToLower(); 
                string reversed = new string(input.Reverse().ToArray());

                if (input == reversed)
                {
                    Console.WriteLine($"{input} is a palindrome.");
                }
                else
                {
                    Console.WriteLine($"{input} is not a palindrome.");
                }
            }

            static void CheckPrimeNumber()
            {
                Console.Write("Enter a number: ");
                int number = int.Parse(Console.ReadLine());

                if (IsPrime(number))
                {
                    Console.WriteLine($"{number} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{number} is not a prime number.");
                }
            }

            static bool IsPrime(int num)
            {
                if (num < 2)
                    return false;

                for (int i = 2; i <= Math.Sqrt(num); i++)
                {
                    if (num % i == 0)
                        return false;
                }

                return true;
            }
        }
    }

