
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round(Math.Log((x + 1) / (x + 2)), 3);

            byte[] bytes = BitConverter.GetBytes(y);

            string filePath = Path.GetTempFileName(); 
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            return filePath;
        }
    }
}
