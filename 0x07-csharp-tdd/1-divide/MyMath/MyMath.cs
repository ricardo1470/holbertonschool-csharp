﻿using System;

namespace MyMath
{
    ///<summary>
    /// method that divides all elements of a matrix.
    ///</summary>
    public class Matrix
    {
        ///<summary>
        /// returns a matrix
        ///</summary>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int i, j;

            if (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return (null);
            }
            if (matrix == null)
            {
                return (null);
            }
            for (i = 0; i < matrix.GetLength(0); i++)
            {
                for (j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = matrix[i, j] / num;
                }
            }
            return (matrix);
        }
    }
}
