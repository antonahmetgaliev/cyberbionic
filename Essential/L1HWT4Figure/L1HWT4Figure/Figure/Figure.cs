using System;

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

        public double LengthSide(int A, int B)
        {
            return Math.Sqrt(Math.Pow(A - B, 2) + Math.Pow(A - B, 2));
        }

        public double PerimeterCalculator()
        {
            for (int i = 0; i < _number; i++)
            {
                Perimetr += LengthSide(points[i].X, points[i].Y);
            }

            return Perimetr;
        }
    }
}
