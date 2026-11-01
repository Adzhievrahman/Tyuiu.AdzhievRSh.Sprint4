using System;
using Tyuiu.Adzhievrsh.Sprint4.Task0.V20.Lib;

namespace Tyuiu.Adzhievrsh.Sprint4.Task0.V20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Спринт #4 | Task #0 | Вариант 20";

            Console.WriteLine("****************************************************");
            Console.WriteLine("* Спринт #4                                        *");
            Console.WriteLine("* Task #0                                          *");
            Console.WriteLine("* Выполнил: Аджиев Р.Ш. | ИИП6-26-1               *");
            Console.WriteLine("****************************************************");
            Console.WriteLine();

            DataService ds = new DataService();

            int[] array = { 4, 8, 7, 6, 5, 8, 2, 4, 3, 2 };

            Console.WriteLine("Исходный массив:");

            foreach (int number in array)
            {
                Console.Write(number + " ");
            }

            Console.WriteLine();

            int result = ds.GetMultEvenArrEl(array);

            Console.WriteLine();
            Console.WriteLine($"Произведение четных элементов = {result}");

            Console.ReadKey();
        }
    }
}