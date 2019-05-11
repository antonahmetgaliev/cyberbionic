using System;

namespace L8HWT3Premium
{
    public static class Accountant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            return (int) worker <= hours;
        }

        public enum Post
        {
            Worker = 240,
            Manager = 200,
            Accountant = 220
        }
    }
}