using System;

namespace L5HWT3MyMatrix
{
    internal class SubMatrix
    {
        private readonly int[,] _matrix;

        public SubMatrix(int column, int row)
        {
            var rand = new Random();
            _matrix = new int[row,column];
            for (var i = 0; i < row; i++)
            {
                for (var j = 0; j < column; j++)
                {
                    _matrix[i, j] = rand.Next(0, 100);
                }
            }
        }

        public void Show(int xPos, int yPos)
        {            
            Console.SetCursorPosition(xPos*_matrix.GetLength(1)*4, yPos * _matrix.GetLength(0)+5+yPos);
            var x = Console.CursorLeft;
            var y = Console.CursorTop;            
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {                
                for (var j = 0; j < _matrix.GetLength(1); j++)
                {                    
                    Console.SetCursorPosition(x+j*3, y + i);
                    Console.Write($"{_matrix[i,j]}");
                }
            }
        }
    }
}