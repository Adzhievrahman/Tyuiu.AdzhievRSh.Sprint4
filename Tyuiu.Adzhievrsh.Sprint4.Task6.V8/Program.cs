using System;
using Tyuiu.AdzhievRSh.Sprint4.Task6.V8.Lib;

namespace Tyuiu.AdzhievRSh.Sprint4.Task6.V8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #6 | Вариант 8";

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* Спринт #4                                                               *");
            Console.WriteLine("* Тема: Работа со строковыми массивами                                    *");
            Console.WriteLine("* Задание #6                                                              *");
            Console.WriteLine("* Вариант #8                                                              *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1                                       *");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* УСЛОВИЕ: Дан строковый массив данных. Используя класс Array, вывести    *");
            Console.WriteLine("* элементы массива, длина которых больше 4 символов.                     *");
            Console.WriteLine("***************************************************************************");

            string[] array =
            {
                "Пицца", "Борщ", "Пельмени",
                "Омлет", "Салат", "Суп", "Роллы"
            };

            Console.WriteLine("Исходный массив:");

            foreach (string item in array)
            {
                Console.WriteLine(item);
            }

            DataService service = new DataService();
            string[] result = service.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("Элементы длиной больше 4 символов:");

            foreach (string item in result)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();
        }
    }
}