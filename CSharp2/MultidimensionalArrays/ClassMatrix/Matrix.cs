using System;

class Matrix
{
    private int[,] matrix;

    // declare constructor (set default state to object of class "Matrix")

    public Matrix(int rows, int cols)
    {
        this.matrix = new int[rows, cols];
    }

    // define indexator

    public int this[int row, int col]
    {
        get
        {
            return this.matrix[row, col];
        }
        set
        {
            this.matrix[row, col] = value;
        }
    }

    // define "Rows" property

    public int Rows
    {
        get
        {
            return this.matrix.GetLength(0);
        }
    }

    // define "Cols" property

    public int Cols
    {
        get
        {
            return this.matrix.GetLength(1);
        }
    }

    // override the operators +, - and *

    public static Matrix operator +(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] + second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator -(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] - second[row, col];
            }
        }

        return result;
    }

    public static Matrix operator *(Matrix first, Matrix second)
    {
        Matrix result = new Matrix(first.Rows, first.Cols);

        for (int row = 0; row < first.Rows; row++)
        {
            for (int col = 0; col < first.Cols; col++)
            {
                result[row, col] = first[row, col] * second[row, col];
            }
        }

        return result;
    }

    // override ToString

    public override string ToString()
    {
        string result = null;

        for (int row = 0; row < this.Rows; row++)
        {
            for (int col = 0; col < this.Cols; col++)
            {
                result += matrix[row, col] + " ";
            }

            result += Environment.NewLine;
        }

        return result;
    }
}

