using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.PozhdinAA.Sprint1.Task5.V3.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task5.V3
{
    class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.Title = "Спринт #1 | Выполнил: Пождин А. А. | АСОиУб-23-1";
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* Спринт #1                                                                         *");
            Console.WriteLine("* Тема: Преобразование типов и класс Convert                                        *");
            Console.WriteLine("* Задание #5                                                                        *");
            Console.WriteLine("* Вариант #3                                                                        *");
            Console.WriteLine("* Выполнил: Пождин Александр Андреевич | АСОиУб-23-1                                *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* УСЛОВИЕ:                                                                          *");
            Console.WriteLine("* Написать программу, которая решает следующую задачу: Присвоить целой переменной h *");
            Console.WriteLine("* третью от конца цифру в записи положительного целого числа k                      *");
            Console.WriteLine("*                                                                                   *");
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                                  *");
            Console.WriteLine("*************************************************************************************");

            int k, h;

            Console.WriteLine("Введите значение переменной k:");
            k = Convert.ToInt32(Console.ReadLine());

            h = ds.Calculate(k);
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("* РЕЗУЛЬТАТ:                                                                        *");
            Console.WriteLine("*************************************************************************************");

            Console.WriteLine($"k = {k}; h = {h}");
            Console.ReadKey();
        }
    }
}