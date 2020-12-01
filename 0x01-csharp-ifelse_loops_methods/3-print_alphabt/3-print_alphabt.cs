using System;

namespace _2_print_alphabet
{
    class Program
    {
        static void Main(string[] args)
        {
            char alphabet;

            for (alphabet = 'a'; alphabet <= 'z'; alphabet++)
            {
                if (alphabet != 'q' && alphabet != 'e')
                {
                    Console.Write(alphabet);
                }
            }
        }
    }
}
