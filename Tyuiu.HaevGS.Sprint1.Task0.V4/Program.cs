using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.HaevGS.Sprint1.Task0.V4.Lib;

namespace Tyuiu.HaevGS.Sprint1.Task0.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();

            Console.WriteLine(ds.Calculate());
            Console.ReadLine();

        }
    }
}
