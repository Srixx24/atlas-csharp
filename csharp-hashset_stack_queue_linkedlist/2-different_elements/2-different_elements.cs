using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> singleDidget = new List<int>();

        foreach (int numb in list1)
        {
            if (!list2.Contains(numb))
            {
                singleDidget.Add(numb);
            }
        }

        foreach (int numb in list2)
        {
            if (!list1.Contains(numb))
            {
                singleDidget.Add(numb);
            }
        }

        return singleDidget;
    }
}