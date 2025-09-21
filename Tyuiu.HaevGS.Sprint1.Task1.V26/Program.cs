using Tyuiu.HaevGS.Sprint1.Task1.V26.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double x, y;

        Console.WriteLine();
        x = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();
        y = Convert.ToDouble(Console.ReadLine());


        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}