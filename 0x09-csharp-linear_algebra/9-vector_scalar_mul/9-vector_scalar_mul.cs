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
        Vector vectorResult = new Vector();

        if (vector.Length < 2 || vector.Length > 3)
        {
            return new double[] {-1};
        }

        vectorResult = Vector.Multiply(scalar, vector);
        return vectorResult;
    }
}
