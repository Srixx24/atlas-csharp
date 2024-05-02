using System;

class Number
{
    public static int PrintLastDigit(int number)
    {
        int x = Math.Abs(number % 10)
        Console.Write(x);
        return x;
    }
}