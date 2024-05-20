using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Multiplies two matrices and returns the resulting matrix.
    /// </summary>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        int row = matrix1.GetLength(0);
        int col1 = matrix1.GetLength(1);
        int col2 = matrix2.GetLength(1);

        if (col1 != matrix2.GetLength(0))
        {
            return new double[,] { { -1 } };
        }

        double[,] result = new double[row, col2];

        for (int x = 0; x < row; x++)
        {
            for (int y = 0; y < col2; y++)
            {
                for (int z = 0; z < col1; z++)
                {
                    result[x, y] += matrix1[x, z] * matrix2[y, z];
                }
            }
        }

        return result;
    }
}