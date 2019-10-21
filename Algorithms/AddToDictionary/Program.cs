using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddToDictionary
{
    class Program
    {
        static void Main(string[] args)
        {

            var dictionary = new Dictionary<string, decimal>();



            var flowers = new List<string> { "marigold", "rose", "dasy", "orchid", "tulip", "tulip", "tulip", "rose", };



            foreach (var flower in flowers)
            {
                if (!dictionary.ContainsKey(flower))
                {
                    dictionary.Add(flower, 0);
                }

                dictionary[flower]++;
            }


            foreach (var item in dictionary)
            {
                Console.WriteLine(item.Key+ " - " + item.Value);
            }



        }
    }
}
