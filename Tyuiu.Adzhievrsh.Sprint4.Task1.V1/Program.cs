using System;
using Tyuiu.Adzhievrsh.Sprint4.Task1.V1.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task1.V1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #1 | Вариант 1";

            Console.WriteLine("****************************************************");
            Console.WriteLine("* Спринт #4                                        *");
            Console.WriteLine("* Task #1                                          *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            int[] array = new int[10];

            Console.WriteLine("Введите 10 целых чисел от 0 до 9:");

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write($"Элемент [{i}] = ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            int result = ds.Calculate(array);

            Console.WriteLine();
            Console.WriteLine("Исходный массив:");

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();
            Console.WriteLine($"Сумма четных элементов массива = {result}");

            Console.ReadKey();
        }
    }
}