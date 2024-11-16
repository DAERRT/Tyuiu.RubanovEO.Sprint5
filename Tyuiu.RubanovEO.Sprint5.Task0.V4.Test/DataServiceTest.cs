using Tyuiu.RubanovEO.Sprint5.Task0.V4.Lib;

namespace Tyuiu.RubanovEO.Sprint5.Task0.V4.Test
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
            Assert.That(ds.SaveToFileTextData(2), Is.EqualTo("13"));
            Assert.That(File.ReadAllText("OutPutFileTask0.txt"), Is.EqualTo("13"));
        }
    }
}