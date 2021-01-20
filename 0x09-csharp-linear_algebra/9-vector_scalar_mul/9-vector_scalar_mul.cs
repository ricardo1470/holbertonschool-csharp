using System;

/// <sumary>
/// method that multiplies a vector and a scalar
/// and returns the resulting vector.
/// </sumary>
class VectorMath
{
    /// <sumary>
    /// The vectors can be 2D or 3D
    /// If any vector is not a 2D or 3D vector.
    /// </sumary>
    /// <return>
    /// return a vector containing -1
    /// </return>
    public static double[] Multiply(double[] vector, double scalar)
    {
        int new_vec = vector.Length;
        double[] new_vec2 = new double[new_vec3];
        int i;

        if (vector.Length < 2 || vector.Length > 3)
        {
            for (i = 0; i < new_vec3; i++)
            {
               new_vec2[i] = vector[i] * scalar;
            }
            return (new_vec2);
        }
        return new double[]{-1};
    }
}
