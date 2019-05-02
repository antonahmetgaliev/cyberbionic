
using Common;
using System;
using System.Collections.Generic;

namespace L6HWT4SortList
{
    static class Program
    {
        static void Main()
        {
            var list = new List<int>();
            Console.Write("How many numbers u want to add? - ");
            var numbers = ConsoleExtension.CheckInt();
            for (var i = 0; i < numbers; i++)
            {
                Console.Write($"\nEnter number №{i+1} - ");
                list.Add(ConsoleExtension.CheckInt());
            }
            Console.WriteLine("List before sort:");
            list.ShowList();
            list.SortUpList();
            Console.WriteLine("\nList after sort:");
            list.ShowList();
            Console.ReadKey();
        }

        public static void ShowList(this List <int> list)
        {
            foreach (var t in list)
            {
                Console.Write($"{t} ");
            }
        }
    }
}
