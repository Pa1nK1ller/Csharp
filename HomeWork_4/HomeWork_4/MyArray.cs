using System;
using System.IO;
using System.Linq;

namespace HomeWork_4
{
    class MyArray
    {
        private int[] arr;
        Random rnd = new();
        public MyArray(int size)
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1, 101);
            }
        }
        public MyArray(int size, int step)
        {
            arr = new int[size];
            for (int i = 0; i < size; i++)
            {
                arr[i] = i * step;
            }
        }
        public MyArray(string fileName)
        {
            if (File.Exists(fileName))
            {
                string[] ss = File.ReadAllLines(fileName);
                arr = new int[ss.Length];
                for (int i = 0; i < ss.Length; i++)
                {
                    arr[i] = int.Parse(ss[i]);
                }
            }
            else
                Console.WriteLine("Ошибка загрузки файла");
        }
        public int Max
        {
            get => arr.Max();
        }
        public int Sum
        {
            get => arr.Sum();
        }
        public int[] Inverse()
        {
            int[] returnMe = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                returnMe[i] = -arr[i];
            }
            return returnMe;
        }
        public int[] Multi(int value)
        {
            int[] returnMe = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                returnMe[i] = arr[i] * value;
            }
            return returnMe;
        }
        public int MaxCount
        {
            get
            {
                int max = Max;
                int count = 0;
                foreach (var item in arr)
                {
                    if (item == max)
                    {
                        count++;
                    }
                }
                return count;
            }
        }
        public int this[int i]
        {
            get => arr[i];
            set => arr[i] = value;
        }

        public int Length
        {
            get => arr.Length;
        }
        public void Print()
        {
            Array.ForEach(arr, i => Console.Write($"{i,4} "));
        }
    }
}
