using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.Adzhievrsh.Sprint4.Task6.V8.Lib
{
    public class DataService : ISprint4Task6V8
    {
        public string[] Calculate(string[] array)
        {
            string[] result = Array.FindAll(array, item => item.Length > 4);

            return result;
        }
    }
}