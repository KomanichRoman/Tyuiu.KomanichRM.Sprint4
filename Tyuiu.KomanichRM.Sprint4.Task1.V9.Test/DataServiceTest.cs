using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint4.Task1.V9.Lib;

namespace Tyuiu.KomanichRM.Sprint4.Task1.V9.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[] numsArray = { 6, 3, 3, 7, 7, 7, 7, 3, 3, 6, 4, 4, 8 };
            int res = ds.Calculate(numsArray);
            int wait = 4608;
            Assert.AreEqual(res, wait);
        }
    }
}
