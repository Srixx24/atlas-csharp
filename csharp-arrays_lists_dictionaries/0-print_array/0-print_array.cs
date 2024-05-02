using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        int[] array = null;

        if (size < 0)
        {
            Console.Write("Size cannot be negative");
            Console.WriteLine();
            return null;
        }
        else if (size == 0)
        {
            Console.WriteLine();
            return new int[0];
        }
        else
        {
            array = new int[size];
            for (int x = 0; x < size; x++)
            {
                array[x] = x;
                Console.Write(array[x]);
                if (x < size - 1)
                {
                    Console.Write(" ");
                }
            }
        }
        Console.WriteLine();
        return array;
    }
}