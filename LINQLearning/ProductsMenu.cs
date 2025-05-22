namespace LINQLearning
{
    // Menu of Product options
    // Each option performs a specific LINQ function or two on
    // the products list.
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
                Console.WriteLine("3. Print Collection");
                Console.WriteLine("4. Take the first 3 Products and print them");
                Console.WriteLine("5. Show me the distinct categories");
                Console.WriteLine("6. Skip a product");
                Console.WriteLine("7. Chunk the Product list in 5 Products");
                Console.WriteLine("8. Are All products more expensive than $5000.00?");
                Console.WriteLine("9. Are Any products called 'Laptop'?");
                Console.WriteLine("10. Contains Method example");
                Console.WriteLine("11. SequenceEqual Method example");
                Console.WriteLine("12. SequenceEqual Method properties example // TODO");
                Console.WriteLine("13. Return to main menu");

                Console.Write("\nEnter your choice: ");

                var selection = Console.ReadLine();

                switch (selection)
                {
                    // OrderBy method - Orders the products in ascending order
                    case "1":
                        var ascending = Data.Products.OrderBy(c => c.Name);
                        Console.WriteLine("Products in Ascending Order by Name: ");
                        Console.WriteLine(String.Join(",\n ", ascending.Select(p => p.Name)));
                        break;
                    // OrderByDescending - Orders the products in descending order
                    case "2":
                        var descending = Data.Products.OrderByDescending(p => p.Name);
                        Console.WriteLine("Products in Descending Order by Name: ");
                        Console.WriteLine(String.Join(", ", descending.Select(p => p.Name)));
                        break;
                    // Print em all out
                    case "3":
                        Console.WriteLine("Print out all the products in the collection:  " + String.Join(", ", Data.Products));
                        foreach (var prod in Data.Products)
                        {
                            Console.WriteLine($"{prod.ProductId} , {prod.Name} , {prod.Category} , {prod.Price} \n");
                        }
                        break;
                    // Take method
                    case "4":
                        // Take example Data.Products.Take(3)
                        var takeMethod = Data.Products.Take(3);
                        Console.WriteLine($"The list contains: {Data.Products.Count} number of products");
                        foreach (var prod in Data.Products)
                        {
                            Console.WriteLine(prod.Name + "\n");
                        }
                        Console.WriteLine($"After the Take(3), we have the first {takeMethod.Count()} items in the list \n");
                        foreach (var prod2 in takeMethod)
                        {
                            Console.WriteLine(prod2.Name + "\n");
                        }
                        break;
                    // Distinct method
                    case "5":
                        var distinctCategory = Data.Products.Select(p => p.Category).Distinct().OrderBy(m => m);
                        Console.WriteLine("Distinct Product Categories: ");
                        Console.WriteLine(String.Join(", ", distinctCategory));
                        break;
                    // Skip method - List all Products, skip one, list again
                    case "6":
                        var skipMethod = Data.Products.Skip(6); // Skip 6 products
                        Console.WriteLine("Full List: \n");
                        foreach (var prod in Data.Products)
                        {
                            Console.WriteLine(prod.Name + "\n");
                        }
                        Console.WriteLine("Skipped List: \n");
                        foreach (var prod2 in skipMethod)
                        {
                            Console.WriteLine(prod2.Name + "\n");
                        }
                        break;
                    // Chunk method - Into 5's and iterate
                    case "7":
                        var chunks = Data.Products.Chunk(5);
                        int chunkNum = 1;
                        foreach (var chunk in chunks)
                        {
                            Console.WriteLine($"Chunk {chunkNum} \n");
                            foreach (var prod in chunk)
                            {
                                Console.WriteLine($" - {prod.Name}");
                            }
                            Console.WriteLine();
                            chunkNum++;
                        }
                        break;
                    // All method (returns a boolean)
                    case "8":
                        decimal expensive = 5000;
                        var allMethod = Data.Products.All(prod => prod.Price > expensive);
                        Console.WriteLine($"Are all products more expensive than $5000.00? {allMethod}");
                        break;
                    // Any method (returns a boolean)
                    case "9":
                        var anyMethod = Data.Products.Any(prod => prod.Name == "Laptop");
                        Console.WriteLine($"Do any of the product names happen to be Laptop? {anyMethod}");
                        break;
                    // Contains method
                    case "10":
                        ProductIdComparer pc = new();
                        var containMethodTrue = Data.Products.Contains(new Product { ProductId = 2, Name = "Bitcoin Miner", Category = "Electronics" }, pc);
                        var containMethodFalse = Data.Products.Contains(new Product { ProductId = 10, Name = "Fidget Spinner", Category = "Stationary" }, pc);
                        Console.WriteLine($"Is there a product that contains the Id 2 ? {containMethodTrue}");
                        Console.WriteLine($"Is there a product that contains the Id 10 ? {containMethodFalse}");
                        break;
                    // SequenceEqual method
                    case "11":
                        var firstList = Data.Products.Select(prod => prod);
                        var secondList = Data.Products.Select(prod => prod);
                        var diffList = Data.Products.Select(prod => prod).ToList();
                        diffList[0] = new Product
                        {
                            ProductId = 99,
                            Name = "blahblah",
                            Category = "Random"
                        };
                        Console.WriteLine($"Are these two equal lists actually equal? {firstList.SequenceEqual(secondList)}");
                        Console.WriteLine($"Is the diffList and firstList equal? {firstList.SequenceEqual(diffList)}");
                        break;
                    // SequenceEqual Object properties method
                    case "12":
                        // TODO
                        break;
                    case "13":
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