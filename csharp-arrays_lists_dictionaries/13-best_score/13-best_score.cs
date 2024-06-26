using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        int max = int.MinValue;
        string highValue = "None";

        foreach (KeyValuePair<string, int> item in myList)
        {
            if (item.Value >= max)
            {
                max = item.Value;
                highValue = item.Key;
            }
        }

        return highValue;
    }
}