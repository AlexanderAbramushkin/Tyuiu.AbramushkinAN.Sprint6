using Tyuiu.AbramushkinAN.Sprint6.Task3.V6.Lib;

namespace Tyuiu.AbramushkinAN.Sprint6.Task3.V6.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] array = new int[5,5]{ { -2, -10, -8, 11, 1 },
                                             { -15,-9,-4,-15,18    },
                                             { -15,  12,   7 ,  6,   9 },
                                             { -14 ,-10 , 10 , 18 , -5 },
                                             { -1  , 7 ,-19 ,-19 , -4}};
            int[,] waitarray = new int[5, 5]{ { -2, -10, -8, 11, 1 },
                                             { -15,-9,-4,-15,18    },
                                             { -15,  0,   7 ,  0,   9 },
                                             { -14 ,-10 , 10 , 18 , -5 },
                                             { -1  , 7 ,-19 ,-19 , -4}};
            int[,] resarray = ds.Calculate(array);
            CollectionAssert.AreEqual(waitarray,resarray);
        }
    }
}