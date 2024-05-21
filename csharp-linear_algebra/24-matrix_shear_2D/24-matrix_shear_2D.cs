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
        if (matrix.GetLength(0) != 2 || matrix.GetLength(1) != 2)
        {
            return new double[,] { { -1 } };
        }

        if (direction != 'x' && direction != 'y')
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[2, 2];

        for (int x = 0; x < 2; x++)
        {
            for (int y = 0; y < 2; y++)
            {
                if (direction == 'x')
                {
                    result[x, y] = matrix[x, y] + matrix[x, 1 - y] * factor;
                }
                else
                {
                    result[x, y] = matrix[x, y] + matrix[1 - x, y] * factor;
                }
            }
        }

        return result;
    }
}