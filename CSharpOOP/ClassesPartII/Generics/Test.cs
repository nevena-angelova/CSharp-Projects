using System;

namespace Generics
{
    class Test
    {
        static void Main()
        {
            GenericList<int> intList = new GenericList<int>(5);
            intList.AddElement(23);
            intList.AddElement(3);
            intList.AddElement(13);
            intList.AddElement(22);
            intList.AddElement(-7);

            // *** test *** accsess element by index

            //Console.WriteLine(intList[2]);
            

            // *** test *** Remove Element

            //intList.RemoveElement(2);



            // *** test *** Insert Element At

            //intList.InsertElementAt(4,2);



            // *** test *** Clear Elements

            //intList.ClearElements();

            //intList.AddElement(23);
            //intList.AddElement(3);



            // *** test *** Find Element By Value

            //int elementIndex = intList.FindElementByValue(13);

            //if (elementIndex > 0)
            //{
            //    Console.WriteLine("Found at index: {0}", elementIndex);
            //}
            //else
            //{
            //    Console.WriteLine("Not found!");
            //}


            // *** test *** ToString 

            //Console.WriteLine(intList.ToString());

            // *** test *** Auto Grow (ex. 6)

            //intList.AddElement(-7);
            //intList.AddElement(21);

            // *** test *** find minimum (ex. 7)

            //int min = GenericList<int>.Min<int>(intList);
            //Console.WriteLine("The minimum number is: {0}", min);

            // *** test *** find maximum (ex. 7)

            int max = GenericList<int>.Max<int>(intList);
            Console.WriteLine("The maximum number is: {0}", max);

        }
    }
}
