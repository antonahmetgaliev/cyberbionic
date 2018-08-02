using System;

namespace L3HWT2_average
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1, b = 5, c = 7;
            float av;
            av = (a + b + c) / 3;            
            Console.WriteLine("Среднее арифметическое чисел {0}, {1}, {2} = {3}", a, b, c, av);
            Console.ReadKey();
        }
    }
}
