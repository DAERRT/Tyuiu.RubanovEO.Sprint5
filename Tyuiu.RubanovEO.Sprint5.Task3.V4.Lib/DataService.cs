
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            double y = Math.Round(Math.Log((x + 1) / (x + 2)), 3);

            string filePath = $@"{Directory.GetCurrentDirectory()}\OutPutFileTask3.bin";

            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.OpenOrCreate)))
            {
                writer.Write(BitConverter.GetBytes(y));
            }

            return filePath;
        }
    }
}
