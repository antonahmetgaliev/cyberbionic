using System;

namespace L6HWE1StaticCalculator
{
    internal class Program
    {
        private static int CheckInt()
        {
            int value;
            var text = Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }

        private static void Main()
        {
            Console.Write("Enter a - ");
            var a = CheckInt();
            Console.Write("Enter b - ");
            var b = CheckInt();
            Console.WriteLine($"a + b = {Calculator.Sum(a, b)}");
            Console.WriteLine($"a - b = {Calculator.Sub(a, b)}");
            Console.WriteLine($"a * b = {Calculator.Mul(a, b)}");
            try
            {
                Console.WriteLine($"a / b = {Calculator.Div(a, b)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Division by zero is prohibited");
            }
            Console.ReadKey();
        }
    }
}
