using StringServiceConsoleClient.StringSearchServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringServiceConsoleClient
{
    class Program
    {
        static void Main()
        {
            StringSearchServiceClient client = new StringSearchServiceClient();

            int stringCount = client.StringFoundCount("This is test text for testing", "test");

            Console.WriteLine(stringCount);
        }
    }
}