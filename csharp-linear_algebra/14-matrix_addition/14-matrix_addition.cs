using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Adds two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Add(double[,] matrix1, double[,] matrix2)
    {
        double[,] result = new double[matrix1.GetLength(0), matrix1.GetLength(1)];

        if (matrix1.GetLength(0) != matrix2.GetLength(0) || matrix1.GetLength(1) != matrix2.GetLength(1))
        {
            return new double[,] { { -1 } };
        }

        if (matrix1.GetLength(0) == 3 && matrix1.GetLength(1) == 3 &&
		matrix2.GetLength(0) == 3 && matrix2.GetLength(1) == 3)
        {
            for (int x = 0; x < 2; x++)
            {
                for (int y = 0; y < 2; y++)
                {
                    result[x, y] = matrix1[x, y] + matrix2[x, y];
                }
            }
        }
        else
        {
            return new double[,] { { -1 } };
        }

        return result;
    }
}