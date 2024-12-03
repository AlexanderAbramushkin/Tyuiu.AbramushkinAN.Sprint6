using Tyuiu.AbramushkinAN.Sprint6.Task0.V11.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task0.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int x = 2;
            double res = ds.Calculate(x);
            double wait = 18.4;
            Assert.AreEqual(wait, res);
        }
    }
}