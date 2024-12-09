using System.ComponentModel.DataAnnotations;
using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task1.V15.Lib
{
    public class DataService : ISprint6Task1V15
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            int len = (stopValue- startValue)+1;
            
            double[] Array = new double[len];
            double ResOfFunc = 0;
            int count = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                ResOfFunc = Math.Round((Math.Cos(x)/(x-0.7))-Math.Sin(x)*12*x+2,2);
                if (x - 0.7 == 0)
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
