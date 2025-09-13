using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SafronovVE.Sprint1.Task5.V5.Lib
{
    public class DataService : ISprint1Task5V5
    {
        public int Calculate(double x)
        {
            double res = (x - Math.Floor(x)) * 10;
            res = Math.Floor(res);
            return Convert.ToInt32(res);
        }
    }
}
