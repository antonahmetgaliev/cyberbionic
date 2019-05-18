using System;
using System.Collections.Generic;

namespace L1HWT4Figure.Figure
{
    internal class Figure
    {
        private List<Point> _points;
        public string Name { get; set; }

        public void InitFigure(string name)
        {
            Name = name;
            _points = new List<Point>();
        }

        public void InputPoint(string letter, int x, int y)
        {
            _points.Add(new Point(letter, x, y));
        }

        public double LengthSide(int a1, int b1, int a2, int b2)
        {
            return Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b2 - b1, 2));
        }

        public double PerimeterCalculator()
        {
            double perimetr = 0;
            for (int i = 0, j = 1; i < _points.Count; i++, j++)
            {
                if (j == _points.Count) j = 0;
                perimetr += LengthSide(_points[j].X, _points[i].X, _points[j].Y, _points[i].Y);
            }
            return perimetr;
        }
    }
}