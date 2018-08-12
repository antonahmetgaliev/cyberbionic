using System;

namespace L8HWT3Delivery
{
    class Program
    {
        static int Delivery(int kl)
        {
            int res;
            if (kl == 1)
                return 1;
            res = Delivery(kl - 1) * kl;
            return res;
        }
        static void Main()
        {
            Console.Write("Input the number of clients - ");
            int kl;
            string klstr = Console.ReadLine();
            int.TryParse(klstr, out kl);
            int del = Delivery(kl);
            Console.WriteLine("Number of routes = {0}", del);
            Console.ReadKey();
        }
    }
}
