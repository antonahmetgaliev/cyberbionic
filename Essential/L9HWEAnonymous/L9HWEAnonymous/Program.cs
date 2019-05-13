using System;
using Common;

namespace L9HWEAnonymous
{
    internal class Program
    {
        public delegate double AverageDelegate(double a, double b, double c);

        private static void Main()
        {
            Console.WriteLine("Enter 3 numbers:");
            var num1 = ConsoleExtension.CheckInt();
            var num2 = ConsoleExtension.CheckInt();
            var num3 = ConsoleExtension.CheckInt();
            AverageDelegate averageDelegate = (a, b, c) => (a + b + c) / 3;
            var average = averageDelegate(num1, num2, num3);
            Console.WriteLine($"\nAverage of {num1}, {num2}, {num3} = {average}");
            Console.ReadKey();
        }
    }
}
