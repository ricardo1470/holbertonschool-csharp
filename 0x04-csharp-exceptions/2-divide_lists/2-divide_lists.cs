using System;
using System.Collections.Generic;


class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> div_list = new List<int>();
        int i;

        for (i = 0; i < listLength; i++)
        {
            try
            {
                div_list.Add(list1[i] / list2[i]);
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                div_list.Add(0);
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
            }
        }
        return (div_list);
    }
}
