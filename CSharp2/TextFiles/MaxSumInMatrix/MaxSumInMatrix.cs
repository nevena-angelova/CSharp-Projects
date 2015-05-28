// Write a program that reads a text file containing a square matrix of numbers and finds in the matrix an area of size 2 x 2 with
// a maximal sum of its elements. The first line in the input file contains the size of matrix N.
// Each of the next N lines contain N numbers separated by space. The output should be a single number in a separate text file. Example:
// 4
// 2 3 3 4
// 0 2 3 4 -> 17
// 3 7 1 2
// 4 3 3 2

using System;
using System.IO;

class MaxSumInMatrix
{
    static void Main()
    {
        string inputFileName = @"..\..\input.txt";
        StreamReader reader = new StreamReader(inputFileName);

        string outputFileName = @"..\..\output.txt";
        StreamWriter writer = new StreamWriter(outputFileName);

        using (reader)
        using (writer)
        {
            int n = int.Parse(reader.ReadLine());

            int[,] matrix = new int[n, n];

            // every "i" time creates lineItems string array which contains the items of a line from the
            // input text file "Split" by space. Then adds the elements of lineItems array to the matrix.

            for (int i = 0; i < n; i++)
            {
                string[] lineItems = reader.ReadLine().Split(' ');

                for (int j = 0; j < n; j++)
                {
                    matrix[i, j] = int.Parse(lineItems[j]);
                }
            }

            // finds max sum

            int sum;
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
            {
                sum = 0;

                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    sum = matrix[row, col] + matrix[row, col + 1] +
                       +matrix[row + 1, col] + matrix[row + 1, col + 1];

                    if (sum > maxSum)
                    {
                        maxSum = sum;
                    }
                }
            }

            // writes the result to the output text file

            writer.WriteLine(maxSum);

            Console.WriteLine("Done!");
        }
    }
}

