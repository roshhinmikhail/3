using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            long a, b, c;
            Console.WriteLine("Введите число");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите степень");
            b = Convert.ToInt32(Console.ReadLine());
            c = a;
            while (b > 1) { a = a * c; b--; }
            Console.WriteLine(a);
            Console.ReadLine();
        }
    }
}
