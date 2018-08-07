using System;

namespace L6HWExtra1_square
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input width - ");
            string wtstr = Console.ReadLine();
            int wt = Convert.ToInt32(wtstr);
            Console.Write("Input height - ");
            string hgstr = Console.ReadLine();
            int hg = Convert.ToInt32(hgstr);
            for (int h = 0; h<hg; h++)
            {
                for (int w = 0; w<wt; w++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
