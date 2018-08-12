using System;

namespace L9HWT4Arrays
{
    class Program
    {
        static int [] NewElement(int[] array, int dim, int index, int element)
        {
            int [] newArray = new int[dim+1];
            for (int i = 0; i < index; i++)
            {
                newArray[i] = array[i];
            }
            for (int i = index; i < newArray.Length; i++)
            {
                if (i == index) newArray[i] = element;
                else newArray[i] = array[i-1];
            }

            return newArray;
        }

        static void Show(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("{0} ",array[i]);
            }
        }
        static void Main()
        {
            Console.Write("Input array dimension - ");
            int dim;
            int.TryParse(Console.ReadLine(), out dim);
            Console.Write("Input the address where the new item will be placed - ");
            int index;
            int.TryParse(Console.ReadLine(), out index);
            Console.Write("Input new element - ");
            int element;
            int.TryParse(Console.ReadLine(), out element);
            int [] array = new int[dim];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            int[] newArray = NewElement(array, dim, index, element);
            Console.WriteLine("Old array : ");
            Show(array);
            Console.WriteLine("\nNew array : ");
            Show(newArray);
            Console.ReadKey();
        }
    }
}
