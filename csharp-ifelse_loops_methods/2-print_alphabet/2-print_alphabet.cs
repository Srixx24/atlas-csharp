using System;

class Program
{
    static void Main(string[] args)
    {
        string alph = "abcdefghijklmnopqrstuvwxyz";
        string result = "";

        for (int x = 0; x < alph.Length; x++)
        {
            result += alph[x];
        }
        Console.WriteLine(result);
    }
}