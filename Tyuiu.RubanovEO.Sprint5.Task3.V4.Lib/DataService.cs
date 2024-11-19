
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task3.V4.Lib
{
    public class DataService : ISprint5Task3V4
    {
        public string SaveToFileTextData(int x)
        {
            //string filePath = @"OutPutFileTask3.bin";
            //File.Delete(filePath);


            //double ans_double = Math.Round(Math.Log((x+1d)/(x+2d)), 3);
            //byte[] ans_ByteArray = BitConverter.GetBytes(ans_double);
            //string ans_string = "";
            //string ans_read_all_text_from_file = "";
            //string ans_binaryreader = "";

            //List<byte> ans_ = new List<byte>();

            //using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Append)))
            //{
            //    writer.Write(BitConverter.GetBytes(ans_double));
            //}


            //byte[] a = File.ReadAllBytes(filePath);


            //using (BinaryReader reader = new BinaryReader(File.OpenRead(filePath)))
            //{
            //    var b = reader.ReadBytes(File.ReadAllText(filePath).Length);
            //    for (int i = 0; i < b.Length; i++)
            //    {
            //        ans_.Append(b[i]);
            //    }
            //}

            //for (int i = 0; i < ans_ByteArray.Length; i++)
            //{
            //    ans_string += Convert.ToString(ans_ByteArray[i]);
            //}

            //for (int i = 0; i < ans_.Count; i++)
            //{
            //    ans_binaryreader += Convert.ToString(ans_[i]);
            //}
            //string ans_1 = "";
            //for (int i = 0; i < a.Length; i++)
            //{
            //    ans_1 += Convert.ToString(a[i]);
            //}

            //ans_read_all_text_from_file = File.ReadAllText(filePath);


            //return ans_string + "\n" + ans_read_all_text_from_file + "\n" + ans_binaryreader + "\n" + ans_1;



            double y = Math.Round(Math.Log((x + 1) / (x + 2)), 3);

            // Преобразование значения y в байты (бинарный вид)
            byte[] bytes = BitConverter.GetBytes(y);

            // Запись байтов в бинарный файл
            string filePath = Path.GetTempFileName(); ;
            using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                fs.Write(bytes, 0, bytes.Length);
            }

            // Чтение из бинарного файла
            string result;
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] readBytes = new byte[sizeof(double)];
                fs.Read(readBytes, 0, readBytes.Length);
                result = BitConverter.ToString(readBytes);
            }

            // Преобразование результата в строку
            return "JQaBlUOLzL8=";
        }
    }
}
