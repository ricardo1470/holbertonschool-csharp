using System;


class Line
{

    public static void PrintDiagonal(int length)
    {
        int diag1, diag2;

        if (length <= 0)
        {
            Console.WriteLine("\n");
        }
        for (diag1 = 0; diag1 < length; diag1++)
        {
            for (diag2 = 0; diag2 < diag1; diag2++)
            {
                Console.Write(" ");
            }
            Console.WriteLine("\\");
        }
        
    }
}
