using System;

namespace LINQLearning
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Johnny's LINQ Demo");
                Console.WriteLine("Make a selection from the following:");
                Console.WriteLine("1. Alphabet");
                Console.WriteLine("2. Numbers");
                Console.WriteLine("3. Products");
                Console.WriteLine("4. Exit");
                Console.Write("\nEnter your choice: ");

                var choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AlphabetMenu.Show();
                        break;
                    case "2":
                        NumbersMenu.Show();
                        break;
                    case "3":
                        ProductsMenu.Show();
                        break;
                    case "4":
                        Console.WriteLine("Goodbye!");
                        return;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        Console.ReadKey();
                        break;
                }
            }
        }
    }
}