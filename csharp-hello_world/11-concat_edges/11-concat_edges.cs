using System;

class Program
{
	static void Main(string[] args)
	{
		string str = "C# (pronounced \"See Sharp\") is a simple, modern, object-oriented, and type-safe programming language. C# has its roots in the C family of languages and will be immediately familiar to C, C++, Java, and JavaScript programmers.";
		str = str.Substring(49, 16) + str.Substring(124, 12) + str.Substring(72, 3) +str.Substring(0, 2);
		Console.WriteLine(str);
        }
}