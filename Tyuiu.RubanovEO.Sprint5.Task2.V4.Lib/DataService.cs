
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task2.V4.Lib
{
    public class DataService : ISprint5Task2V4
    {
        public string SaveToFileTextData(int[,] matrix)
        {
            string filePath = @"C:\Users\olego\source\repos\Tyuiu.RubanovEO.Sprint5\OutPutFileTask2.csv";
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i,j] > 0)
                    {
                        matrix[i, j] = 1;
                    }
                    else
                    {
                        matrix[i, j] = 0;
                    }
                    File.WriteAllText(filePath, Convert.ToString(matrix[i,j]));
                }
            }
            return filePath;
        }
    }
}
