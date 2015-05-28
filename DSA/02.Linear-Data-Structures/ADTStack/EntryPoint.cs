/// Implement the ADT stack as auto-resizable array. Resize the capacity on demand
/// (when no space is available to add / insert a new element).
using System;

public class EntryPoint
{
    public static void Main()
    {
        ADTStak<string> fruits = new ADTStak<string>();
        fruits.Push("orange");
        fruits.Push("apple");
        fruits.Push("pear");
        fruits.Push("lemon");
        fruits.Push("grape");
        fruits.Push("watermelon");

        Console.WriteLine(fruits.Capacity);

        fruits.Pop();

        Console.WriteLine(fruits.Peek());
        Console.WriteLine("All Fruits:");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
    }
}
