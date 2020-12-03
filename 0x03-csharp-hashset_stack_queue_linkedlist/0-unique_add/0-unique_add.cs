using System;
using System.Collections.Generic;


class List
{
    public static int Sum(List<int> myList)
    {
        HashSet<int> set = new HashSet<int>(myList);
        int num = 0;
        foreach (int i in set)
        {
            num = num + i;
        }
        return (num);
    }
}
