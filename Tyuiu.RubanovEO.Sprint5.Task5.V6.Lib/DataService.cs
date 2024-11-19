
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            double res;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                double i = 0;
                double summ = 0;
                while ((line = reader.ReadLine()) != null)
                {
                    summ += double.Parse(line.Trim());
                    i++;
                }
                res = Math.Round(summ / i, 3);
            }
            return res;
        }
    }
}
