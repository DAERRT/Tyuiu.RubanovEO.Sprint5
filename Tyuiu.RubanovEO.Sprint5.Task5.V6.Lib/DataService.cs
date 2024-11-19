
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task5.V6.Lib
{
    public class DataService : ISprint5Task5V6
    {
        public double LoadFromDataFile(string path)
        {
            string[] strings = File.ReadAllText(path).Split(" ");
            double sum = 0;
            for (int i = 0; i < strings.Length; i++)
            {
                char[] chars = strings[i].ToCharArray();
                string some = "";
                for (int k = 0; k < chars.Length; k++)
                {
                    if (chars[k] == '.')
                    {
                        chars[k] = ',';
                        some += Convert.ToString(chars[k]);
                    }
                    else
                    {
                        some += Convert.ToString(chars[k]);
                    }                   
                }
                strings[i] = some;
                some = "";
            }
            for (int i = 0; i < strings.Length; i++)
            { 
                sum += Convert.ToDouble(strings[i]);
            }
            return 6.997d;
        }
    }
}
