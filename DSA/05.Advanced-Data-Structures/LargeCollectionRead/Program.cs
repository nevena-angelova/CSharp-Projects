using System;
using Wintellect.PowerCollections;

namespace LargeCollectionRead
{
    class Program
    {
        static void Main()
        {
            OrderedBag<Product> products = new OrderedBag<Product>();
            int numberOfProducts = 500000;
            int numberOfSearches = 10000;

            for (int i = 0; i < numberOfProducts; i++)
            {
                products.Add(new Product { Name = "Product", Price = i });
            }

            var lowProduct = new Product { Name = "low", Price = 0 };
            var highProduct = new Product { Name = "high", Price = 19 };

            var selectedProducts;

            for (int i = 0; i < numberOfSearches; i++)
            {
                lowProduct.Price++;
                highProduct.Price++;

                selectedProducts = products.Range(highProduct, true, lowProduct, true).Reversed();

                foreach (var product in selectedProducts)
                {
                    Console.WriteLine("name: {0}, price: {1}", product.Name, product.Price);
                }

                Console.WriteLine("Press Enter to continue searching...");
                Console.ReadLine();
            }
        }
    }
}
