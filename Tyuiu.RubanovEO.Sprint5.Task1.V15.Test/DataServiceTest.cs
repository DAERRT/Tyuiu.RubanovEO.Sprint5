using Tyuiu.RubanovEO.Sprint5.Task1.V15.Lib;

namespace Tyuiu.RubanovEO.Sprint5.Task1.V15.Test
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
            Assert.That(ds.SaveToFileTextData(5,5), Is.EqualTo("-36,3 "));
        }
    }
}