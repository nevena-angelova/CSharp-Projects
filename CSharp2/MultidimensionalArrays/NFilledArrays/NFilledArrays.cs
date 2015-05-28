// Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4)
using System;

class NFilledArrays
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());

        int[,] matrix = new int[n, n];

        //MatrixA(n, matrix);
        //MatrixB(n, matrix);
        MatrixD(n, matrix);
        PrintMatrix(matrix, n);
    }

    // Prints the matrix
    static void PrintMatrix(int[,] matrix, int n)
    {

        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write("{0,3}", matrix[row, col]);
            }
            Console.WriteLine();
        }
    }

    // a) fills each row item in the first col, than in the second col and so on with the counter's value.

    static void MatrixA(int n, int[,] MatrixA)
    {
        int counter = 0;

        for (int cols = 0; cols < n; cols++)
        {
            for (int rows = 0; rows < n; rows++)
            {
                counter++;
                MatrixA[rows, cols] = counter;
            }
        }
    }

    // b) fills each row item in the cols analogously to the previous, but here the rows index start from 0 when
    // the col's index is even and from n-1 when odd.

    static void MatrixB(int n, int[,] matrixB)
    {
        int counter = 0;

        for (int cols = 0; cols < n; cols++)
        {
            if (cols % 2 == 0)
            {
                for (int rows = 0; rows < n; rows++)
                {
                    counter++;
                    matrixB[rows, cols] = counter;
                }
            }
            else
            {
                for (int rows = n - 1; rows >= 0; rows--)
                {
                    counter++;
                    matrixB[rows, cols] = counter;
                }
            }
        }
    }

    // d http://www.youtube.com/watch?feature=player_detailpage&v=UPiodKGLsS4#t=2795s

    static void MatrixD(int n, int[,] spiral)
    {
        int currentCol = 0;
        int currentRow = 0;

        string direction = "down";

        for (int i = 1; i <= n * n; i++)
        {

            if (direction == "down" && (currentRow >= n || spiral[currentRow, currentCol] != 0))
            {
                direction = "right";
                currentRow--;
                currentCol++;
            }
            else if (direction == "right" && (currentCol >= n || spiral[currentRow, currentCol] != 0))
            {
                direction = "up";
                currentCol--;
                currentRow--;
            }
            else if (direction == "up" && (currentRow < 0 || spiral[currentRow, currentCol] != 0))
            {
                direction = "left";
                currentCol--;
                currentRow++;
            }

            else if (direction == "left" && (currentCol < 0 || spiral[currentRow, currentCol] != 0))
            {
                direction = "down";
                currentCol++;
                currentRow++;
            }

            spiral[currentRow, currentCol] = i;

            if (direction == "right")
            {
                currentCol++;
            }
            else if (direction == "down")
            {
                currentRow++;
            }
            else if (direction == "left")
            {
                currentCol--;
            }
            else if (direction == "up")
            {
                currentRow--;
            }
        }
    }
}

