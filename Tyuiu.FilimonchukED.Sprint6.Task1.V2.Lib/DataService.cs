using tyuiu.cources.programming.interfaces.Sprint6;
namespace Tyuiu.FilimonchukED.Sprint6.Task1.V2.Lib
{
    public class DataService : ISprint6Task1V2
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] array;
            int len = stopValue - startValue + 1;
            array = new double[len];
            double y;
            int count = 0;
            for (int i = startValue; i < stopValue; i++) 
            {
                if (Math.Sin(i) != -2)
                {
                    y = ((5 * i + 2.5) / (Math.Sin(i) + 2)) + 2 * i + 2;
                    array[count] = Math.Round(y, 2);
                    count++;
                }
                else y = 0;
            }
            return array;
        }
    }
}
