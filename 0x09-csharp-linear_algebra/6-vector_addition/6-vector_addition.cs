﻿using System;

/// <sumary>
/// method that adds two vectors and returns the resulting vector.
/// </sumary>
class VectorMath
{
    /// <sumary>
    /// The vectors can be 2D or 3D
    /// If any vector is not a 2D or 3D vector,
    /// or if the vectors are not of the same size
    /// </sumary>
    /// <return> return a vector containing -1 </return>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        Vector vectorResult = new Vector();
        
        if (vector1.Length != vector2.Length || vector1.Length < 2 || vector1.Length > 3
        || vector2.Length < 2 || vector2.Length > 3)
        {
            for (int i = 0; i < vector1.Length; i++)
                sumVector[i] = vector1[i] + vector2[i];
                vectorResult = Vector.Add(vector1, vector2);
            return vectorResult;

        }
        else  { return new double[]{-1}; }
    }
}
