
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            string filePath = @"C:\Users\olego\source\repos\Tyuiu.RubanovEO.Sprint5\OutPutFileTask3.bin";
            string ans = Convert.ToString(Math.Round(Math.Log((x+1d)/(x+2d)), 3));
            try{using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
                {
                    writer.Write(ans);
                }
            }catch (Exception ex) {}
            return ans;
        }
    }
}
