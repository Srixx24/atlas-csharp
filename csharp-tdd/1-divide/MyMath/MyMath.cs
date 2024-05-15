using System;

namespace MyMath
{
    public static class Matrix
    {
        public static int[,] Divide(int[,] matrix, int num)
        {
            if (matrix == null)
            {
                return null;
            }
            else (num == 0)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }
            
        }
    }
}