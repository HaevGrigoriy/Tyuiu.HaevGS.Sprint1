using Tyuiu.HaevGS.Sprint1.Task3.V5.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task3.V5.Test
{
    [TestClass]
    public sealed class DataSeviceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 2;
            double y = 3;
            double wait = 6;
            var res = ds.DistanceLength(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
