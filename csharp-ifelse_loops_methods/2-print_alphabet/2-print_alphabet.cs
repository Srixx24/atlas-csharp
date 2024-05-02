using System;

class Program
{
    static void Main(string[] args)
    {
        string alph = "abcdefghijklmnopqrstuvwxyz";

        if (!string.IsNullOrEmpty(alph))
        {
            alph += "\n";
            Console.WriteLine(alph);
        }
    }
}