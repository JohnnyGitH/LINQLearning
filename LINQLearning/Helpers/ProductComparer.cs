using System.Diagnostics.CodeAnalysis;

namespace LINQLearning
{
    // Comparer Class
    public class ProductIdComparer : IEqualityComparer<Product>
    {
        public bool Equals(Product? x, Product? y)
        {
            // return true on a match
            return (x.ProductId == y.ProductId);
        }

        public int GetHashCode([DisallowNull] Product obj)
        {
            // Create a unique value from the property
            return obj.ProductId.GetHashCode();
        }
    }
}