using System;

namespace L4HWT3_interval
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cycle = true;
            do
            {                
                Console.Write("Input number - ");
                string numberInStrnig = Console.ReadLine();
                int number = Convert.ToInt32(numberInStrnig);
                string interval = number >= 0 ? number >= 15 ? number >= 36 ? number >= 50 ? number >= 101 ? "Error! Input Other value." : "[50-100]" : "[36-50]" : "[15-35]" : "[0-14]" : "Error! Input other value.";
                if (interval!= "Error! Input Other value.")
                    Console.WriteLine("Number {0} is in the interval {1}\n", number, interval);
                else Console.WriteLine(interval);
                Console.Write("Would you like to continue?(y/n)");
                string choise = Console.ReadLine();
                if (choise == "y") cycle = true; else cycle = false;
            }
            while (cycle == true);
        }
    }
}
