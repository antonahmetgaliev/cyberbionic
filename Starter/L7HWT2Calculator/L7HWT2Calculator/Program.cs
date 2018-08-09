using System;

namespace L7HWT2Calculator
{
    class Program
    {
        static int Cv()
        {
            string inp = Console.ReadLine();
            return Convert.ToInt32(inp);
        }
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
        static double Choice (string s, double a, double b, ref bool check)
        {
            switch (s)
            {
                case "+":
                    {
                        check = true;
                        return Add(a, b);                        
                    }
                case "-":
                    {
                        check = true;
                        return Sub(a, b);                        
                    }
                case "*":
                    {
                        check = true;
                        return Mul(a, b);                        
                    }
                case "/":
                    {
                        if (b != 0)
                        {
                            check = true;
                            return Div(a, b);
                        }
                        else return 0;
                    }
                default: return 0;
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
                    int a = Cv();
                    Console.Write("Input B - ");
                    int b = Cv();
                    Console.Write("Input the arithmetic sign - ");
                    string s = Console.ReadLine();
                    double rez = Choice(s, a, b, ref check);
                    if (check)
                    {
                        Console.WriteLine("{0} {1} {2} = {3}", a, s, b, rez);                        
                    }
                    else Console.WriteLine("Error! Please take other value\n");
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
