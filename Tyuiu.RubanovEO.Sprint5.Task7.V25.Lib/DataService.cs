
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.RubanovEO.Sprint5.Task7.V25.Lib
{
    public class DataService : ISprint5Task7V25
    {
        public string LoadDataAndSave(string path)
        {
            string vocablary = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string filepath = Path.GetTempFileName();
            string in_ = File.ReadAllText(path);
            string out_ = "";
            for (int i = 0; i < in_.Length; i++)
            {
                if (!vocablary.Contains(in_[i]))
                {
                    out_ += Convert.ToString(in_[i]);
                }
            }
            out_.Trim();
            char[] asd = out_.ToCharArray();
            out_ = "";
            for (int i = 0;i < asd.Length; i++)
            {
                if (i != asd.Length-1)
                {   
                    if (asd[i] == ' ' && asd[i + 1] == ' ')
                    {
                        
                    }
                    else
                    {
                        out_ += Convert.ToString(asd[i]);
                    }
                }
                else
                {
                    out_ += Convert.ToString(asd[i]);
                }
            }
            File.WriteAllText(filepath, out_ );
            return out_.Trim();
        }
    }
}
