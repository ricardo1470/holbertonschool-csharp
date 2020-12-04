using System;
using System.Collections.Generic;

class LList
{
	public static LinkedList<int> CreatePrint(int size)
	{
        int i;
        
		LinkedList<int> my_LList = new LinkedList<int>();
		if (size <= 0)
		{
			return my_LList;
		}
		for (i = 0; i < size; i++)
		{
			Console.WriteLine(i);
			my_LList.AddLast(i);
		}
		return my_LList;
	}
}