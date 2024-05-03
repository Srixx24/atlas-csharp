using System;

class Dictionary
{
    public static int NumberOfKeys(Dictionary<string, string> myDict)
    {
        int keys = 0;

        foreach (KeyValuePair<string, string> pair in myDict)
        {
            keys++;
        }

        return keys;
    }
}