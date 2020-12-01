using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            string comma = "";

            for (number = 0; number <= 99; number++)
            {
                Console.Write("{0}{1:d2}", comma, number);
                comma = ", ";
            }
        }
    }
}
