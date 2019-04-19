using System;

namespace L5HWT3MyMatrix
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
            Console.Write("Input number of column - ");
            var column = CheckInt();
            Console.Write("Input number of row - ");
            var row = CheckInt();
            Console.Write("Input number of subMatrix column - ");
            var subColumn = CheckInt();
            Console.Write("Input number of subMatrix row - ");
            var subRow = CheckInt();
            var matrix = new MyMatrix(column, row, subColumn, subRow);
            Console.WriteLine();
            matrix.Show();
            Console.ReadKey();
        }
    }
}
