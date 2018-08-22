using System;

namespace Calculator
{
    public class Calc
    {
        public double Sum(double a, double b)
        {
            return a + b;
        }

        public double Div(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException(nameof(b));
            return a / b;
        }

        public double Mul(double a, double b)
        {
            return a * b;
        }

        public double Sub(double a, double b)
        {
            return a - b;
        }
    }
}
