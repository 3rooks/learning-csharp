using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, world!");

            Console.WriteLine("Username:");
            string? userName = Console.ReadLine();

            Console.WriteLine("Age:");
            string? ageString = Console.ReadLine();

            if (int.TryParse(ageString, out int userAge))
            {
                Console.WriteLine($"Hello, {userName}! You are {userAge} years old.");
            }
            else
            {
                Console.WriteLine("Invalid age value.");
            }
        }
    }
}
