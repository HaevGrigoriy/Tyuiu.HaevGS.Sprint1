using Tyuiu.HaevGS.Sprint1.Task6V13.Lib;
internal class Program
{
    private static void Main(string[] args)
    {
        DataService ds = new DataService();

        string str = Console.ReadLine();
        Console.WriteLine("{0} по алфавиту? {1}", str, ds.CheckWordsAlphabet(str));
        Console.ReadKey();
    }
}