using System;
using Tyuiu.Adzhievrsh.Sprint4.Task2.V10.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task2.V10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #2 | Вариант 10";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Одномерные массивы                                                *");
            Console.WriteLine("* Задание #2                                                              *");
            Console.WriteLine("* Вариант #10                                                             *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан массив из 13 элементов, заполненный случайными числами     *");
            Console.WriteLine("* от 1 до 6. Подсчитать произведение нечетных элементов массива.          *");
            Console.WriteLine("***************************************************************************");

            Random random = new Random();
            int[] array = new int[13];

            Console.WriteLine("Сгенерированный массив:");

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = random.Next(1, 7);
                Console.Write(array[i] + " ");
            }

            DataService service = new DataService();
            int result = service.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("Произведение нечетных элементов = " + result);

            Console.ReadKey();
        }
    }
}