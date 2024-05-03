using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> newList = new HashSet<int>();
        int sum = 0;

        foreach (int numb in myList)
        {
            newList.Add(numb);
            sum += numb;
        }

        return sum;
    }
}