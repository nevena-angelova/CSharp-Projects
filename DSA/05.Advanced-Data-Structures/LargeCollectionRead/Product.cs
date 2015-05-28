using System;

namespace LargeCollectionRead
{
    public class Product : IComparable<Product>
    {
        public string Name { get; set; }

        public int Price { get; set; }

        public int CompareTo(Product product)
        {
            if (this.Price > product.Price)
            {
                return -1;
            }
            if (this.Price < product.Price)
            {
                return 1;
            }
            return 0;
        }
    }
}
