using System;
using System.Text;

namespace SubstringExtension
{
    public static class Extension
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int length)
        {
            string temp = strBuilder.ToString().Substring(startIndex, length);

            StringBuilder result = new StringBuilder();
            result.Append(temp);

            return result;
        }
    }

    public class SubstringExtension
    {
        static void Main()
        {
            StringBuilder testStrBuilder = new StringBuilder();

            testStrBuilder.Append("Implement an extension method Substring");

            Console.WriteLine(testStrBuilder.Substring(3, 12));
        }
    }
}
