using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_07
{
    internal class ArifmeticMax
    {

    // Метод для перевірки числа на парність
    public static bool IsEven(int number)
    {
        return number % 2 == 0;
    }

    // Метод для перевірки числа на непарність
    public static bool IsOdd(int number)
    {
        return number % 2 != 0;
    }

    // Метод для перевірки числа на просте
    public static bool IsPrime(int number)
    {
        if (number <= 1) return false;
        if (number == 2) return true;

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0) return false;
        }

        return true;
    }

    // Метод для перевірки числа на Фібоначчі
    public static bool IsFibonacci(int number)
    {
        if (number < 0) return false;

        int a = 0;
        int b = 1;

        while (a < number)
        {
            int temp = a;
            a = b;
            b = temp + b;
        }

        return a == number;
    }
}
}
