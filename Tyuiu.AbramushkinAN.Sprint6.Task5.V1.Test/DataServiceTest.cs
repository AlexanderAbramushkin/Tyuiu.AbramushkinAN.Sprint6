using Tyuiu.AbramushkinAN.Sprint6.Task5.V1.Lib;
namespace Tyuiu.AbramushkinAN.Sprint6.Task5.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestLoadFromDataFile()
        {
            DataService ds = new DataService();
            string path = @"C:\\Users\\User\\source\\repos\\Tyuiu.AbramushkinAN.Sprint6\\DataSprint6\\InPutDataFileTask5V1.txt";
            double[] numsArray = ds.LoadFromDataFile(path);
            double[] wait = { 1, 2, 3, 5, 6, 7, 8, 9, 10 };
            CollectionAssert.AreEqual(wait, numsArray);
        }
    }
}