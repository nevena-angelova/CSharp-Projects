// ex. 8, ex. 9, ex. 10

using System;
using System.Text;


namespace MatrixOfNumbers
{
    public class Matrix<T>
    {
        private T[,] matrix;
        private int rows;
        private int cols;

        public Matrix(int rows, int cols)
        {
            this.matrix = new T[rows, cols];
            this.rows = rows;
            this.cols = cols;
        }

        public T this[int rows, int cols]
        {
            get { return this.matrix[rows, cols]; }
            set { this.matrix[rows, cols] = value; }
        }

        // operators + 

        public static Matrix<T> operator +(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.rows != m2.rows || m1.cols != m2.cols)
            {
                throw new ArgumentException("The matrices have to be with the same size.");
            }

            Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.cols; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] + m2[row, col];
                }
            }

            return result;
        }

        // operators -

        public static Matrix<T> operator -(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.rows != m2.rows || m1.cols != m2.cols)
            {
                throw new ArgumentException("The matrices have to be with the same size.");
            }

            Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.cols; col++)
                {
                    result[row, col] = (dynamic)m1[row, col] - m2[row, col];
                }
            }

            return result;
        }

        // operators *

        public static Matrix<T> operator *(Matrix<T> m1, Matrix<T> m2)
        {

            if (m1.cols != m2.rows)
            {
                throw new ArgumentException("The matrices have to be with the same size.");
            }

            Matrix<T> result = new Matrix<T>(m1.rows, m1.cols);

            for (int row = 0; row < m1.rows; row++)
            {
                for (int col = 0; col < m1.cols; col++)
                {
                    dynamic sum = 0;

                    for (int i = 0; i < m1.cols; i++)
                    {
                        sum += (dynamic)m1[row, i] * m2[i, col];
                    }

                    result[row, col] = sum;
                }
            }

            return result;
        }

        // implement true operator

        public static bool operator true(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if ((dynamic)matrix[row, col] == 0)
                    {
                        return false;
                    }
                }
            }

            return true;
        }

        // implement false operator

        public static bool operator false(Matrix<T> matrix)
        {
            for (int row = 0; row < matrix.rows; row++)
            {
                for (int col = 0; col < matrix.cols; col++)
                {
                    if ((dynamic)matrix[row, col] != 0)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        // override ToString()

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            for (int row = 0; row < this.rows; row++)
            {
                for (int col = 0; col < this.cols; col++)
                {
                    result.Append(this.matrix[row, col] + " ");
                }

                result.Append(Environment.NewLine);
            }

            return result.ToString();
        }
    }
}
