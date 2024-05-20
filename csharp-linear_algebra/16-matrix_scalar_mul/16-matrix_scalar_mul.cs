using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies a matrix by a scalar and returns the resulting matrix.
    /// </summary>
    public static double[,] MultiplyScalar(double[,] matrix, double scalar)
    {
        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(1)];

        if (matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3 || matrix.GetLength(1) < 2 || matrix.GetLength(1) > 3)
        {
            return new double[,] { {-1} };
        }

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                result[x, y] = matrix[x, y] * scalar;
            }
        }

        return result;
    }
} 