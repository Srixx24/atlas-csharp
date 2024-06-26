using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the inverse of a 2D matrix
    /// </summary>
    public static double[,] Inverse2D(double[,] matrix)
    {
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        double deter = matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];

        double[,] swapin = new double[2,2];
        swapin[0, 0] = Math.Round(matrix[1, 1] / deter, 2);
        swapin[0, 1] = Math.Round(-matrix[0, 1] / deter, 2);
        swapin[1, 0] = Math.Round(-matrix[1, 0] / deter, 2);
        swapin[1, 1] = Math.Round(matrix[0, 0] / deter, 2);

        return swapin;
    }
}