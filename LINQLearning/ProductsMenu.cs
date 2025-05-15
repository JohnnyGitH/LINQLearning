namespace LINQLearning
{
    public static class ProductsMenu
    {
        public static void Show()
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Products Menu");
                Console.WriteLine("1. Products Ascending by Name");
                Console.WriteLine("2. Products Descending by Name");
                Console.WriteLine("3. Products where the price is greater than 500$");
                Console.WriteLine("3. Products by category and name");
                Console.WriteLine("3. Only the first 3 products");
                Console.WriteLine("3. Products In Furniture Category");
                Console.WriteLine("3. Print Collection");
                Console.WriteLine("3. Print Collection");
                Console.WriteLine("4. Back to Main Menu");
                Console.Write("\nEnter your choice: ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    case "1":
                        var ascending = Data.Products.OrderBy(c => c.Name);
                        Console.WriteLine("Products in Ascending Order by Name: ");
                        Console.WriteLine(String.Join(", ", ascending));
                        break;
                    case "2":
                        var descending = Data.Products.OrderByDescending(p => p.Name);
                        Console.WriteLine("Products in Descending Order by Name: ");
                        Console.WriteLine(String.Join(", ", descending));
                        break;
                    case "3":
                        Console.WriteLine("Print out all the products in the collection:  ");
                        Console.WriteLine(String.Join(", ", Data.Products));
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