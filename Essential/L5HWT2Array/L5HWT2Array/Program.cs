using System;

namespace L5HWT2Array
{
    internal class Program
    {
        private static int CheckInt()
        {
            int value;
            var text = Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }
        private static void Main()
        {
            Console.Write("Input array of dimension - ");
            var n = CheckInt();
            var array = new NumArray(n);
            array.EnterElements();
            for (var i = 0; i < n; i++)
            {
                Console.Write("{0} ", array[i]);
            }
            Console.WriteLine("\nMax element - {0}", array.MaxArr());
            Console.WriteLine("Min element - {0}", array.MinArr());
            Console.WriteLine("Summ - {0}", array.SummArr());
            Console.WriteLine("Average - {0}", array.SummArr()/n);
            Console.WriteLine("All negative elements :");
            for (var i = 0; i < n; i++)
            {
                if (array[i] < 0) Console.Write("{0} ", array[i]);
            }
            Console.ReadKey();
        }
    }
}
