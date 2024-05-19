using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Adds two vectors and returns the resulting vector.
    /// </summary>
    public static double[] Add(double[] vector1, double[] vector2)
    {
        if (vector1.Length == 2 && vector2.Length == 2)
        {
                vector1[0] + vector2[0],
                vector1[1] + vector2[1]
        }
        else if (vector1.Length == 3 && vector2.Length == 3)
        {
                vector1[0] + vector2[0],
                vector1[1] + vector2[1],
                vector1[2] + vector2[2]
        }
        else
        {
            return new double[] { -1 };
        }
    }
}