﻿using tyuiu.cources.programming.interfaces.Sprint6;

namespace Tyuiu.AbramushkinAN.Sprint6.Task0.V11.Lib
{
    public class DataService : ISprint6Task0V11
    {
        public double Calculate(int x)
        {
            double res = 1.6*Math.Pow(x,3)-2.1*Math.Pow(x,2)+7*x;
            return Math.Round(res,3);
        }
    }
}
