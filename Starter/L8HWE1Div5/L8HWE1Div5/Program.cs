using System;

namespace L8HWE1Div5
{
    class Program
    {
        static void Calculate(ref int a, ref int b, ref int c)
        {
            a /= 5;
            b /= 5;
            c /= 5;
        }
        static void Main()
        {
            Console.Write("Input A - ");
            int operand1;
            int.TryParse(Console.ReadLine(),out operand1);
            Console.Write("Input B - ");
            int operand2;
            int.TryParse(Console.ReadLine(), out operand2);
            Console.Write("Input C - ");
            int operand3;
            int.TryParse(Console.ReadLine(), out operand3);
            Calculate(ref operand1, ref operand2, ref operand3);
            Console.WriteLine("{0}, {1}, {2}", operand1, operand2, operand3);
            Console.ReadKey();
        }
    }
}
