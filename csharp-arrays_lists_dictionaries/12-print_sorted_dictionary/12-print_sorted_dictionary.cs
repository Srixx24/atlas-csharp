using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> keyList = new List<string>(myDict.Keys);
        keyList.Sort();

        foreach (string key in keyList)
        {
            Console.WriteLine($"{key}: {myDict[key]}");
        }
    }
}