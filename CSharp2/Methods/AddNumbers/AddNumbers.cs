// Write a method that adds two positive integer numbers represented as arrays of digits
// (each array element arr[i] contains a digit; the last digit is kept in arr[0]).
// Each of the numbers that will be added could have up to 10 000 digits.
using System;

class AddNumbers
{
    static void Main()
    {
        Console.Write("first number = ");
        int num1 = int.Parse(Console.ReadLine());
        Console.Write("second number = ");
        int num2 = int.Parse(Console.ReadLine());

        int[] firstNumArray = new int[5];
        int[] secondNumArray = new int[5];

        NumberAsArray(num1, firstNumArray);
        NumberAsArray(num2, secondNumArray);

        int[] sumNumArray = AddNumArrays(firstNumArray, secondNumArray);

        int result = ArrayToNumber(sumNumArray);

        Console.WriteLine("sum = {0}", result);
    }

    // sums the numbers from the first and the second array in another array

    static int[] AddNumArrays(int[] firstArray, int[] secondArray)
    {
        int arrLenght = firstArray.Length;
        int[] sumArray = new int[arrLenght];
        sumArray[0] = (firstArray[0] + secondArray[0]) % 10;

        for (int i = 1; i < arrLenght; i++)
        {
            sumArray[i] = (firstArray[i] + secondArray[i]) % 10 + (firstArray[i - 1] + secondArray[i - 1]) / 10;
        }
        return sumArray;
    }

    // represent the number as array

    static void NumberAsArray(int num, int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = num % 10;
            num /= 10;
        }
    }

    // add the array elements one next to another in a string in a reversed order then convert the string to int.

    static int ArrayToNumber(int[] array)
    {
        string sumString = String.Empty;

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sumString += array[i];
        }

        int sum = int.Parse(sumString);

        return sum;
    }
}

