using System;


class VectorMath
{
    /// <sumary>
    /// method that calculates and returns the length of a given vector.
    /// </sumary>
    public static double Magnitude(double[] vector)
    {
        /// <sumary>
        /// The vector can be 2D or 3D
        /// If the vector is not a 2D or 3D vector, <returns> return -1 </returns>
        /// </sumary>
        /// <returns>
        /// The return value should be rounded to the nearest hundredth
        /// </returns>

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        foreach (double side in vector)
        {
            return Math.Sqrt((Math.Pow(side, 2)) + (Math.Pow(side, 2)));
        }
    }
}
