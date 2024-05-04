using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int elements = 0;

        foreach (int val in myLList)
        {
            elements++;
            Console.WriteLine();
        }
        return elements;
    }
}