using System;
using Tyuiu.AdzhievRSh.Sprint4.Task5.V16.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task5.V16
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #5 | Вариант 16";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Двумерные массивы                                                 *");
            Console.WriteLine("* Задание #5                                                              *");
            Console.WriteLine("* Вариант #16                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан двумерный массив 5 на 5, заполненный случайными числами     *");
            Console.WriteLine("* от -6 до 3. Заменить положительные элементы на 1.                       *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();
            int[,] matrix = new int[5, 5];

            Console.WriteLine("Исходный массив:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    matrix[i, j] = random.Next(-6, 4);
                    Console.Write(matrix[i, j] + "\t");
                }

                Console.WriteLine();
            }

            DataService service = new DataService();
            int[,] result = service.Calculate(matrix);

            Console.WriteLine();
            Console.WriteLine("Массив после замены положительных элементов на 1:");

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    Console.Write(result[i, j] + "\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}