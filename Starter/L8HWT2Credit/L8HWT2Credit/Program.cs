using System;

namespace L8HWT2Credit
{
    class Program
    {
        static void Credit(int pay)
        {
            int debt = 700;
            Console.WriteLine("The client paid {0} $ of debt",pay);
            int debtCheck = debt - pay;
            if (debtCheck<0) Console.WriteLine("Prepayment is - {0} $",-debtCheck);
            else if  (debtCheck == 0) Console.WriteLine("All debt paid");
            else Console.WriteLine("Debt is - {0} $", debtCheck);
        }
        static void Main()
        {
            Console.Write("Input amount of payment - ");
            int payment;
            int.TryParse(Console.ReadLine(),out payment);
            Credit(payment);
            Console.ReadKey();
        }
    }
}
