using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class VectorMath
{
    /// <summary>
    /// Calculates the cross product of two 3D vectors
    /// </summary>
    public static double[] CrossProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != 3 || vector2.Length != 3)
        {
            return new double[] { -1, -1, -1 };
        }
        
        double[] cross = new double[3];

        cross[0] = vector1[1] * vector2[2] - vector1[2] * vector2[1];
        cross[1] = vector1[2] * vector2[0] - vector1[0] * vector2[2];
        cross[2] = vector1[0] * vector2[1] - vector1[1] * vector2[0];

        return cross;
    }
}