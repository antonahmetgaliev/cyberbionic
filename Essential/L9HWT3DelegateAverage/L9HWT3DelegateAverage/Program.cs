using Common;
using System;

namespace L9HWT3DelegateAverage
{
    internal class Program
    {
        private static void Main()
        {
            Console.Write("Enter count of number - ");
            var count = ConsoleExtension.CheckInt();
            Console.WriteLine($"Average of {count} random numbers = {DelegateAverage.GetAverage(count)}");
            Console.ReadKey();
        }
    }
}
