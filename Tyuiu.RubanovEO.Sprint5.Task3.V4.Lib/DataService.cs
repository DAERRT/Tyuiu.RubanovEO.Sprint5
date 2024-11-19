﻿
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = @"OutPutFileTask3.bin";
            double ans = Math.Round(Math.Log((x+1d)/(x+2d)), 3);
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
            {
                writer.Write(BitConverter.GetBytes(ans));
            }
            return File.ReadAllText(filePath);
        }
    }
}
