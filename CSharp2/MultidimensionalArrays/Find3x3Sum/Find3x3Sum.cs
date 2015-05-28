// Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.

using System;

class Find3x3Sum
{
    static void Main()
    {
        int n = 6;
        int k = 4;

        int[,] matrix = 
		{
			{0, 2, 4, 0, 9, 5},
			{7, 1, 3, 3, 2, 1},
			{1, 3, 9, 8, 5, 6},
			{4, 6, 7, 9, 1, 0},
		};

        int maxSum = int.MinValue;
        int maxRow = 0;
        int maxCol = 0;
        int sum;

        for (int row = 0; row < matrix.GetLength(0) - 2; row++)
        {
            sum = 0;

            for (int col = 0; col < matrix.GetLength(1) - 2; col++)
            {
                sum = matrix[row, col] + matrix[row, col + 1] + matrix[row, col + 2] +
                    +matrix[row + 1, col] + matrix[row + 1, col + 1] + matrix[row + 1, col + 2] +
                    +matrix[row + 2, col] + matrix[row + 2, col + 1] + matrix[row + 2, col + 2];

                if (sum>maxSum)
                {
                    maxSum = sum;
                    maxRow = row;
                    maxCol = col;
                }
            }
        }

        Console.WriteLine("The sqare of elements with biggest sum is:");

        Console.Write("{0}, {1}, {2}", matrix[maxRow, maxCol], matrix[maxRow, maxCol+1], matrix[maxRow, maxCol+2]);
        Console.WriteLine();
        Console.Write("{0}, {1}, {2}", matrix[maxRow + 1, maxCol], matrix[maxRow + 1, maxCol + 1], matrix[maxRow + 1, maxCol+2]);
        Console.WriteLine();
        Console.Write("{0}, {1}, {2}", matrix[maxRow + 2, maxCol], matrix[maxRow + 2, maxCol + 1], matrix[maxRow + 2, maxCol+2]);

        Console.WriteLine();

        Console.WriteLine("Their sum is: {0}", maxSum);
    }
}

