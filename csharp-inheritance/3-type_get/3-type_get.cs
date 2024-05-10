using System;
using System.Reflection;

class Obj
{
    public static void Print(object myObj)
    {
        Type info = myObj.GetType()

        Console.WriteLine($"{info.Name} Properties");

        foreach (PropertyInfo objProp in info.GetProperties())
        {
            Console.WriteLine(objProp.Name);
        }

        Console.WriteLine ($"{info.Name} Methods");

        foreach (MethodInfo objmeth in info.GetMethods())
        {
            Console.WriteLine(objmeth.Name);
        }
    }
}