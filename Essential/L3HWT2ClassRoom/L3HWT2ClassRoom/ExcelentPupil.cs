using System;

namespace L3HWT2ClassRoom
{
    internal partial class Program
    {
        private class ExcelentPupil:Pupil
        {
            public override void Study()
            {
                Console.WriteLine("Excelent study!");
            }

            public override void Read()
            {
                Console.WriteLine("Excelent read!");
            }

            public override void Write()
            {
                Console.WriteLine("Excelent write!");
            }

            public override void Relax()
            {
                Console.WriteLine("Excelent relax!");
            }
        }
    }
}
