using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> results = new List<int>();

        for (int x = 0; x < listLength; x++)
        {
            try
            {
                results.Add(list1[x]/list2[x]);
            }
            catch
            {
                Console.WriteLine("Cannot divide by zero");
                Console.WriteLine("Out of range");
            }
        }

        return results;
    }
}