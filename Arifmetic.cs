using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_07
{
    public delegate int MyArifmetic(int value1, int value2);
    internal class Arifmetic
    {
        public static int adding(int value1, int value2)
        {
            return value1 + value2;
        }
        public static int Minus(int value1, int value2)
        {
            return value1 - value2;
        }

        public static int Multiply(int value1, int value2)
        {
            return value1 * value2;
        }
    }
}
