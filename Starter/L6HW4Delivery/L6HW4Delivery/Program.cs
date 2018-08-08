using System;

namespace L6HW4Delivery
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input the number of clients - ");
            string klstr = Console.ReadLine();
            int kl = Convert.ToInt32(klstr), del=1;
            do
            {
                del *= kl--;
            }
            while (kl >0);
            Console.WriteLine("Number of routes = {0}", del);
            Console.ReadKey();
        }
    }
}
