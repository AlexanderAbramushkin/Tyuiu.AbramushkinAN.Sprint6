using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task2.V20.Lib
{
    public class DataService : ISprint6Task2V20
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;

            double[] Array = new double[len];
            double ResOfFunc;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                ResOfFunc = Math.Round((Math.Sin(x) / (x + 1.2)) - Math.Sin(x) * 2 - 2*x,2);
                if (x +1.2 == 0)
                {
                    Array[count] = 0;
                }
                else
                {
                    Array[count] = ResOfFunc;
                }
                count++;
            }
            return Array;
        }
    }
}
