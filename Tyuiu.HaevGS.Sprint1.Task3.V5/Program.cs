using Tyuiu.HaevGS.Sprint1.Task3.V5.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        double mapScale = 120;
        double distanceBetweenPoints = 3.5;

        Console.WriteLine(mapScale);
        Console.WriteLine(distanceBetweenPoints);

        Console.Write(ds.DistanceLength(mapScale, distanceBetweenPoints));

        Console.ReadKey(); 

    }
}