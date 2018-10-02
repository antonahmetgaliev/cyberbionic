using System;

namespace L5HWT3MyMatrix
{
    internal class SubMatrix
    {
        private readonly int[,] _matrix;

        public SubMatrix(int column, int row)
        {
            var rand = new Random();
            _matrix = new int[column,row];
            for (var i = 0; i < column; i++)
            {
                for (var j = 0; j < row; j++)
                {
                    _matrix[i, j] = rand.Next(0, 100);
                }
            }
        }

        public void Show(int xPos, int yPos)
        {
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(1); j++)
                {
                    var y = Console.CursorLeft;
                    Console.SetCursorPosition(j*3+xPos*7, 5+i+yPos*3);
                    Console.Write($"{_matrix[i,j]} ");
                }
                //Console.WriteLine();
            }
        }
    }
}