using System;

namespace L3HWT2ClassRoom
{
    internal partial class Program
    {
        private class GoodPupil:Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Good study!");
            }

            public override void Read()
            {
                Console.WriteLine("Good read!");
            }

            public override void Write()
            {
                Console.WriteLine("Good write!");
            }

            public override void Relax()
            {
                Console.WriteLine("Good relax!");
            }
        }
    }
}
