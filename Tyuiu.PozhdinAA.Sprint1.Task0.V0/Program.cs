using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint1.Task0.V0.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task0.V0
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
            Console.WriteLine("* Задание #0                                                                                      *");
            Console.WriteLine("* Вариант #5                                                                                      *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУб-23-1                                              *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать консольную программу , которая вычисляет выражение (15 / 5 * 4) + 1                    *");
            Console.WriteLine("* и печатает результат на экране.                                                                 *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* (15 / 5 * 4) + 1                                                                                *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine(ds.Calculate());

            Console.ReadLine();

        }
    }
}
