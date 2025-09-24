using Tyuiu.HaevGS.Sprint1.Task7.V22.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();
        double x, y;
        x = Convert.ToDouble(Console.ReadLine());
        y = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine(ds.Calculate(x, y));
        Console.ReadKey();
    }
}