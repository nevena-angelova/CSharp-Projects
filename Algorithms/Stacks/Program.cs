using System;

namespace Stacks
{
    class Program
    {
        static void Main()
        {

            //var stack = new LinkedStackOfStrings<string>();


            //var stack = new ResizingArrayStackOfStrings();

            //stack.Push("To ");

            //stack.Push("be ");

            //stack.Push("or ");

            //stack.Push("not ");

            //stack.Push("to ");

            //stack.Push("be. ");

            var stack = new LinkedStackOfStrings<int>();


            stack.Push(1);
            stack.Push(2);

            while (!stack.IsEmpty())
            {
                Console.WriteLine(stack.Pop());
            }


           



        }
    }
}
