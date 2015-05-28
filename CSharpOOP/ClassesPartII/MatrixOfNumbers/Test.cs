// ex. 8, ex. 9, ex. 10

using System;

namespace MatrixOfNumbers
{
    class Test
    {
        static void Main()
        {
            Matrix<int> matrix1 = new Matrix<int>(3, 3);
            matrix1[0, 0] = 23;
            matrix1[1, 0] = -7;
            matrix1[1, 1] = 14;
            matrix1[2, 2] = 0;
            matrix1[1, 2] = 177;

            Matrix<int> matrix2 = new Matrix<int>(3, 3);
            matrix2[0, 0] = -4;
            matrix2[1, 0] = 1;
            matrix2[1, 1] = 3;
            matrix2[2, 2] = -1;
            matrix2[1, 2] = 2;


            Matrix<int> resultMatrix = matrix1 + matrix2; 

            Console.WriteLine(resultMatrix.ToString()); 

            if (resultMatrix)
            {
                Console.WriteLine("There are not zero elements");
            }
            else
            {
                Console.WriteLine("There are zero elements");
            }

        }
    }
}
