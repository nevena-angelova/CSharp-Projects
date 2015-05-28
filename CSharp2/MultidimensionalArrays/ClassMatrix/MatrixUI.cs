// Write a class Matrix, to holds a matrix of integers. Overload the operators for adding, subtracting and multiplying of matrices,
// indexer for accessing the matrix content and ToString().

using System;

class MatrixUI
{
    static void Main()
    {
        Matrix matrix1 = new Matrix(2, 2);
        matrix1[0, 1] = 4;
        matrix1[1, 1] = 56;

        Matrix matrix2 = new Matrix(2, 2);
        matrix2[0, 0] = 12;
        matrix2[0, 1] = 10;

        Matrix sum = matrix1 + matrix2;
        Console.WriteLine(sum.ToString());

        Matrix difference = matrix1 - matrix2;
        Console.WriteLine(difference.ToString());

        Matrix result = matrix1 * matrix2;
        Console.WriteLine(result.ToString());
    }
}

