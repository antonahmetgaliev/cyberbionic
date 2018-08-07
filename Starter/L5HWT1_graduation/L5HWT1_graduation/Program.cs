using System;

namespace L5HWT1_graduation
{
    class Program
    {
        static void Main(string[] args)
        {
            int grad;
            Console.Write("Input - ");
            string strtoint = Console.ReadLine();
            grad = Convert.ToInt32(strtoint);
            bool grduation_check = grad != 0 && (grad & (grad - 1)) == 0 ? true : false;
            Console.WriteLine(grduation_check);
            Console.ReadKey();
        }
    }
}
