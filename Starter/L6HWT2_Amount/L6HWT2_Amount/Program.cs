using System;

namespace L6HWT2_Amount
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input interval A - ");
            string Astr = Console.ReadLine();
            Console.Write("Input interval B - ");
            string Bstr = Console.ReadLine();
            int A = Convert.ToInt32(Astr), B = Convert.ToInt32(Bstr);
            int sum = A, i = A;            
            while (i<B)
            {
                if (i < 0) Console.WriteLine(i);
                ++i;
                if (i < 0)
                    sum -= i;
                else
                    sum += i;                
            }            
            Console.WriteLine(sum);
            Console.ReadKey();
        }
    }
}
