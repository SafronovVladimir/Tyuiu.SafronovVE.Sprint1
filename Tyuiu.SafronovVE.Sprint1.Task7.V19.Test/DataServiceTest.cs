using Tyuiu.SafronovVE.Sprint1.Task7.V19.Lib;
namespace Tyuiu.SafronovVE.Sprint1.Task7.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            var x = Math.PI;
            var res = ds.Calculate(x);
            var wait = 209.524;
            Assert.AreEqual(wait, res);
        }
    }
}
