using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1, number2;

            for (number1 = 0; number1 <= 9; number1++)
            {
                for (number2 = number1 + 1; number2 <= 9; number2++)
                {
                    Console.Write("{0}{1}", number1, number2);
                    if (!(number1 == 8 && number2 == 9))
                    {
                        Console.Write(", ");
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
