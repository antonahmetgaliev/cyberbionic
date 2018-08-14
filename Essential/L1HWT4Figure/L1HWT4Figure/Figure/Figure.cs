using System;
using System.Globalization;

namespace L1HWT4Figure
{
    class Figure
    {
        private Point[] points;
        public string Name { get ;set; }
        private int _number;
        private double Perimetr;

        public void InitFigure(string name)
        {
            Name = name;
            Console.Write("Input the number of points - ");
            _number = int.Parse(Console.ReadLine());
            points = new Point[_number];
            for (int i = 0; i < _number; i++)
            {
                Console.Write("Input letter of point - ");
                var letter = Console.ReadLine();
                Console.Write("Input X - ");
                var x = int.Parse(Console.ReadLine());
                Console.Write("Input Y - ");
                var y = int.Parse(Console.ReadLine());
                points[i]=new Point(letter,x,y);
            }
        }

        public double LengthSide(int A1, int B1, int A2, int B2)
        {
            return Math.Sqrt(Math.Pow(A2 - A1, 2) + Math.Pow(B2 - B1, 2));
        }

        public double PerimeterCalculator()
        {
            for (int i = 0, j = 1; i < _number; i++ , j++)
            {
                if (j == 4) j = 0;
                Perimetr += LengthSide(points[j].X, points[i].X, points[j].Y,points[i].Y);
            }

            return Perimetr;
        }
    }
}
