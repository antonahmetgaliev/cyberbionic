using System;
using System.Globalization;

namespace L9HWT3Arrays
{
    class Program
    {
        static int [] MyReverse(int[] array)
        {
            int [] reversArray = new int[10];
            int j = array.Length-1;
            for (int i = 0; i < array.Length; i++)
            {
                reversArray[i] = array[j];
                --j;
            }

            return reversArray;
        }

        static int[] SubArray(int[] array, int index, int count)
        {
            int [] subArray = new int[count];
            int j = 0;
            for (int i = index; i < count+index; i++)
            {
                if (i >= array.Length) subArray[j] = 1;
                else subArray[j] = array[i];
                ++j;
            }
            return subArray;
        }

        static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ", array[i]);
            }
        }
        static void Main()
        {
            int [] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int[] reversArray = new int[10];
            reversArray = MyReverse(array);
            Console.Write("Input index - ");
            int index;
            int.TryParse(Console.ReadLine(), out index);
            Console.Write("Input count - ");
            int count = 0;
            int.TryParse(Console.ReadLine(), out count);
            int[] subArray = new int[count];
            subArray = SubArray(array, index, count);
            Console.WriteLine("\nArray :");
            Show(array);
            Console.WriteLine("\nReverse array :");
            Show(reversArray);
            Console.WriteLine("\nSub array :");
            Show(subArray);
            Console.ReadKey();
        }
    }
}
 