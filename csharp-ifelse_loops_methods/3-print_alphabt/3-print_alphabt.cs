using System;

class Program
{
    static void Main(string[] args)
    {
        string alph = "abcdefghijklmnopqrstuvwxyz";

        for (int x = 0; x < alph.Length; x++)
        {
            if (!(x == 'q' || x == 'e'))
            {
                Console.Write(alph[x]);
            }
        }
    }
}