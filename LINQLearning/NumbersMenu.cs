namespace LINQLearning
{
    public static class NumbersMenu
    {
        public static void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Number Menu");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                Console.WriteLine("3. Sum");
                Console.WriteLine("4. Print Collection");
                Console.WriteLine("5. Back to Main Menu");
                Console.Write("\nEnter your choice: ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        var ascending = Data.Numbers.OrderBy(n => n);
                        Console.WriteLine("Numbers in Ascending Order: ");
                        Console.WriteLine(string.Join(", ", ascending));
                        break;
                    case "2":
                        var descending = Data.Numbers.OrderByDescending(n => n);
                        Console.WriteLine("Numbers in Descending Order: ");
                        Console.WriteLine(string.Join(", ", descending));
                        break;
                    case "3":
                        var sum = Data.Numbers.Sum();
                        Console.WriteLine("Sum of the numbers");
                        Console.WriteLine($"Sum of the numbers: {sum}");
                        break;
                    case "4":
                        Console.WriteLine("Numbers are : " + string.Join(", ", Data.Numbers));
                        return;
                    default:
                        Console.WriteLine("Invalid Choice, choose again.");
                        break;
                }
                Console.WriteLine("\n Press any key to continue...");
                Console.ReadKey();

            }
        }
    }
}