using Tyuiu.AbramushkinAN.Sprint6.Task7.V1.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task7.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidGetMatrix()
        {
            DataService dataService = new DataService();

            string path = $"C:\\Users\\User\\source\\repos\\Tyuiu.AbramushkinAN.Sprint6\\DataSprint6\\InPutDataFileTask7V1.csv";
            int[,] arraywait = {{-14 ,1, - 18 ,15, - 10, 6,   7, - 11, - 9, - 19, }, 
                                { -4,1, -6,  4,   -20, -13, -12, -19, 10,  2},
                                { -11,   1,   7,   -8,  -17, -12, -2,  -7,  18,  -2},
                                { 0, 6 ,  3 ,  -14, 13,  -10, 9  , 5 ,  -3,  19},
                                { -8,    13,  -4,  -14, -3 , -7,  -7,  14,  -11, -8},
                                {-19 ,   1,  -7 , -6,  16,  -10, -10 ,20 , -11, 15 },
                                { -2,   16,  -1,  20,  3 ,  -18, -8 , 11 , -10, 4},
                                { -3   , 10,  3,   2,   6 ,  -8,  4 ,  13,  -19, 1},
                                {1,  9,   -11, 7  , -3 , -11, -4 , 4 ,  -15, -13 },
                                { 7, 1, 10,  -2,  2,   -8,  -7,  -18, 13,  15} };
            int[,] array = dataService.GetMatrix(path);
            CollectionAssert.AreEqual(arraywait, array);
                
            
        }
    }
}