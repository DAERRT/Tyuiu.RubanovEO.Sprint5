
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task0.V4.Lib
{
    public class DataService : ISprint5Task0V4
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = "OutPutFileTask0.txt";
            File.Delete(filePath);
            double ans = Math.Round(2d * Math.Pow(x,3) + (1d/2d)*Math.Pow(x,2) - 3.5d * x + 2d, 3);
            File.AppendAllText(filePath, ans.ToString());
            return ans.ToString();
        }
    }
}
