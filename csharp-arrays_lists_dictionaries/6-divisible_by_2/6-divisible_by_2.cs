using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> newList = new List<bool>();

        for (int x = 0; x < myList.Count; x++)
        {
            bool isDivisibleBy2 = myList[2] % 2 == 0;
            newList.Add(isDivisibleBy2);
        }

        return newList;
    }
}