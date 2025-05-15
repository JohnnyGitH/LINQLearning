using System.Dynamic;

namespace LINQLearning
{
    public class Product()
    {

        required public string Name { get; set; }
        required public string Category { get; set; }
        public decimal Price { get; set; }
    }
}