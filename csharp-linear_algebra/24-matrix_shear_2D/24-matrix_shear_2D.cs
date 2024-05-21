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

        double[,] result = new double[matrix.GetLength(0), 2];

        for (int x = 0; x < matrix.GetLength(0); x++)
        {
            double xFactor = 0, yFactor = 0;
            if (direction == 'x')
            {
                xFactor = factor;
            }
            else
            {
                yFactor = factor;
            }

            for (int y = 0; y < matrix.GetLength(1); y++)
            {
                result[x, y] = matrix[x, y] + xFactor * matrix[x, 1 - y] + yFactor * matrix[1 - x, y];
            }
        }

        return result;
    }
}