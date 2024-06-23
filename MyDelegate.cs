using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_01_07
{
    
    internal class MyDelegate
    {
        public delegate void MyDeleg(string value);
        public static void Message(string message)
        {
            Console.WriteLine($"message: {message}");
        }

        public static void Message2(string message)
        {
            Console.WriteLine($"message2: {message}");
        }

        
    }
}
