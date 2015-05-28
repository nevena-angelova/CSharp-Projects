using System;
using Wintellect.PowerCollections;

namespace ArticleRangeSearch
{
    class Program
    {
        static void Main()
        {
            OrderedMultiDictionary<double, Article> articles = new OrderedMultiDictionary<double, Article>(true);

            Random rnd = new Random();
            double price;

            for (int i = 0; i < 1000000; i++)
            {
                price = rnd.Next(10, 100000);

                Article article = new Article
                {
                    Barcode = rnd.Next(9000, 9999),
                    Vendor = GetRandomString(rnd).ToUpper(),
                    Name = GetRandomString(rnd),
                    Price = price
                };

                articles.Add(price, article);
            }

            var selectedArticles = articles.Range(500, true, 510, true);

            foreach (var article in selectedArticles)
            {
                Console.WriteLine(article.Key);
                foreach (var value in article.Value)
                {
                    Console.WriteLine("barcode: {0}, vendor: {1}, name: {2}, price: {3};",
                                        value.Barcode, value.Vendor, value.Name, value.Price);
                }
            }
        }

        private static string GetRandomString(Random rnd)
        {
            return new string(((char)rnd.Next(65, 91)), rnd.Next(5, 12));
        }
    }
}