using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.PozhdinAA.Sprint1.Task3.V12.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task3.V12.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            double x = 5;
            double y = 5;
            double wait = 12.5;
            var res = ds.TriangleArea(x, y);
            Assert.AreEqual(wait, res);
        }
    }
}
