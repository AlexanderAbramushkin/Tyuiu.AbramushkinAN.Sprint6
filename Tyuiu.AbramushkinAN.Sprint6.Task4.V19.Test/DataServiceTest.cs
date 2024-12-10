using Tyuiu.AbramushkinAN.Sprint6.Task4.V19.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task4.V19.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            int LenOfValue = endValue - startValue + 1;
            double[] WaitArray = new double[LenOfValue];

            WaitArray[0] = 23.61;
            WaitArray[1] = 16.08;
            WaitArray[2] = 7.84;
            WaitArray[3] = 4.58;
            WaitArray[4] = 2.88;
            WaitArray[5] = 0.75;
            WaitArray[6] = -4.47;
            WaitArray[7] = -9.46;
            WaitArray[8] = -7.41;
            WaitArray[9] = -6.16;
            WaitArray[10] = -7.29;

            double[] result = new double[LenOfValue];
            result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(WaitArray, result);
        }
    }
}