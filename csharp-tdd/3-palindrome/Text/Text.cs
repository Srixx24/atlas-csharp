using System;

namespace MyMath
{
    public class Str
    {
        public static bool IsPalindrome(string s)
        {
            string str2 = s.ToLower();
            str2 = Regex.Replace(str2, "[:;,. \t\n]", "");

            string reverse = new string(str2.Reverse().ToArray())

            return str2 == reverse;
        }
    }
}
