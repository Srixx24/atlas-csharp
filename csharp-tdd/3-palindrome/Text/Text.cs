using System;

namespace MyMath
{
    /// <summary> Provides utility methods for working with strings.</summary>
    public class Str
    {
        /// <summary>
        /// Determines whether the specified string is a palindrome.
        /// </summary>
        /// <param name="s">The input string to be checked.</param>
        /// <returns>
        /// <c>true</c> if the input string is a palindrome; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPalindrome(string s)
        {
            // Convert the input string to lowercase
            string str2 = s.ToLower();

            // Remove any punctuation, whitespace, and other non-alphanumeric characters from the string
            str2 = Regex.Replace(str2, "[:;,. \t\n]", "");

            // Reverse the cleaned string
            string reverse = new string(str2.Reverse().ToArray())

            // Compare the cleaned input string with the reversed string
            return str2 == reverse;
        }
    }
}
