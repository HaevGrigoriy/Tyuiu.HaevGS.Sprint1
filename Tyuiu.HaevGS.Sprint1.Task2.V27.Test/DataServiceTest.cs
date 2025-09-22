using Newtonsoft.Json.Linq;
using Tyuiu.HaevGS.Sprint1.Task2.V27.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task2.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression() 
        {
            DataServiceTest ds = new DataServiceTest();
            int x = 2;
            var res = ds.CalculateSquarePerimetr(x);
            Assert.AreEqual(4, res);
        }
    }
}
