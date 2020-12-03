using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;

        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        List<int> my_List = new List<int>();

        for (i = 0; i < size; i++)
        {
            my_List.Add(i);
            Console.Write(i);
            if (i < size - 1)
            {
                Console.Write(' ');
            }
        }
        Console.WriteLine();
        return my_List;
    }
}