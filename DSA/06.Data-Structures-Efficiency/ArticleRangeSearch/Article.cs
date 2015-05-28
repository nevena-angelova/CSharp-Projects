using System;

namespace ArticleRangeSearch
{
    public class Article : IComparable<Article>
    {
        public int Barcode { get; set; }

        public string Vendor { get; set; }

        public string Name { get; set; }

        public double Price { get; set; }

        public int CompareTo(Article other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
