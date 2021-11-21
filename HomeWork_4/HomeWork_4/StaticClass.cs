using System;
using System.IO;

namespace HomeWork_4
{
    static class StaticClass
    {
        public static int[] GetArrayWithRandomNum(int size)
        {
            Random rnd = new();
            int[] Array = new int[size];
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rnd.Next(-10000, 10001);
            }
            return Array;
        }

        public static int GetCountGoodNumbers(int[] array)
        {
            int count = default;
            for (int i = 0; i < array.Length - 1; i++)
            {
                if (array[i] % 3 == 0 ^ array[i + 1] % 3 == 0)
                {
                    count++;
                    Console.WriteLine("Пара чисел: {0} и {1}", array[i], array[i + 1]);
                }
            }
            return count;
        }

        public static void SaveArrayToFile(int[] arrInts, string fileName)
        {
            StreamWriter writer = new(fileName);
            foreach (int item in arrInts)
            {
                writer.WriteLine(item);
            }
            writer.Close();
        }
        public static int[] LoadArrayFromFile(string fileName)
        {
            const int size = 20;
            StreamReader reader = new(fileName);
            int[] returnMe = new int[size];
            for (int i = 0; i < size; i++)
            {
                returnMe[i] = int.Parse(reader.ReadLine());
            }
            reader.Close();
            return returnMe;
        }

    }
}
