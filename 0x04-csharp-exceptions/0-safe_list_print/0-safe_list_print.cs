﻿using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int i;
        int j = 0;

        try
        {
            for (i = 0; i < n; i++)
            {
                Console.WriteLine(myList[i]);
                j = i + 1;
            }
        }
        catch
        {
        }
            return (j);
    }
}