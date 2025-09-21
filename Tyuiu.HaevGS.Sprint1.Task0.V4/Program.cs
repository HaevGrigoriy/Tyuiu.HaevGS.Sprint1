using Tyuiu.HaevGS.Sprint1.Task0.V4.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        Console.WriteLine(ds.Calculate());
        Console.ReadLine();
    }
}