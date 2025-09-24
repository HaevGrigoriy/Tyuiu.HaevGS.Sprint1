using Tyuiu.HaevGS.Sprint1.Task6.V13.Lib;

using System;

namespace Tyuiu.HaevGS.Sprint1.Task6.V13.Test

{
    class DataServiveTest
    {

        static bool HasAlphabeticalOrder(string text)

        {

            text = text.Trim(new char[] { ' ', '.', ',' });
            for (int i = 1; i < text.Length; i++)
            {

                if (text[i - 1] != text[i] - 1)
                {
                    return false;
                }
            }
            return true;
        }

        static void Main()
        {
            string текст_по_алфавиту = "ЖЗИЙКЛМНОПРСТУФХ.";
            string текст_не_по_алфавиту = "ЖЗИВЙКЛМНОПМРСТУФХ.";
            Console.WriteLine("{0} по алфавиту? {1}", текст_по_алфавиту, HasAlphabeticalOrder(текст_по_алфавиту));
            Console.WriteLine("{0} по алфавиту? {1}", текст_не_по_алфавиту, HasAlphabeticalOrder(текст_не_по_алфавиту));
        }
    }
}