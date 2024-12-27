using System.Linq;
namespace Tyuiu.FilimonchukED.Sprint6.Review.V14.Lib
{
    public class DataService
    {
        public static int[,] FillArray(int rows, int cols, int n1, int n2)
        {
            Random rand = new Random();
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j == 0 || j == 1)
                    {
                        array[i, j] = rand.Next(n1, n2 + 1); // Заполняем первые два элемента случайными числами
                    }
                    else
                    {
                        array[i, j] = array[i, j - 1] * array[i, j - 2]; // Произведение двух предыдущих
                    }
                }
            }

            return array;
        }
        public long GetProductOfEvenElements(int K, int L, int C)
        {
            long product = 1;
            for (int i = K; i <= L; i++)
            {
                if (i % 2 == 0) // Проверка на четность индекса
                {
                    product *= array[i, C];
                }
            }
            return product;
        }
    }
}
