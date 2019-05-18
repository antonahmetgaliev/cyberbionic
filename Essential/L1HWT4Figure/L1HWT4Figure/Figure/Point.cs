namespace L1HWT4Figure.Figure
{
    internal class Point
    {
        public string Letter { get; set; }
        public int X { get; set; }
        public int Y { get; set; }

        public Point(string letter, int x, int y)
        {
            Letter = letter;
            X = x;
            Y = y;
        }
    }
}
