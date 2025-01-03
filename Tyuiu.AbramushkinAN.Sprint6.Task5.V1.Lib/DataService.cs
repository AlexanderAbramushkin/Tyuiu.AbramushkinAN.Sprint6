﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task5.V1.Lib
{
    public class DataService : ISprint6Task5V1
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {
            using (StreamReader reader = new StreamReader(path)) {
                string line;
                while((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }
            double[] numsArray = new double[len];
            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Math.Round(Convert.ToDouble(line),3);
                    index++;
                }
            }
            numsArray = numsArray.Where(val=>val>0).ToArray();
            return numsArray;
            



        }
    }
}
