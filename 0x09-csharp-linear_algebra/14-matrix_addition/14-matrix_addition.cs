using System;

/// <sumary>
/// method that adds two matrices and returns the resulting matrix
/// </sumary>
class MatrixMath
{
    /// <sumary>
    /// The matrices can be either both 2D or both 3D
    /// If any matrix is not a 2D or 3D matrix,
    /// or both matrices are not the same size
    /// </sumary>
    /// <return>
    /// return a matrix containing -1
    /// </return>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        int i, j;

        if (matrix1.Length  =! matrix2.Length)
        {
            return new double [,] {{-1}};
        }

        for (i = 0; i < matrix1.Length; i++)
        {
            for (j = 0; j < matrix2.Length; j++)
            {
                sum_matrix[i,j] = Math.Round(matrix1[i,j] + matrix2[i,j], 2);
            }
        }
        return (sum_matrix);
    }
}
