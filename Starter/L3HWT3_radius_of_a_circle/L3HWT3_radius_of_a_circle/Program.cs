using System;

namespace L3HWT3_radius_of_a_circle
{
    class Program
    {
        static void Main(string[] args)
        {               
            byte r = 4;
            var rez = Math.PI * Math.Pow(r, 2);
            Console.WriteLine("Area of a circle with radius {1} = {0} square meters", rez, r);
            Console.ReadKey();
        }
    }
}
