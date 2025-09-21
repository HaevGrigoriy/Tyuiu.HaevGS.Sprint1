using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.HaevGS.Sprint1.Task0.V4.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task0.V4.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var res = ds.Calculate();
            Assert.AreEqual(2, res);
        }
    }
}
