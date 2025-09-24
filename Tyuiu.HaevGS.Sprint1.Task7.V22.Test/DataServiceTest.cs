using Tyuiu.HaevGS.Sprint1.Task7.V22.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task7V22.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 4;
            double wait = 0.172;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
