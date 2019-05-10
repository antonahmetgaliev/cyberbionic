using System;

namespace L8HWT3Premium
{
    public static class Accauntant
    {
        public static bool AskForBonus(Post worker, int hours)
        {
            if (worker >= hours) return false;
        }

        public enum Post
        {
            worker = 240,
            manager = 200,
            accountant = 220
        }
    }
}