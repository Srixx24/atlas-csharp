using System;

/// <summary>
/// Provides methods for matrix mathematics.
/// </summary>
public class MatrixMath
{
    /// <summary>
    /// Calculates the determinant of a matrix.
    /// </summary>
    public static double Determinant(double[,] matrix)
    {
        if (matrix.GetLength(0) != matrix.GetLength(1))
        {
            return -1;
        }
        else if (matrix.GetLength(0) != 2 && matrix.GetLength(0) != 3)
        {
            return -1;
        }

        if (matrix.GetLength(0) == 2 && matrix.GetLength(1) == 2)
        {
			return matrix[0, 0] * matrix[1, 1] - matrix[0, 1] * matrix[1, 0];
        }
		else if (matrix.GetLength(0) == 3 && matrix.GetLength(1) == 3)
		{
			double x = matrix[0, 0] * ((matrix[1, 1] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 1]));
			double y = matrix[0, 1] * ((matrix[1, 0] * matrix[2, 2]) - (matrix[1, 2] * matrix[2, 0]));
			double z = matrix[0, 2] * ((matrix[1, 0] * matrix[2, 1]) - (matrix[1, 1] * matrix[2, 0]));
			return Math.Round((x - y + z),2);
		}
    }
}