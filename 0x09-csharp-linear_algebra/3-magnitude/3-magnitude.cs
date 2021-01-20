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
        /// If the vector is not a 2D or 3D vector, <returns>return -1 </returns>
        /// </sumary>
        /// <returns>
        /// The return value should be rounded to the nearest hundredth
        /// </returns>
        double temp = 0;

        if (vector.Length < 2 || vector.Length > 3)
        {
            return -1;
        }

        foreach (double side in vector)
        {
            temp += (Math.Pow(side, 2));
        }
        temp = Math.Round(Math.Sqrt(temp), 2);
        return temp;
    }
}
