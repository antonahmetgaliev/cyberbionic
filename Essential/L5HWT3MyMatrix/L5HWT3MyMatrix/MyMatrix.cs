
namespace L5HWT3MyMatrix
{
    internal class MyMatrix
    {
        private readonly SubMatrix[,] _matrix;

        public MyMatrix(int column, int row, int subColumn, int subRow)
        {
            _matrix = new SubMatrix[column,row];
            for (var i = 0; i < column; i++)
            {
                for (var j = 0; j < row; j++)
                {
                    _matrix[i, j] = new SubMatrix(subColumn,subRow);
                }
            }
        }

        public void Show()
        {            
            for (var i = 0; i < _matrix.GetLength(0); i++)
            {
                for (var j = 0; j < _matrix.GetLength(1); j++)
                {
                    _matrix[i, j].Show(i,j);
                }
            }
        }
    }
}