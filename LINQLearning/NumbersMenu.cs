namespace LINQLearning
{
    // Menu of Number options
    // Each option performs a specific LINQ function or two on
    // the numbers list.
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
                Console.WriteLine("5. Contains method example");
                Console.WriteLine("6. SequenceEquals method example");
                Console.WriteLine("7. Back to Main Menu");
                Console.Write("\nEnter your choice: ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    // OrderBy method - Orders the numbers in Ascending order
                    case "1":
                        var ascending = Data.Numbers.OrderBy(n => n);
                        Console.WriteLine("Numbers in Ascending Order: ");
                        Console.WriteLine(string.Join(", ", ascending));
                        break;
                    // OrderByDescending method - Orders the numbers in descending order
                    case "2":
                        var descending = Data.Numbers.OrderByDescending(n => n);
                        Console.WriteLine("Numbers in Descending Order: ");
                        Console.WriteLine(string.Join(", ", descending));
                        break;
                    // Sum method - Adds up all the numbers in the list for a total
                    case "3":
                        var sum = Data.Numbers.Sum();
                        Console.WriteLine("Sum of the numbers");
                        Console.WriteLine($"Sum of the numbers: {sum}");
                        break;
                    // Prints the numbers in the list
                    case "4":
                        Console.WriteLine("Numbers are : " + string.Join(", ", Data.Numbers));
                        break;
                    // Contains method
                    case "5":
                        var ninetyNine = Data.Numbers.Contains(99);
                        var twelve = Data.Numbers.Contains(12);
                        Console.WriteLine($"Does this list of numbers contain 99? {ninetyNine}");
                        Console.WriteLine($"Does this list of numbers contain 12? {twelve}");
                        break;
                    // SequenceEqual method
                    case "6":
                        var sEqualF = Data.Numbers.SequenceEqual(Data.NumbersDiff);
                        var sEqualT = Data.Numbers.SequenceEqual(Data.Numbers);
                        Console.WriteLine($"Does the number list match the number diff list? {sEqualF}");
                        Console.WriteLine($"Does the number list match the number list? {sEqualT}");
                        break;
                    case "7":
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