using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;


using Tyuiu.PozhdinAA.Sprint1.Task1.V0.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task1.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 1.0;
            double y = 2.0;
            var res = ds.Calculate(x, y);
            Assert.AreEqual(1.5, res);

        }
    }
}
