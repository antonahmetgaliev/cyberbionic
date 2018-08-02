using System;

namespace L3HWT3_radius_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {
            const double pi = 3.1415926535f;
            byte r = 4;
            double rez;
            rez = pi * Math.Pow(r, 2);
            Console.WriteLine("Area of a circle with radius {1} = {0} square meters", rez, r);
            Console.ReadKey();
        }
    }
}
