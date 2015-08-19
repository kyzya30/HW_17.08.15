using System;


namespace HW_Conditions_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число:");
            int UserValue = int.Parse(Console.ReadLine());

            if (UserValue >= 0 && UserValue <= 14)
            { Console.WriteLine("Данное число входит в промежуток от 0 до 14"); }
            else if (UserValue >= 15 && UserValue <= 35)
            { Console.WriteLine("Данное число входит в промежуток от 15 до 35"); }
            else if (UserValue >= 36 && UserValue <= 50)
            { Console.WriteLine("Данное число входит в промежуток от 36 до 50"); }
            else if (UserValue >= 50 && UserValue <= 100)
            { Console.WriteLine("Данное число входит в промежуток от 50 до 100"); }
            else
            { Console.WriteLine("Данное число не входит ни в один с промежутков [0 - 14] [15 - 35] [36 - 50] [50 - 100]"); }
        }
    }
}
