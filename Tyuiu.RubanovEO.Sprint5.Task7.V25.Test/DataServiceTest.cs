using Tyuiu.RubanovEO.Sprint5.Task7.V25.Lib;

namespace Tyuiu.RubanovEO.Sprint5.Task7.V25.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            DataService ds = new DataService();
            Assert.That(ds.LoadDataAndSave(@"C:\Users\olego\source\repos\Tyuiu.RubanovEO.Sprint5\InPutDataFileTask7V25.txt"), Is.EqualTo("Привет мир!"));
        }
    }
}