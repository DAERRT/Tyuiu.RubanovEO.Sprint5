
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task1.V15.Lib
{
    public class DataService : ISprint5Task1V15
    {
        public string SaveToFileTextData(int startValue, int stopValue)
        {
            string filePath = @"C:\Users\olego\source\repos\Tyuiu.RubanovEO.Sprint5\OutPutFileTask1.txt";
            double ans;
            string ans1 = "";
            File.Delete(filePath);
            for (double i = startValue; i <= stopValue; i++)
            {
                if (i - 0.4d != 0) 
                { 
                    ans = Math.Round((Math.Cos(i) / (i - 0.4d)) + Math.Sin(i) * 8 * i + 2, 2);
                }
                else
                {
                    ans = 0;
                }
                try{ File.AppendAllText(filePath, $"{ans}\n"); }catch (Exception ex) { }
                ans1 += $"{ans} ";
            }
            return ans1.Trim();
        }
    }
}
