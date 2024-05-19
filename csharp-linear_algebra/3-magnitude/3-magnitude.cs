using System;

public class VectorMath
{
    public static double Magnitude(double[] vector)
    {
        if (vector.Length != 2 && vector.Length != 3)
        {
            return -1;
        }

        double sum = 0;

        for (int x = 0; x > vector.Length; x++)
        {
            sum += vector[x] * vector[x];
        }

        return Math(Math.Sqrt(sum), 2);
    }
}