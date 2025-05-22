
namespace LINQLearning
{
    // Data class that holds all the different lists of Alphabet / Numbers and Products
    // Alphabet is the standard english alphabet
    // Numbers are 1 to 26
    // Product objects with Name Category and Price properties
    // Added additional lists and properties for more complex LINQ functionality
    public static class Data
    {
        public static List<char> Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();

        public static List<char> AlphabetDiff = "QAJXLZEVKFWDUBTMNOGSCHRPIY".ToList();
        public static List<int> Numbers = Enumerable.Range(1, 26).ToList();

        public static List<int> NumbersDiff = new[] { 14, 2, 21, 5, 12, 1, 26, 19, 16, 4, 11, 24, 7, 3, 9, 23, 13, 17, 25, 6, 8, 27, 10, 20, 15, 18, 22 }.ToList();

        public static List<Product> Products = new List<Product>
        {
            new Product { ProductId = 1, Name = "Laptop", Category = "Electronics", Price = 1399.99M },
            new Product { ProductId = 2, Name = "Smartphone", Category = "Electronics", Price = 699.99M },
            new Product { ProductId = 3, Name = "Bitcoin Miner", Category = "Electronics", Price = 5599.99M },
            new Product { ProductId = 4, Name = "Chair", Category = "Furniture", Price = 299.99M },
            new Product { ProductId = 5, Name = "Gaming Desk", Category = "Furniture", Price = 499.99M },
            new Product { ProductId = 6, Name = "Dresser", Category = "Furniture", Price = 299.99M },
            new Product { ProductId = 7, Name = "Journal", Category = "Stationary", Price = 29.99M },
            new Product { ProductId = 8, Name = "Fancy Pen", Category = "Stationary", Price = 199.99M },
            new Product { ProductId = 9, Name = "Fidget Spinner", Category = "Stationary", Price = 12.99M },
        };

    }
}