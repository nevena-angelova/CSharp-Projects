// Write a program that parses an URL address given in the format: [protocol]://[server]/[resource]
// and extracts from it the [protocol], [server] and [resource] elements. 

using System;

class URLExtract
{
    static void Main()
    {
        Console.WriteLine("Enter url:");
        string inputUrl = Console.ReadLine();
        Uri url = new Uri(inputUrl);

        Console.WriteLine("[protocol] = {0}", url.Scheme);
        Console.WriteLine("[server] = {0}", url.Host);
        Console.WriteLine("[resourse] = {0}", url.AbsolutePath);
    }
}

