using System;

namespace L3HWT0_arithmetic
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5, b = 2, rez = 0;
            rez = a++;
            Console.WriteLine(rez);
            rez = b++;
            Console.WriteLine(rez);
            rez = a--;
            Console.WriteLine(rez);
            rez = b--;
            Console.WriteLine(rez);
            rez = a + b;
            Console.WriteLine(rez);
            rez = a - b;
            Console.WriteLine(rez);
            rez = a * b;
            Console.WriteLine(rez);
            rez = a / b;
            Console.WriteLine(rez);
            rez = a % b;
            Console.WriteLine(rez);
            Console.ReadKey();
        }
    }
}
