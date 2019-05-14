using System;
using Common;

namespace L9HWT2DelegateCalculator
{
    internal class Program
    {
        public static void DivByZeroException(int a, int b)
        {
            try
            {
                Console.WriteLine($"\nDiv {a} + {b} = {Calculator.Div(a,b)}");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("\nDivision by 0 is prohibited.");
            }
        }

        private static void Main()
        {
            Console.WriteLine("Enter a, b:");
            var a = ConsoleExtension.CheckInt();
            var b = ConsoleExtension.CheckInt();
            var body = new[]
            {
                "Select an action on the numbers:", "Sum", "Sub", "Mul", "Div"
            };
            switch (Menu.CreateMenuIntWithoutEsc(body))
            {
                case 0:
                    Console.WriteLine($"\nSum {a} + {b} = {Calculator.Sum(a, b)}");
                    break;
                case 1:
                    Console.WriteLine($"\nSub {a} + {b} = {Calculator.Sub(a, b)}");
                    break;
                case 2:
                    Console.WriteLine($"\nMul {a} + {b} = {Calculator.Mul(a, b)}");
                    break;
                case 3:
                    DivByZeroException(a, b);
                    break;
            }

            Console.ReadKey();
        }
    }
}
