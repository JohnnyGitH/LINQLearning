
namespace LINQLearning
{
    public static class Data
    {
        public static List<char> Alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList();
        public static List<int> Numbers = Enumerable.Range(1, 26).ToList();

        public static List<Product> Products = new List<Product>
        {
            new Product { Name = "Laptop", Category = "Electronics", Price = 1399.99M },
            new Product { Name = "Smartphone", Category = "Electronics", Price = 699.99M },
            new Product { Name = "Bitcoin Miner", Category = "Electronics", Price = 5599.99M },
            new Product { Name = "Chair", Category = "Furniture", Price = 299.99M },
            new Product { Name = "Gaming Desk", Category = "Furniture", Price = 499.99M },
            new Product { Name = "Dresser", Category = "Furniture", Price = 299.99M },
            new Product { Name = "Journal", Category = "Stationary", Price = 29.99M },
            new Product { Name = "Fancy Pen", Category = "Stationary", Price = 199.99M },
            new Product { Name = "Fidget Spinner", Category = "Stationary", Price = 12.99M },
        };

    }
}