using System;

namespace L5HWT4Prize
{
    class Program
    {
        static void Main(string[] args)
        {
            do
                { 
                    Console.Write("Input the number of years - ");
                    string yearstr = Console.ReadLine();
                    int year = Convert.ToInt32(yearstr);
                    Console.Write("Input your salary - ");
                    string prizestr = Console.ReadLine();
                    int prize = Convert.ToInt32(prizestr);
                    double prized=prize;
                    string pr = "";
                    if (year < 5)
                    { prized *= prize * 0.1; pr = "10%"; }
                    else
                        if (year >= 5)
                            if (year >= 10)
                                if (year >= 15)
                                    if (year >= 20)
                                        if (year >= 25)
                                            { prized *= 0.5; pr = "50%"; }
                                        else
                                            { prized *= 0.45; pr = "45%"; }
                                    else
                                        { prized *= 0.35; pr = "35%"; }
                                else
                                    { prized *= 0.25; pr = "25%"; }
                            else
                                { prized *= 0.15; pr = "15%"; }
                    Console.WriteLine("With such length of service, the premium is {0} = {1}", pr, prized);
                }
            while (Ques()) ;            

            bool Ques()
            {
                Console.Write("Would you like to continue?(Y/N) ");
                string choise = Console.ReadLine();
                if (choise == "N") return false;
                else
                {
                    Console.WriteLine();
                    return true;
                }
            }
        }
    }
}
