using System;

namespace L3HWT2ClassRoom
{
    internal partial class Program
    {
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

        private static void Main()
        {
            Console.Write("How many pupils you want to input? - ");
            var number = CheckInt();
            var classRoom = new ClassRoom();
            for (var i = 0; i < number; i++)
            {
                Console.Write("What kind of student do you want to add?(excelent, good, bad) - ");
                var puppil = Console.ReadLine();
                switch (puppil)
                {
                    case "excelent":
                        Console.WriteLine("\nExcellent pupil are added");
                        classRoom.AddPupills(new ExcelentPupil());
                        break;
                    case "good":
                        Console.WriteLine("\nGood pupil are added");
                        classRoom.AddPupills(new GoodPupil());
                        break;
                    case "bad":
                        Console.WriteLine("\nBad pupil are added");
                        classRoom.AddPupills(new BadPupil());
                        break;
                    default:
                        Console.WriteLine("\nError empty! A pupil is added by default. ");
                        classRoom.AddPupills(new GoodPupil());
                        break;
                }
            }
            classRoom.HowStudy();
            classRoom.HowRead();
            Console.WriteLine("\nPress any key to continue!");
            Console.ReadKey();
            Console.Clear();
            classRoom.HowWrite();
            classRoom.HowRelax();
            Console.ReadKey();
        }
    }
}
