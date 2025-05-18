namespace LINQLearning
{
    // Menu of Alphabet options
    // Each option performs a specific LINQ function or two on
    // the alphabet list.
    public static class AlphabetMenu
    {
        public static void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Alphabet Menu");
                Console.WriteLine("1. Ascending");
                Console.WriteLine("2. Descending");
                Console.WriteLine("3. Print Collection");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("\nEnter your choice: ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    // OrderBy method - Orders the alphabet in ascending order
                    case "1":
                        var ascending = Data.Alphabet.OrderBy(c => c);
                        Console.WriteLine("Alphabet in Ascending Order: ");
                        Console.WriteLine(String.Join(", ", ascending));
                        break;
                    // OrderByDescending method - Orders the alphabet in descending order
                    case "2":
                        var descending = Data.Alphabet.OrderByDescending(c => c);
                        Console.WriteLine("Alphabet in Descending Order: ");
                        Console.WriteLine(String.Join(", ", descending));
                        break;
                    // Printing out the collection
                    case "3":
                        Console.WriteLine("The alphabet is : " + String.Join(", ", Data.Alphabet));
                        break;
                    case "4":
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