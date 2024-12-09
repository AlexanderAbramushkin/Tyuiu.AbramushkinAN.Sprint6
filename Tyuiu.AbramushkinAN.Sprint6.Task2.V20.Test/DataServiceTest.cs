using Tyuiu.AbramushkinAN.Sprint6.Task2.V20.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task2.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunction()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            int LenOfValue = endValue - startValue + 1;
            double[] WaitArray = new double[LenOfValue];

            WaitArray[0] = 7.83;
            WaitArray[1] = 6.22;
            WaitArray[2] = 6.36;
            WaitArray[3] = 6.96;
            WaitArray[4] = -0.52;
            WaitArray[5] = 0;
            WaitArray[6] = -3.30;
            WaitArray[7] = -5.53;
            WaitArray[8] = -6.25;
            WaitArray[9] = -6.63;
            WaitArray[10] = -8.24;

            double[] result = new double[LenOfValue];
            result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(WaitArray, result);
        }
    }
}