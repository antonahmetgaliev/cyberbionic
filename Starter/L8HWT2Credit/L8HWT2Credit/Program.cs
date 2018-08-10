using System;

namespace L8HWT2Credit
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input amount of payment - ");
            int payment;
            int.TryParse(Console.ReadLine(),out payment);
        }
    }
}
