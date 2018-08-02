using System;

namespace L3HWT4_calculation_of_volume
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415926535f;
            byte r = 4, h=3;
            double rez, v;
            v = 2 * pi * Math.Pow(r, 2)*h;
            rez = 2 * pi * r * (r+h);
            Console.WriteLine("Amount with radius {1} and height {2}= {0} cubic meters", v, r, h);
            Console.WriteLine("Areas with radius {1} and height {2}= {0} square meters", rez, r, h);
            Console.ReadKey();
        }
    }
}
