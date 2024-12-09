using Tyuiu.AbramushkinAN.Sprint6.Task1.V15.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task1.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void GetMassFunctionTest()
        {
            DataService ds = new DataService();

            int startValue = -5;
            int endValue = 5;
            int LenOfValue = endValue - startValue + 1;
            double[] WaitArray = new double[LenOfValue];

            WaitArray[0] = 59.49;
            WaitArray[1] = 38.47;
            WaitArray[2] = -2.81;
            WaitArray[3] = -19.67;
            WaitArray[4] = -8.42;
            WaitArray[5] = 0.57;
            WaitArray[6] = -6.30;
            WaitArray[7] = -20.14;
            WaitArray[8] = -3.51;
            WaitArray[9] = 38.13;
            WaitArray[10] = 59.60;

            double[] result = new double[LenOfValue];
            result = ds.GetMassFunction(startValue, endValue);
            CollectionAssert.AreEqual(WaitArray, result);
        }
    }
}