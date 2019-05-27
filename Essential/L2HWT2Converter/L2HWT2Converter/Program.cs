using System;

namespace L2HWT2Converter
{
    internal class Program
    {
        private static bool Try()
        {
            Console.Write("Do u want to try again? (Y/N)");
            var check = Console.ReadKey();
            Console.Clear();
            return check.Key == ConsoleKey.Y;
        }
        static void Main()
        {
            do
            {
                double usd = 27.3352, eur = 30.9058, rub = 0.3723;
                ConsoleKeyInfo check;
                do
                {
                    Console.WriteLine("USD = {0}; EUR = {1}; RUB = {2}", usd, eur, rub);
                    Console.Write("Do u want to change kurs? (Y/N)");
                    check = Console.ReadKey();
                    if (check.Key == ConsoleKey.Y)
                    {
                        Console.Write("\nInput new Kurs USD - ");
                        usd = double.Parse(Console.ReadLine());
                        Console.Write("Input new Kurs EUR - ");
                        eur = double.Parse(Console.ReadLine());
                        Console.Write("Input new Kurs RUB - ");
                        rub = double.Parse(Console.ReadLine());
                    }
                } while (check.Key == ConsoleKey.Y);

                var convert = new Converter(usd, eur, rub);
                Console.Write("\nDo you want to convert UAH? (Y/N)");
                check = Console.ReadKey();
                if (check.Key == ConsoleKey.Y)
                {
                    var checkCurr = false;
                    do
                    {
                        Console.Write("\nIn which currency do you want to convert? (USD,EUR,RUB) - ");
                        var curr = Console.ReadLine();
                        switch (curr)
                        {
                            case "USD":
                            case "EUR":
                            case "RUB":
                                Console.Write("Input UAH - ");
                                var uah = double.Parse(Console.ReadLine());
                                Console.WriteLine("{0} UAH = {1} {2}",uah,convert.ConvertToCurr(uah, curr),curr);
                                checkCurr = true;
                                break;
                            default:
                                Console.WriteLine("\nError!Please, enter correct currency!");
                                break;
                        }
                    } while (!checkCurr);
                }
                else
                {
                    var checkCurr = false;
                    do
                    {
                        Console.Write("\nWhat currency do you want to convert? (USD,EUR,RUB) - ");
                        var curr = Console.ReadLine();
                        switch (curr)
                        {
                            case "USD":
                            case "EUR":
                            case "RUB":
                                Console.Write("Input {0} - ", curr);
                                var currDoub = double.Parse(Console.ReadLine());
                                Console.WriteLine("{0} {1} = {2} UAH",currDoub,curr,convert.ConvertToUah(currDoub, curr));
                                checkCurr = true;
                                break;
                            default:
                                Console.WriteLine("\nError!Please, enter correct currency!");
                                break;
                        }
                    } while (!checkCurr);
                }
            } while (Try());
        }
    }
}
