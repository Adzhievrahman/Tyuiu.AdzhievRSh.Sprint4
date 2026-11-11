using System;
using Tyuiu.Adzhievrsh.Sprint4.Task3.V22.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task3.V22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #3 | Вариант 22";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #3                                                              *");
            Console.WriteLine("* Вариант #22                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5. Найти максимальный   *");
            Console.WriteLine("* элемент в первой строке массива.                                       *");
            Console.WriteLine("***************************************************************************");

            int[,] array =
            {
                { 4, 4, 7, 8, 9 },
                { 9, 5, 9, 7, 8 },
                { 7, 4, 9, 4, 6 },
                { 4, 4, 7, 4, 4 },
                { 4, 5, 8, 6, 7 }
            };

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    Console.Write(array[i, j] + "\t");
                }
                Console.WriteLine();
            }

            DataService service = new DataService();
            int result = service.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("Максимальный элемент первой строки = " + result);

            Console.ReadKey();
        }
    }
}