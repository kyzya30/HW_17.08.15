using System;


namespace HW_Conditions
{
    class Program
    {
        static void Main(string[] args)
        {
            double operand1 = 000;
            double operand2 = 10;
            Console.WriteLine("Введите арифметическую операцию:");
            char sign = char.Parse(Console.ReadLine());
            switch (sign)
            {
                case '+':
                    Console.WriteLine("Result:{0}", operand1 + operand2 );
                    break;
                case '-':
                    Console.WriteLine("Result:{0}", operand1 - operand2);
                    break;
                case '*':
                    Console.WriteLine("Result:{0}", operand1 * operand2);
                    break;
                case '/':
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Ошибка.Попытка выполнения деления на 0");
                    }
                    else
                    {
                        Console.WriteLine("Result:{0}", operand1 / operand2);
                    }
                    break;
                default:
                    Console.WriteLine("Ошибка выбора арифметической операции");
                    break;
            }
        }
    }
}
