using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
        }
        else
        {
            int[] array = new int[size];
            for (int x = 0; x < size; x++)
            {
                array[x] = x;
                Console.Write(array[x]);
            }
        }
        Console.WriteLine();
        return array;
    }
}