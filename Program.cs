using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_07
{
    internal class Program
    {
        

        static void Main(string[] args)
        {
            MyDelegate.MyDeleg deleg = MyDelegate.Message;
            deleg += MyDelegate.Message2;
            deleg -= MyDelegate.Message;
            deleg("hello");

            Console.WriteLine("второе задание =========================");

            MyArifmetic add = new MyArifmetic(Arifmetic.adding);
            MyArifmetic minus = new MyArifmetic(Arifmetic.Minus);
            MyArifmetic multiply = new MyArifmetic(Arifmetic.Multiply);

            int value1 = 30;
            int value2 = 50;

            Console.WriteLine($"добавление {add(value1,value2)}");
            Console.WriteLine($"минусование {minus(value1,value2)}");
            Console.WriteLine($"умножение {multiply(value1,value2)}");

            Console.WriteLine("третье задание =========================");

            int number = 17;

            Predicate<int> isEven = ArifmeticMax.IsEven;
            Predicate<int> isOdd = ArifmeticMax.IsOdd;
            Predicate<int> isPrime = ArifmeticMax.IsPrime;
            Predicate<int> isFibonacci = ArifmeticMax.IsFibonacci;

            Console.WriteLine($"{number} is even: {isEven(number)}");
            Console.WriteLine($"{number} is odd: {isOdd(number)}");
            Console.WriteLine($"{number} is prime: {isPrime(number)}");
            Console.WriteLine($"{number} is Fibonacci: {isFibonacci(number)}");

            Console.WriteLine("четвертое задание=========================");

            int sum = add.Invoke(value1, value2);
            int minusss = minus.Invoke(value1, value2);
            int multiplyy = multiply.Invoke(value1, value2);

            Console.WriteLine($"Sum: {value1} + {value2} = {sum}");
            Console.WriteLine($"Difference: {value1} - {value2} = {minusss}");
            Console.WriteLine($"Product: {value1} * {value2} = {multiplyy}");

        }
    }
}
