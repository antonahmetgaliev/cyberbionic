using System;

namespace L7HWT4Number
{
    class Program
    {
        static void Pos(int numb, ref bool positive)
        {
            if (numb > 0)
            {
                Console.WriteLine("{0} is positive", numb);
                positive = true;
            }
            else Console.WriteLine("{0} is negative", numb);

        }

        static void Prime(int numb, bool positive)
        {
            bool pm = true;
            if (positive)
            {
                for (int i = 2; i < numb; ++i)
                    if (numb % i == 0)
                        pm = false;
            }
            else
                for (int i = -2; i > numb; --i)
                    if (numb % i == 0)
                        pm = false;
            if (pm) Console.WriteLine("{0} is Simple", numb);
            else Console.WriteLine("{0} is not Simple", numb);
        }

        static void Div(int numb)
        {
            Console.WriteLine("Is the '{0}' divided by 2, 5, 3, 6, 9 without a remainder", numb);
            for (int i = 2; i <= 9; ++i)
            {
                if (i == 2 || i == 3 || i == 5 || i == 6 || i == 9)
                {
                    if (numb % i == 0)
                        Console.WriteLine("{0} +", i);
                    else
                        Console.WriteLine("{0} -", i);
                }
            }
        }
        static void Main()
        {
            int numb;
            bool positive = false;
            do
            {
                Console.Write("Input number - ");
                int.TryParse(Console.ReadLine(),out numb);
                if (numb == 0) Console.WriteLine("This is a joke? Please enter a different number!");
            }
            while (numb == 0);
            Pos(numb,ref positive);
            Prime(numb, positive);
            Div(numb);
            Console.ReadKey();
        }
    }
}
