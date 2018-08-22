using System;

namespace Calculator
{
    public class Calc
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }

        public double Div(int a, int b)
        {
            if (b == 0) throw new DivideByZeroException(nameof(b));
            return a / b;
        }
    }
}
