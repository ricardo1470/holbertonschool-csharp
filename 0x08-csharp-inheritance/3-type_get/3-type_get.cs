using System.Security.Cryptography;
using System;
using System.Collections.Generic;
using System.Reflection;

/// <summary>
/// method that prints the names of the available properties and methods
/// of an object. See example for output format.
/// </summary>
class Obj
{
    /// <summary>
    ///  prints the names of the available properties and methods of an object.
    /// </summary>
    public static void Print(object myObj)
    {
        TypeInfo my_type = myObj.GetType().GetTypeInfo();
		Console.WriteLine("{0} Properties:", my_type.Name);
		foreach (PropertyInfo propInfo in my_type.GetProperties())
		{
			Console.WriteLine(propInfo.Name);
		}

		Console.WriteLine("{0} Methods:", my_type.Name);
		foreach (MethodInfo metInfo in my_type.GetMethods())
		{
			Console.WriteLine(metInfo.Name);
		}
    }
}
