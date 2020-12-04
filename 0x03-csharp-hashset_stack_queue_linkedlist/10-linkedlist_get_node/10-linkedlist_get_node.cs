using System;
using System.Collections.Generic;

class LList
{
	public static int GetNode(LinkedList<int> myLList, int n)
	{
		int idx = 0;
		foreach (int element in myLList)
		{
			if (idx == n)
			{
				return (element);
			}
			idx++;
		}
		return (0);
	}
}