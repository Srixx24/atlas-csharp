using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        int sortedList = new List<int>();

        foreach (int x in list1)
        {
            foreach (int y in list2)
            {         
                if (x == y)
                {
                    sortedList.Add(x);
                }
            }
        }
        return(sortedList);
    }
}