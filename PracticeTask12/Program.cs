using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeTask12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создание трех массивов длиной 100
            Collections col = new Collections();
            // Вспомогательные переменные для работы с массивами
            int[] ArrInc = col.GetArray(1);
            int[] ArrDec = col.GetArray(-1);
            int[] ArrUns = col.GetArray(0);

            Console.WriteLine("Упорядоченный по возрастанию массив:");
            col.PrintArray(ArrInc);
            Console.WriteLine("\n");
            Console.WriteLine("Упорядоченный по убыванию массив:");
            col.PrintArray(ArrDec);
            Console.WriteLine("\n");
            Console.WriteLine("Неупорядоченный массив:");
            col.PrintArray(ArrUns);
            Console.WriteLine("\n");

            Console.WriteLine("Нажмите любую клавишу...");
            Console.ReadKey();
        }
    }
}
