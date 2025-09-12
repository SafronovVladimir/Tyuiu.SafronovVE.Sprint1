﻿using Tyuiu.SafronovVE.Sprint1.Task1.V29.Lib;
namespace Tyuiu.SafronovVE.Sprint1.Task1.V29.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double a = 3.0;
            double b = 2.0;
            double c = 1.0;

            var res = ds.Calculate(a, b, c);
            Assert.AreEqual(1, res);
        }
    }
}
