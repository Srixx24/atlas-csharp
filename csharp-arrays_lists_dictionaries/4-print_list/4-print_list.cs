using System;

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
        }
        Console.WriteLine("");

        return list;
    }
}