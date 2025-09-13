using tyuiu.cources.programming.interfaces.Sprint1;
namespace Tyuiu.SafronovVE.Sprint1.Task7.V19.Lib
{
    public class DataService : ISprint1Task7V19
    {
        public double Calculate(double x)
        {
            var z = x - 7 * Math.Pow(x, 2) / Math.Pow(x, 3) + Math.Sin(x) + Math.Abs(Math.Pow(x, 4) - Math.Pow(x, 5));
            var res = Math.Round(z, 3);
            return res;
        }
    }
}
