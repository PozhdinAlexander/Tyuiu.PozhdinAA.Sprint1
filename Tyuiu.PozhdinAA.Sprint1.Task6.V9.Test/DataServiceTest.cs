using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.PozhdinAA.Sprint1.Task6.V9.Lib;

namespace Tyuiu.PozhdinAA.Sprint1.Task6.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();

            string value = "дом карта";
            string res = ds.MoveLetterToStart(value);
            string wait = "мдо акарт";
            Assert.AreEqual(wait, res);
        }
    }
}