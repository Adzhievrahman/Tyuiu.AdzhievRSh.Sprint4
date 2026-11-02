using System;
using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Adzhievrsh.Sprint4.Task1.V1.Lib
{
    public class DataService : ISprint4Task1V1
    {
        public int Calculate(int[] array)
        {
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % 2 == 0)
                {
                    sum += array[i];
                }
            }

            return sum;
        }
    }
}