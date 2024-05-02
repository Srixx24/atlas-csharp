using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        if (size < 0 )
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> list = new List<int>();

        for (int x = 0; x < size; x++)
        {
            list.Add(x);
            Console.Write(x);
            if (x < size - 1)
            {
                Console.Write(" ");
            }
        }
        if (size > 0)
        {
            Console.Write(" " + (size - 1));
        }
        else if (size == 1)
        {
            Console.Write("0");
        }

        Console.WriteLine("");

        return list;
    }
}