using System;

class Array
{
    public static void Reverse(int[] array)
    {
        if (array == null)
        {
            Console.WriteLine("");
            return;
        }

        for (int x = array.Length - 1; x >= 0; x--)
        {
            Console.WriteLine($"{array[x]} ");
        }
        Console.WriteLine("");
    }
}