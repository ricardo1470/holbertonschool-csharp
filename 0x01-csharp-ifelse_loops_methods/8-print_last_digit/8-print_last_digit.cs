using System;


class Number
{
    public static int PrintLastDigit(int number)
    {
        int number2 = number % 10;
        if (number2 < 0)
        {
            number2 = number2 * -1;
        }
        Console.Write(number2);
        return (number2);
    }
}
