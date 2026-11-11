using tyuiu.cources.programming.interfaces.Sprint4;


namespace Tyuiu.AdzhievRSh.Sprint4.Task3.V22.Lib
{
    public class DataService : ISprint4Task3V22
    {
        public int Calculate(int[,] array)
        {
            int max = array[0, 0]; 

            for (int j = 0; j < array.GetLength(1); j++)
            {
                if (array[0, j] > max)
                {
                    max = array[0, j];
                }
            }

            return max;
        }
    }
}