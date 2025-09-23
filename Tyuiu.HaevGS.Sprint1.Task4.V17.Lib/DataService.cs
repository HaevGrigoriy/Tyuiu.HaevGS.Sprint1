using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HaevGS.Sprint1.Task4.V17.Lib
{
    public class DataService : ISprint1Task4V17
    {
        public double Calculate(double x, double y)
        {
            var res = 1/(Math.Sqrt(x * 1 - y * 5));
            return Math.Round(res, 3);
        }
    }
}
