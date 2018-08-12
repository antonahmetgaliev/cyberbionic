using System;

namespace L9HWE1Array
{
    class Program
    {
        static void Main()
        {
            int [] array = new int[10];
            for (int i = 0; i < array.Length; ++i)
            {
                array[i] = i;
            }
            for (int i = array.Length-1; i >= 0; --i)
            {
                Console.WriteLine(array[i]);
            }

            Console.ReadKey();
        }
    }
}
