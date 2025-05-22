using System.Dynamic;

namespace LINQLearning
{
    // Product object to use for LINQ examples
    public class Product()
    {
        required public int ProductId { get; set; }
        required public string Name { get; set; }
        required public string Category { get; set; }
        public decimal Price { get; set; }
    }
}