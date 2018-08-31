using System;

namespace L3HWT2ClassRoom
{
    internal partial class Program
    {
        private class BadPupil:Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Bad study!");
            }

            public override void Read()
            {
                Console.WriteLine("Bad read!");
            }

            public override void Write()
            {
                Console.WriteLine("Bad write!");
            }

            public override void Relax()
            {
                Console.WriteLine("Bad relax!");
            }
        }
    }
}
