// Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
// x2 + 5 = 1x2 + 0x + 5 -> {5,0,1}

using System;

class AddPolynomials
{
    static void Main()
    {

        int[] firstPolynom = new int[3];
        int[] secondPolynom = new int[3];   

        Console.WriteLine("Enter coefficients for x^2, x^1, x^0");
        Console.WriteLine("First polynomal: ");
        FillArray(firstPolynom);
        Console.WriteLine("Second polynomal: ");
        FillArray(secondPolynom);

        // print the entered polynomials

        Console.WriteLine();
        PrintPolynom(firstPolynom);
        PrintPolynom(secondPolynom);

        // print the sum

        Console.WriteLine();
        Console.WriteLine("The sum is:");
        Console.WriteLine();
        PrintPolynom(Sum(firstPolynom, secondPolynom));

        //print the difference

        Console.WriteLine();
        Console.WriteLine("The difference is:");
        Console.WriteLine();
        PrintPolynom(Substract(firstPolynom, secondPolynom));

        // print the result of multiplying

        Console.WriteLine();
        Console.WriteLine("The result of multiplying is:");
        Console.WriteLine();
        PrintPolynom(Мultiply(firstPolynom, secondPolynom));

        Console.WriteLine();
    }

    // sums the polynomials

    static int[] Sum(int[] firstArray, int[] secondArray)
    {
        int[] resultArray = new int[3];

        for (int i = 0; i < 3; i++)
        {
            resultArray[i] = firstArray[i] + secondArray[i];
        }

        return resultArray;
    }

    // devides the polynomials

    static int[] Substract(int[] firstArray, int[] secondArray)
    {
        int[] resultArray = new int[3];

        for (int i = 0; i < 3; i++)
        {
            resultArray[i] = firstArray[i] - secondArray[i];
        }

        return resultArray;
    }

    // multiply the polynomials

    static int[] Мultiply(int[] firstArray, int[] secondArray)
    {
        int[] resultArray = new int[3];

        for (int i = 0; i < 3; i++)
        {
            resultArray[i] = firstArray[i] * secondArray[i];
        }

        return resultArray;
    }

    // fills the array in reversed order

    static void FillArray(int[] array)
    {
        for (int i = 2; i >=0 ; i--)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
    }

    // prints the polynomials array in reversed order

    static void PrintPolynom(int[] array)
    {
        for (int i = 2; i >= 0; i--)
        {
            if ((array[i] < 0) || (i == 2))
            {
                Console.Write("{0}x^{1}", array[i], i);
            }
            else
            {
                Console.Write("+{0}x^{1}", array[i], i);
            }
        }
        Console.WriteLine();
    }
}

