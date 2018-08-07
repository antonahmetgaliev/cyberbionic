using System;

namespace L5HWTExtra2_DeMorgan
{
    class Program
    {
        static void Main(string[] args)
        {            
            Console.Write("Input A - ");
            string A_string = Console.ReadLine();
            Console.Write("Input B - ");
            string B_string = Console.ReadLine();
            int A = Convert.ToInt32(A_string), B = Convert.ToInt32(B_string);
            int rez = A | B, rez_Morgan= ~(~A & ~B);           
            Console.WriteLine("A | B = {0}", rez);
            Console.WriteLine("!(!A&!B) = {0}", rez_Morgan);
            Console.ReadKey();
        }
    }
}
