using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task3.V12
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
            Console.WriteLine("* Задание #3                                                                                      *");
            Console.WriteLine("* Вариант #12                                                                                     *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУб-23-1                                              *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                                        *");
            Console.WriteLine("* Написать программу для вычисления площади прямоугольного треугольника по длинам двух катетов.   *");
            Console.WriteLine("*                                                                                                 *");
            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                                *");
            Console.WriteLine("***************************************************************************************************");

            double lengthCathetus1 = 5;
            double lengthCathetus2 = 5;
            Console.WriteLine("Сторона A прямоугольно треугольника = " + lengthCathetus1);
            Console.WriteLine("Сторона B прямоугольно треугольника = " + lengthCathetus2);

            Console.WriteLine("***************************************************************************************************");
            Console.WriteLine("* РЕУЗЛЬТАТ:                                                                                      *");
            Console.WriteLine("***************************************************************************************************");

            Console.WriteLine("Площадь прямоуголного треугольника = " + ds.TriangleArea(lengthCathetus1, lengthCathetus2));

            Console.ReadKey();
        }
    }
}
