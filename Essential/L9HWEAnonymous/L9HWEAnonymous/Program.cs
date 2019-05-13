namespace L9HWEAnonymous
{
    internal class Program
    {
        public delegate double AverageDelegate(int a, int b, int c);

        private static void Main()
        {
            AverageDelegate averageDelegate = (a, b, c) => (a + b + c) / 3;
            //var average = averageDelegate(2, 2, 2);
        }
    }
}
