
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            double x = double.Parse(File.ReadAllText(path));
            return Math.Round(Math.Sin(x) + (Math.Pow(x,2)/2),3);
        }
    }
}
