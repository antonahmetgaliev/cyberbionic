using System;

namespace L1HWT4Figure
{
    class Figure
    {
        private Point[] _points;
        public string Name { get ;set; }
        private int _number;
        private double Perimetr;

        public void InitFigure(string name, int number)
        {
            Name = name;
            _number = number;
            _points = new Point[_number];
        }

        public void InputPoint(string letter, int x, int y, int i)
        {
            _points[i] = new Point(letter, x, y);
        }

        public double LengthSide(int A1, int B1, int A2, int B2)
        {
            return Math.Sqrt(Math.Pow(A2 - A1, 2) + Math.Pow(B2 - B1, 2));
        }

        public double PerimeterCalculator()
        {
            for (int i = 0, j = 1; i < _number; i++ , j++)
            {
                if (j == _number) j = 0;
                Perimetr += LengthSide(_points[j].X, _points[i].X, _points[j].Y,_points[i].Y);
            }
            return Perimetr;
        }
    }
}
