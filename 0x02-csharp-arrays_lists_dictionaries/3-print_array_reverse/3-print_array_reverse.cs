﻿using System;

class Array
{
    public static void Reverse(int[] array)
    {
        int i;

        if (array == null || array.Length == 0)
        {
            Console.WriteLine();
            return;
        }
        for (i = array.Length - 1; i >= 0; i--)
        {
            Console.Write(array[i]);
            if (i != 0)
            {
                Console.Write(' ');
            }
            else
            {
                Console.WriteLine();
            }
        }
    }
}