using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Rotates a square 2D matrix
    /// </summary>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        if (matrix.GetLength(1) > 2)
        {
			return new double[,] { { -1 } };
        }

        double cos = Math.Cos(angle);
        double sin = Math.Sin(angle);

        double[,] result = new double[matrix.GetLength(0), 0];

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                result[x, y] = matrix[x, y] * cos - matrix[y, x] * sin;
            }
        }

        return result;
    }
}