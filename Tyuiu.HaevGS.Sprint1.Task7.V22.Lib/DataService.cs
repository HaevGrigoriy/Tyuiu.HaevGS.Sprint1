using System.Reflection.Metadata.Ecma335;
using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HaevGS.Sprint1.Task7.V22.Lib
{
    public class DataService : ISprint1Task7V22
    {
        public double Calculate(double x, double y)
        {
            double res = Math.Pow(1 - Math.Tan(-1), Math.Atan(-0.629)) + Math.Cos(x - y);
            return Math.Round(res,3);
        }
    }
}
