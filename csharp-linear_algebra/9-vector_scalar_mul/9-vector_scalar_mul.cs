using System;

/// <summary>
/// Provides methods for vector mathematics.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Multiplies a vector and a scalar and returns the resulting vector.
    /// </summary>
    public static double[] Multiply(double[] vector, double scalar)
    {
        if (vector.Length == 2)
        {
            return new double[]
            {
                vector[0] * scalar,
                vector[1] * scalar
            };
        }
        else if (vector.Length == 3)
        {
            return new double[]
            {
                vector[0] * scalar,
                vector[1] * scalar,
                vector[2] * scalar
            };
        }
        else
        {
            return new double[] {-1}
        }
    }
}