using System;

namespace L9HWT2OperationsOnArrays
{
    class Program
    {
        static void Main()
        {
            Console.Write("Input the dimension of the array - ");
            int N;
            int.TryParse(Console.ReadLine(),out N);
            int [] array = new int[N];
            Random rand = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i]= rand.Next(-100,100);
            }
            int maxArr = -100;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxArr) maxArr = array[i];
            }
            int minArr = 100;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < minArr) minArr = array[i];
            }
            int sumArr = 0;
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] > 0) sumArr += array[i];
                else sumArr -= array[i];
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
            Console.WriteLine("\nMax element - {0}",maxArr);
            Console.WriteLine("Min element - {0}", minArr);
            Console.WriteLine("Average - {0}", sumArr);
            Console.WriteLine("All negative elements :");
            for(int i = 0; i < array.Length; i++)
            {
                if (array[i] < 0) Console.Write("{0} ", array[i]);
            }

            Console.ReadKey();
        }
    }
}
