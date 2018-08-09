using System;

namespace L7HWT3Currency
{
    class Program
    {
        static double Currency(double money, double curce)
        {
            return money * curce;
        }
        static double Cv()
        {
            string inp = Console.ReadLine();
            return Convert.ToDouble(inp);
        }
        static void Main()
        {
            Console.Write("Input  amount of money - ");
            double money = Cv();
            Console.Write("Input Currency - ");
            string curr = Console.ReadLine();
            Console.Write("Input  a course - ");
            double curse = Cv();
            Console.Write("Input Currency - ");
            string currCours = Console.ReadLine();
            double rez = Currency(money, curse);
            Console.WriteLine("{0} {1} for this course {2} = {3} {4}", money, curr, curse, rez, currCours);
            Console.ReadKey();
        }
    }
}
