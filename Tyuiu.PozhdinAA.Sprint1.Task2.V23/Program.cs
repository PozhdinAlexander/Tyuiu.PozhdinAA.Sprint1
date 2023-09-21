using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint1.Task2.V23.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task2.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил Пождин А. А. | АСОиУб-23-1";
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                                       *");
            Console.WriteLine("* Тема: Базовые навыки работы с C#                                                                *");
            Console.WriteLine("* Задание #2                                                                                      *");
            Console.WriteLine("* Вариант #23                                                                                     *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУб-23-1                                              *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу, которая запрашивает у пользователя исходные данные, выполняет               *");
            Console.WriteLine("* указанные расчёты и печатает результат на экране.                                               *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            int x;

            Console.WriteLine("Введите кол-во минут для конвертации в секунды:                                                   *");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("Конвертированное значение количества минут в секунды:" + Convert.ToInt32(60 * x));
            Console.ReadLine();

        }
    }
}
