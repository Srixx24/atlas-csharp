using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Shears a square 2D matrix
    /// </summary>
    public static double[,] Shear2D(double[,] matrix, char direction, double factor)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[matrix.GetLength(0), matrix.GetLength(0)];

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            for (int y = 0; y < matrix.GetLength(0); y++)
            {
                if (direction == 'x')
                {
                    result[i, j] = matrix[i, j] + factor * matrix[i, (j + 1) % size];
                }
                else
                {
                    result[i, j] = matrix[i, j] + factor * matrix[(i + 1) % size, j];
                }
            }
        }

        return result;
    }
}