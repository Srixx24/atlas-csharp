using System;
using System.Collections.Generic;

class List
{
    public static int MaxInteger(List<int> myList)
    {
        if (myList.Count == 0)
        {
            Console.WriteLine("List is empty");
            return -1;
        }
        int max = myList[0];

        for (int x = 1; x < myList.Count; x++)
        {
            if (myList[x] > max)
            {
                max = myList[x];
            }
        }

        return max;
    }
}