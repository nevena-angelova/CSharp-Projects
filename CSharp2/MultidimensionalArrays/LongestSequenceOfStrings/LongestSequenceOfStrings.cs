//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements
//located on the same line, column or diagonal. Write a program that finds the longest sequence of equal strings in the matrix.

using System;

class LongestSequenceOfStrings
{
    static void Main()
    {
        string[,] stringMatrix =
       {
        {"ha", "fifi", "ho", "hi"},
        {"fo","ha","hi","xx"},
        {"xxx", "ho","ha","xx"}

        //{"s","qq","s",},
        //{"p","pp","s"},
        //{"pp","qq","s"}

      };

        int horizontalSum = 0;
        int verticalSum = 0;
        int diagonalSum = 0;
        int reverseDiagonalSum = 0;
        int sum;

        string lastItem = "";


        // the for loops compere every element with the relevant for horizontal, vertical, diagonal and reverse diagonal.
        // every loop start and end value depend on the compared items.

        // horizontal

        for (int row = 0; row < stringMatrix.GetLength(0); row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row, col + 1])
                {
                    horizontalSum++;
                    lastItem = stringMatrix[row, col];
                }
            }
        }

        // vertical

        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1); col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row + 1, col])
                {
                    verticalSum++;
                    lastItem = stringMatrix[row, col];
                }
            }
        }

        // diagonal


        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            for (int col = 0; col < stringMatrix.GetLength(1) - 1; col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row + 1, col + 1])
                {
                    diagonalSum++;
                    lastItem = stringMatrix[row, col];
                }
            }
        }

        // reverse diagonal

        for (int row = 0; row < stringMatrix.GetLength(0) - 1; row++)
        {
            for (int col = 1; col < stringMatrix.GetLength(1); col++)
            {
                if (stringMatrix[row, col] == stringMatrix[row + 1, col - 1])
                {
                    reverseDiagonalSum++;
                    lastItem = stringMatrix[row, col];
                }
            }
        }

        // take the max sum of the four.

        sum = Math.Max(horizontalSum, Math.Max(verticalSum, Math.Max(diagonalSum, reverseDiagonalSum)));

        // print the lastItem of the max sequence "sum" times

        for (int row = 0; row <= sum; row++)
        {
            Console.WriteLine("{0} ", lastItem);
        }
    }
}

