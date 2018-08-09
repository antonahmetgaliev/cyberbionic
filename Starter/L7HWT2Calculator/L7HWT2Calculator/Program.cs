using System;

namespace L7HWT2Calculator
{
    class Program
    {
        static double Add(double a, double b)
        {
            return a + b;
        }
        static double Sub(double a, double b)
        {
            return a - b;
        }
        static double Mul(double a, double b)
        {
            return a * b;
        }
        static double Div(double a, double b)
        {
            return a / b;
        }
        static double Choice (string s, double a, double b)
        {
            switch (s)
            {
                case "+":
                    {
                        return Add(a, b);                        
                    }
                case "-":
                    {
                        return Sub(a, b);                        
                    }
                case "*":
                    {
                        return Mul(a, b);                        
                    }
                case "/":
                    {
                        return Div(a, b);
                    }
                default: throw new ArgumentException();
            }
        }
        static void Main()
        {            
            do
            {
                bool check = false;
                do
                {
                    Console.Write("Input A - ");
                    int a;
                    int.TryParse(Console.ReadLine(),out a);
                    Console.Write("Input B - ");
                    int b;
                    int.TryParse(Console.ReadLine(), out b);
                    Console.Write("Input the arithmetic sign - ");
                    string s = Console.ReadLine();
                    if (b != 0 && (s=="+" || s == "-" || s == "*" || s == "/"))
                    {
                        check = true;
                        double rez = Choice(s, a, b);
                        Console.WriteLine("{0} {1} {2} = {3}", a, s, b, rez);
                    }
                    else
                    Console.WriteLine("Error! Please take other value\n");
                }
                while (!check);
            }
            while (Ques());
        }
        static bool Ques()
        {
            Console.Write("Would you like to continue?(y/n) ");
            string choise = Console.ReadLine();
            if (choise == "n") return false;
            else
            {
                Console.WriteLine();
                return true;
            }
        }
    }
}
