using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Tyuiu.KomanichRM.Sprint4.Task6.V2.Lib;

namespace Tyuiu.KomanichRM.Sprint4.Task6.V2.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void ValidCalculate()
        {
            DataService ds = new DataService();
            var colors = new string[] { "Белый", "Черный", "Зеленый", "Синий", "Красный", "Желтый", "Фиолетовый" };
            string[] res = ds.Calculate(colors);
            string[] wait = { "Черный", "Зеленый", "Красный", "Желтый", "Фиолетовый" };
            CollectionAssert.AreEqual(res, wait);
        }
    }
}
