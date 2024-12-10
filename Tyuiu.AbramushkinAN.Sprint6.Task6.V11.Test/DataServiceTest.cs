using Tyuiu.AbramushkinAN.Sprint6.Task6.V11.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task6.V11.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CollectTextFromFileTest()
        {
            DataService ds = new DataService();
            string wait = "btwMCZUcBPADUsjhluJmjQKHdTMRyztkPxzEVkcarVMlQEUWCvEgL";
            string path = @"C:\Users\User\Desktop\DataSprint6\InPutDataFileTask6V11.txt";
            string str = "";
            Assert.AreEqual(wait, ds.CollectTextFromFile(str, path));
        }
    }
}