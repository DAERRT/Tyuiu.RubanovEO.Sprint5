
using System.Linq;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task4.V11.Lib
{
    public class DataService : ISprint5Task4V11
    {
        public double LoadFromDataFile(string path)
        {
            char[] chars = File.ReadAllText(path).ToCharArray();
            string b = "";
            for (int i = 0; i < chars.Length; i++)
            {
                if (chars[i] == '.')
                {
                    chars[i] = ',';
                    b += Convert.ToString(chars[i]);
                }
                else
                {
                    b += Convert.ToString(chars[i]);
                }
            }
            double x = double.Parse(b);
            return Math.Round(Math.Sin(x) + (Math.Pow(x,2d)/2d),3);
        }
    }
}
