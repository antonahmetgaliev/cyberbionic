using System;
using System.Collections.Generic;

namespace L3HWT2ClassRoom
{
    class Program
    {
        class ClassRoom
        {
            private List<Pupil> _pupils;

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
                Console.WriteLine("\nin this class to study:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Study();
                }
            }

            public void HowRead()
            {
                Console.WriteLine("\nin this class to read:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Read();
                }
            }

            public void HowWrite()
            {
                Console.WriteLine("\nin this class to write:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Write();
                }
            }

            public void HowRelax()
            {
                Console.WriteLine("\nin this class to relax:");
                for (int i = 0; i < _pupils.Count; i++)
                {
                    Console.WriteLine($"Pupil №{i}");
                    _pupils[i].Relax();
                }
            }
        }

        class Pupil
        {
            public virtual void Study()
            {

            }

            public virtual void Read()
            {

            }

            public virtual void Write()
            {

            }

            public virtual void Relax()
            {

            }
        }

        class ExcelentPupil:Pupil
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

        class GoodPupil:Pupil
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

        class BadPupil:Pupil
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
        private static int CheckInt()
        {
            int value;
            var text = Console.ReadLine();
            while (!int.TryParse(text, out value))
            {
                Console.Write("\nError Input! Please, enter other value - ");
                text = Console.ReadLine();
            }

            return value;
        }

        static void Main()
        {
            Console.Write("How many pupils you want to input?");
            var number = CheckInt();
            var classRoom = new ClassRoom();
            for (var i = 0; i < number; i++)
            {
                Console.Write("What kind of student do you want to add?(excelent, good, bad)");
                var puppil = Console.ReadLine();
                switch (puppil)
                {
                    case "excelent":
                        Console.WriteLine("Excellent pupil are added");
                        classRoom.AddPupills(new ExcelentPupil());
                        break;
                    case "good":
                        Console.WriteLine("Good pupil are added");
                        classRoom.AddPupills(new GoodPupil());
                        break;
                    case "bad":
                        Console.WriteLine("Bad pupil are added");
                        classRoom.AddPupills(new BadPupil());
                        break;
                    default:
                        Console.WriteLine("Error empty! A pupil is added by default. ");
                        classRoom.AddPupills(new GoodPupil());
                        break;
                }
            }
            classRoom.HowStudy();
            classRoom.HowRead();
            classRoom.HowWrite();
            classRoom.HowRelax();
            Console.ReadKey();
        }
    }
}
