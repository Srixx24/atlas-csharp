using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the dot product of two vectors.
    /// </summary>
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
        {
            return -1;
        }

        double dot = 0;
        for (int x = 0; x < vector1.Length; x++)
        {
            dot += vector1[x] * vector2[x];
        }

        return dot;
    }
}