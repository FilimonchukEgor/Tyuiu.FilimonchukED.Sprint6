using Tyuiu.FilimonchukED.Sprint6.Task0.V14.Lib;
namespace Tyuiu.FilimonchukED.Sprint6.Task0.V14.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double res = ds.Calculate(3);
            double wait = -0.444;
            Assert.AreEqual(wait, res);
        }
    }
}
