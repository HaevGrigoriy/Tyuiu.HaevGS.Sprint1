using Tyuiu.HaevGS.Sprint1.Task2.V27.Lib;
internal class Program
{
    private static void Main(string[] args)
    {   
        DataService ds = new DataService();
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(ds.CalculateSquarePerimetr(x));
        Console.ReadLine();



    }
}