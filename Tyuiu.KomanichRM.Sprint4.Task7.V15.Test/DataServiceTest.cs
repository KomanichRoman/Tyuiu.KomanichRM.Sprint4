using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint4.Task7.V15.Lib;

namespace Tyuiu.KomanichRM.Sprint4.Task7.V15.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            // Task7
            int rows = 4;
            int colums = 2;
            int[,] mtrx = new int[rows, colums];
            string str = "10293847";
            int res = ds.Calculate(rows, colums, str);
            int wait = 4;
            Assert.AreEqual(res, wait);
        }
    }
}
