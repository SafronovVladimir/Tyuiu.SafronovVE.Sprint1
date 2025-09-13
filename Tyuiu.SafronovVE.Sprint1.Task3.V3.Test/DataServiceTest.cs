using Tyuiu.SafronovVE.Sprint1.Task3.V3.Lib;
namespace Tyuiu.SafronovVE.Sprint1.Task3.V3.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();

            double length = 2;
            double width = 4;
            double height = 8;

            var res = ds.ParallelepipedVolume(length, width, height);
            Assert.AreEqual(64, res);
        }
    }
}
