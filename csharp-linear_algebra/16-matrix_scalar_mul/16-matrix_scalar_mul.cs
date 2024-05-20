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
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix.Rank != 2 || matrix.GetLength(0) != matrix.GetLength(1) ||
            matrix.GetLength(0) < 2 || matrix.GetLength(0) > 3)
        {
            return new double[1,1] { {-1} };
        }

        for (int x = 0; x < matrix.GetLength; x++)
        {
            for (int y = 0; y < matrix.GetLength; y++)
            {
                    result[x, y] = matrix1[x, y] + scalar;
            }
        }

        return result
    }
}