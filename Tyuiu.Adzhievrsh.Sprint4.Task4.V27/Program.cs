using System;
using Tyuiu.AdzhievRSh.Sprint4.Task4.V27.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task4.V27
{
    class Program
    { 
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #4 | Вариант 27";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #4                                                              *");
            Console.WriteLine("* Вариант #27                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан двумерный целочисленный массив 5 на 5. Найти сумму          *");
            Console.WriteLine("* нечетных элементов массива.                                            *");
            Console.WriteLine("***************************************************************************");

            int[,] matrix = new int[5, 5];

            Console.WriteLine("Введите элементы массива от 1 до 9:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("Элемент [" + i + "," + j + "] = ");
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            DataService service = new DataService();
            int result = service.Calculate(matrix);

            Console.WriteLine();
            Console.WriteLine("Сумма нечетных элементов = " + result);

            Console.ReadKey();
        }
    }
}