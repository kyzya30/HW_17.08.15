using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_Machine_Mathematics_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstString = "\nмоя строка 1"; // \n перевод текста на новую строку
            string secondString = "\tмоя строка 2"; //Используеться отступ в виде табуляции
            string thirdString = "\aмоя строка 3" ; //Звуковое уведомление (а - alarm)
            Console.WriteLine(firstString);
            Console.WriteLine(secondString);
            Console.WriteLine(thirdString);
        }
    }
}
