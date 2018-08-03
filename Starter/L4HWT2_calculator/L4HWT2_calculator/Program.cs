using System;

namespace L4HWT2_calculator
{
    class Program
    {        
        static void Main(string[] args)
        {
            Start:
            int operand1 = 0, operand2 = 0;
            Console.Write("Введите операнд 1 - ");
            string op = Console.ReadLine(), chs;
            operand1 = Convert.ToInt32(op);
            Console.Write("Введите операнд 2 - ");
            op = Console.ReadLine();
            operand2 = Convert.ToInt32(op);
            Continue:
            Console.Write("Введите знак арифметического действия - ");
            string arf = Console.ReadLine();
            switch(arf)
            {
                case "+":
                    {
                        var rez = operand1 + operand2;
                        Console.WriteLine("{0} + {1} = {2}", operand1, operand2, rez);
                        Exxit:
                        Console.Write("Желаете продолжить(C) с этими операндами, создайть новые(N) или выйти(E)?(C/N/E) ");
                        chs = Console.ReadLine();
                        if (chs == "E") break;
                        else
                        if (chs == "C")
                        {
                            Console.WriteLine();
                            goto Continue;
                        }
                        if (chs == "N")
                        {
                            Console.WriteLine();
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка выбора, повторите, пожалуйста");
                            goto Exxit;
                        }
                    }
                case "-":
                    {
                        var rez = operand1 - operand2;
                        Console.WriteLine("{0} + {1} - {2}", operand1, operand2, rez);
                        Exxit:
                        Console.Write("Желаете продолжить(C) с этими операндами, создайть новые(N) или выйти(E)?(C/N/E) ");
                        chs = Console.ReadLine();
                        if (chs == "E") break;
                        else
                        if (chs == "C")
                        {
                            Console.WriteLine();
                            goto Continue;
                        }
                        if (chs == "N")
                        {
                            Console.WriteLine();
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка выбора, повторите, пожалуйста");
                            goto Exxit;
                        }
                    }
                case "*":
                    {
                        var rez = operand1 * operand2;
                        Console.WriteLine("{0} * {1} = {2}", operand1, operand2, rez);
                        Exxit:
                        Console.Write("Желаете продолжить(C) с этими операндами, создайть новые(N) или выйти(E)?(C/N/E) ");
                        chs = Console.ReadLine();
                        if (chs == "E") break;
                        else
                        if (chs == "C")
                        {
                            Console.WriteLine();
                            goto Continue;
                        }
                        if (chs == "N")
                        {
                            Console.WriteLine();
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка выбора, повторите, пожалуйста");
                            goto Exxit;
                        }
                    }
                case "/":
                    {
                        if (operand2 != 0)
                        {
                            var rez = operand1 / operand2;
                            Console.WriteLine("{0} / {1} = {2}", operand1, operand2, rez);
                        }
                        else
                        {
                            Console.WriteLine("На 0 делить запрещено!");
                            Console.WriteLine();
                            goto Start;
                        }
                        Exxit:
                        Console.Write("Желаете продолжить(C) с этими операндами, создайть новые(N) или выйти(E)?(C/N/E) ");
                        chs = Console.ReadLine();
                        if (chs == "E") break;
                        else
                        if (chs == "C")
                        {
                            Console.WriteLine();
                            goto Continue;
                        }
                        if (chs == "N")
                        {
                            Console.WriteLine();
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка выбора, повторите, пожалуйста");
                            goto Exxit;
                        }
                    }
                case "%":
                    {
                        if (operand2 != 0)
                        {
                            var rez = operand1 % operand2;
                            Console.WriteLine("{0} % {1} = {2}", operand1, operand2, rez);
                        }
                        else
                        {
                            Console.WriteLine("На 0 делить запрещено!");
                            Console.WriteLine();
                            goto Start;
                        }
                        Exxit:
                        Console.Write("Желаете продолжить(C) с этими операндами, создайть новые(N) или выйти(E)?(C/N/E) ");
                        chs = Console.ReadLine();
                        if (chs == "E") break;
                        else
                        if (chs == "C")
                        {
                            Console.WriteLine();
                            goto Continue;
                        }
                        if (chs == "N")
                        {
                            Console.WriteLine();
                            goto Start;
                        }
                        else
                        {
                            Console.WriteLine("Ошибка выбора, повторите, пожалуйста");
                            goto Exxit;
                        }
                    }
                default:
                    {
                        Console.WriteLine("Ошибка ввода, выберите другой арифметический знак");
                        Console.WriteLine();
                        goto Continue;
                    }
            }
        }
    }
}
