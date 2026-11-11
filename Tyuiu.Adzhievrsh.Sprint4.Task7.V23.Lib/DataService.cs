using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.AdzhievRSh.Sprint4.Task7.V23.Lib
{
    public class DataService : ISprint4Task7V23
    {
        public int Calculate(int n, int m, string value)
        {
            int count = 0;
            int index = 0;

            int[,] matrix = new int[n, m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    matrix[i, j] = value[index] - '0';

                    if (matrix[i, j] % 2 == 0)
                    {
                        count++;
                    }

                    index++;
                }
            }

            return count;
        }
    }
}