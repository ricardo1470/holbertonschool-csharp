using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> resultList = new List<bool>();
        if (myList.Count == 0)
        {
            return resultList;
        }
        foreach (int element in myList)
        {
            if (element % 2 == 0)
            {
                resultList.Add(true);
            }
            else
            {
                resultList.Add(false);
            }
        }
        return resultList;
    }
}
