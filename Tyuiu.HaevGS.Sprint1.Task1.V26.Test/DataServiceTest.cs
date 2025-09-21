using Tyuiu.HaevGS.Sprint1.Task1.V26.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task1.V26.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1;
            double y = 2;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(-1, res);
        }
    }
}
