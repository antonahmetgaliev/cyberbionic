using System;

namespace L6HWT3Figures
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Rectangle:");
            for (int i=0;i<5;++i)
            {
                for (int ii=0;ii<5;++ii)
                    Console.Write("*");
                Console.Write("\n");
            }
            Console.WriteLine("Right triangle:");
            int iii = 1;
            for (int i = 0; i < 5; ++i)
            {
                for (int ii = 0; ii < iii; ++ii)
                    Console.Write("*");
                Console.Write("\n");
                ++iii;
            }
            Console.WriteLine("Equilateral triangle:");
            int ir = 3, il = 3;
            for (int i = 0; i < 5; ++i)
            {
                for (int ii = 0; ii < il; ++ii)
                {
                    if (ii > ir && ii < il) Console.Write("*");
                    else Console.Write(" ");
                }
                Console.Write("\n");
                --ir;
                ++il;
            }
            Console.ReadKey();
        }
    }
}
