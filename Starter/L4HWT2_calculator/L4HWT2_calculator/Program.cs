using System;

namespace L4HWT2_calculator
{
    class Program
    {        
        static void Main(string[] args)
        {
            do
            {
                int operand1 = 0, operand2 = 0;
                Console.Write("Введите операнд 1 - ");
                string operands = Console.ReadLine();
                operand1 = Convert.ToInt32(operands);
                Console.Write("Введите операнд 2 - ");
                operands = Console.ReadLine();
                operand2 = Convert.ToInt32(operands);
                Console.Write("Введите знак арифметического действия - ");
                string arf = Console.ReadLine();
                switch (arf)
                {
                    case "+":
                        {
                            var rez = operand1 + operand2;
                            Console.WriteLine("{0} + {1} = {2}", operand1, operand2, rez);
                            break;
                        }
                    case "-":
                        {
                            var rez = operand1 - operand2;
                            Console.WriteLine("{0} + {1} - {2}", operand1, operand2, rez);
                            break;
                        }
                    case "*":
                        {
                            var rez = operand1 * operand2;
                            Console.WriteLine("{0} * {1} = {2}", operand1, operand2, rez);
                            break;
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
                            }
                            break;
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
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка ввода, выберите другой арифметический знак");
                            Console.WriteLine();
                            break;
                        }
                }
            }
            while (Ques());
            bool Ques()
            {                
                Console.Write("Желаете продолжить?(Y/N) ");
                string choise = Console.ReadLine();
                if (choise == "N") return false;
                else return true;
            }
        }
    }
}
