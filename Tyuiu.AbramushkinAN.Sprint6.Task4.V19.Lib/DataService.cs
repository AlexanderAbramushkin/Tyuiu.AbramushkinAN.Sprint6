using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task4.V19.Lib
{
    public class DataService : ISprint6Task4V19
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue - startValue) + 1;

            double[] Array = new double[len];
            double ResOfFunc;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                ResOfFunc = Math.Round((5 * x + 2.5) / (Math.Sin(x) - 2) + 2, 2);
                if (Math.Sin(x) - 2 == 0)
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
