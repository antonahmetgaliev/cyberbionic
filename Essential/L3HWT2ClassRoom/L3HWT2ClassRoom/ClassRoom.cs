using System;
using System.Collections.Generic;

namespace L3HWT2ClassRoom
{
    internal partial class Program
    {
        private class ClassRoom
        {
            private readonly List<Pupil> _pupils;

            public ClassRoom()
            {
                _pupils = new List<Pupil>();
            }

            public void AddPupills(Pupil pupils)
            {
                _pupils.Add(pupils);
            }

            public void HowStudy()
            {
                Console.WriteLine("\nIn this class study:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Study();
                }
            }

            public void HowRead()
            {
                Console.WriteLine("\nIn this class read:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Read();
                }
            }

            public void HowWrite()
            {
                Console.WriteLine("\nIn this class write:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Write();
                }
            }

            public void HowRelax()
            {
                Console.WriteLine("\nIn this class relax:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Relax();
                }
            }
        }
    }
}
