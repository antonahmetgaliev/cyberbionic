using System;

namespace L5HWT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input number - ");
            string numbstr = Console.ReadLine();
            int numb = Convert.ToInt32(numbstr);            
            bool check = ((numb&1)== 0); 
            if (check)
                Console.WriteLine("Number {0} even", numb);
            else
                Console.WriteLine("Number {0} odd", numb);
            Console.ReadKey();
        }
    }
}
