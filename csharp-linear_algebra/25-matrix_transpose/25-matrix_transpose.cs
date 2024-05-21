using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Transpose a matrix
    /// </summary>
    public static double[,] Transpose(double[,] matrix)
    {
        int row = matrix.GetLength(0);
        int col = matrix.GetLength(1);

        double[,] result = new double[col, row];

        for (int x = 0; x < row; x++)
        {
            for (int y = 0: y < col; y++)
            {
                result[y, x] = matrix[x, y]
            }
        }
        return result;
    }
}