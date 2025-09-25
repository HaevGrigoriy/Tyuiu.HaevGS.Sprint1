using tyuiu.cources.programming.interfaces.Sprint1;

namespace Tyuiu.HaevGS.Sprint1.Task6.V13.Lib
{
    public class DataService : ISprint1Task6V13
    {
        public bool CheckWordsAlphabet(string value)
        {
            char[] sortedArray = value.ToCharArray();
            Array.Sort(sortedArray);
            if (sortedArray.SequenceEqual(value))
            {
                return true;
            }
            return false;
        }
    }
}