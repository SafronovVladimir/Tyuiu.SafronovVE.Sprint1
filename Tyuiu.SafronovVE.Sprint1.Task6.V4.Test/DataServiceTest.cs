using Tyuiu.SafronovVE.Sprint1.Task6.V4.Lib;
namespace Tyuiu.SafronovVE.Sprint1.Task6.V4.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void ValidExpression()
        {
            DataService ds = new DataService();
            string value = "Кованые, оловянные, старинные часы";
            var wait = "оловянные старинные";
            var res = ds.CheckDoubleN(value);
            Assert.AreEqual(wait, res);
        }
    }
}
