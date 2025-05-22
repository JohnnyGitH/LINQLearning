using System.Diagnostics.CodeAnalysis;

namespace LINQLearning
{
    public class ProductObjectComparer : EqualityComparer<Product>
    {
        public override bool Equals(Product? x, Product? y)
        {
            return (x.ProductId == y.ProductId &&
                    x.Name == y.Name &&
                    x.Category == y.Category &&
                    x.Price == y.Price);
        }

        public override int GetHashCode([DisallowNull] Product obj)
        {
            String value = obj.ProductId.ToString() +
                obj.Name +
                obj.Category +
                obj.Price.ToString();

            return value.GetHashCode();
        }
    }
}