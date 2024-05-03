using System;
using System.Collections.Generic;
using System.Linq;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        List<int> list = new List<int>();
        for (int x = 0; x < size; x++)
        {
            list.Add(x);
            Console.WriteLine(x);
        }

        LinkedList<int> newList = new LinkedList<int>(list);

        return newList;
    }
}