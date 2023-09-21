using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PozhdinAA.Sprint1.Task2.V23.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task2.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            int x = 20;
            var res = ds.ConvertMinutesToSeconds(x);
            Assert.AreEqual(1200, res);
        }
    }
}
