using System;
using Tyuiu.AdzhievRSh.Sprint4.Task7.V23.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task7.V23
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #7 | Вариант 23";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #7                                                              *");
            Console.WriteLine("* Вариант #23                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дана строка из однозначных цифр. Преобразовать ее в матрицу     *");
            Console.WriteLine("* 4 на 3 и подсчитать количество четных чисел.                           *");
            Console.WriteLine("***************************************************************************");

            string value = "678135972584";

            int n = 4;
            int m = 3;

            Console.WriteLine("Исходная строка: " + value);
            Console.WriteLine();
            Console.WriteLine("Полученная матрица:");

            int index = 0;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(value[index] + "\t");
                    index++;
                }

                Console.WriteLine();
            }

            DataService service = new DataService();
            int result = service.Calculate(n, m, value);

            Console.WriteLine();
            Console.WriteLine("Количество четных чисел = " + result);

            Console.ReadKey();
        }
    }
}