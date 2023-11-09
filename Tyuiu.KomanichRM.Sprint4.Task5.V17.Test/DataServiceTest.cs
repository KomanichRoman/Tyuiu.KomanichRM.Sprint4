using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint4.Task5.V17.Lib;

namespace Tyuiu.KomanichRM.Sprint4.Task5.V17.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            int[,] mas2 = new int[5, 5] { { 9, 6, 9, 3, 7 },
                                          { 3, 3, -3, 8, 2 },
                                          { 2, 1, 3, 5, 2 },
                                          { 6, 2, 3, 2, -5 },
                                          { 4, 5, 6, 9, 5 } };
            int res = ds.Calculate(mas2);
            int wait = 2;
            Assert.AreEqual(wait, res);
        }
    }
}
