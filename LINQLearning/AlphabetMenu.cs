namespace LINQLearning
{
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
                    case "1":
                        var ascending = Data.Alphabet.OrderBy(c => c);
                        Console.WriteLine("Alphabet in Ascending Order: ");
                        Console.WriteLine(String.Join(", ", ascending));
                        break;
                    case "2":
                        var descending = Data.Alphabet.OrderByDescending(c => c);
                        Console.WriteLine("Alphabet in Descending Order: ");
                        Console.WriteLine(String.Join(", ", descending));
                        break;
                    case "3":
                        Console.WriteLine("Alphabet in Descending Order: ");
                        Console.WriteLine(String.Join(", ", Data.Alphabet));
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