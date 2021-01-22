using System;

namespace _18_matrix_matrix_mul
{
}
    /// <sumary>
    /// method that multiplies two matrices,
    /// and returns the resulting matrix.
    /// </sumary>
    class MatrixMath
    {
        /// <sumary>
        /// The matrices will not necessarily
        /// be square or the same dimensions
        /// If the matrices cannot be multiplied,
        /// </sumary>
        /// <return>
        /// return a matrix containing -1
        /// </return>
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
            double [,] mult_matrix = new double [matrix1.GetLength(0), matrix1.GetLength(1)];
            double temp, temp2;

            if (matrix1.GetLength(0) != matrix2.GetLength(0)
                || matrix1.GetLength(0) < 2|| matrix1.GetLength(0) > 3
                || matrix2.GetLength(0) < 2|| matrix2.GetLength(0) > 3
                || matrix1.GetLength(1) < 2|| matrix1.GetLength(1) > 3
                || matrix2.GetLength(1) < 2|| matrix2.GetLength(1) > 3)
                {
                    return new double [,] {{-1}};
                }

            for (int i = 0; i < temp.GetLength(0); i++)
            {
                for (int j = 0; j < temp.GetLength(1); j++)
                {
                    for (int k = 0; k < temp.GetLength(0); k++)
                    {
                        temp2 += matrix1[i, k] * matrix2[k, j]
                    }
                    temp[i, j] = Math.Round(temp2, 2);
                }
            }
            return (temp);
        }
    }
