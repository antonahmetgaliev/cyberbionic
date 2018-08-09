using System;

namespace L7HWExtra1Average
{
    class Program
    {
        static int Cv()
        {
            string inp = Console.ReadLine();
            return Convert.ToInt32(inp);            
        }
        static double Calculate(double a, double b, double c)
        {
            return (a + b + c) / 3;
        }

        static void Main()
        {
            Console.Write("Input a - ");            
            int a = Cv();
            Console.Write("Input b - ");
            int b = Cv();
            Console.Write("Input c - ");
            int c = Cv();
            double rez = Calculate(a, b, c);
            Console.WriteLine("Avarage of {1}, {2}, {3} = {0}",rez,a,b,c);
            Console.ReadKey();
        }
    }
}
