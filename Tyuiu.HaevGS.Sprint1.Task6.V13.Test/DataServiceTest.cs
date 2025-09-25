using Tyuiu.HaevGS.Sprint1.Task6.V13.Lib;

using System;

namespace Tyuiu.HaevGS.Sprint1.Task6.V13.Test

{
    class DataServiveTest
    {

        [TestMethod]
        public void TestMethod()
        {
            DataService ds = new DataService();
            String x = "ABCD";
            bool res = ds.CheckWordsAlphabet(x);
            Assert.AreEqual(res, true);
        }
    }
}