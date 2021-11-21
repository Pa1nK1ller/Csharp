using System;
using System.IO;
using System.Text;

namespace LibToWorkWith2DimArray
{
    public class DoubleArray
    {
        private int[,] twoDimArr;
        public DoubleArray(int sizeCol, int sizeRow)
        {
            Random rnd = new();
            twoDimArr = new int[sizeCol, sizeRow];
            for (int i = 0; i < sizeCol; i++)
            {
                for (int j = 0; j < sizeRow; j++)
                {
                    twoDimArr[i, j] = rnd.Next(0, 1001);
                }
            }
        }

        public DoubleArray(string fileName)
        {
            LoadFromFile(fileName);
        }

        public int Sum()
        {
            int sum = 0;
            foreach (var item in twoDimArr)
            {
                sum += item;
            }
            return sum;
        }

        public int Sum(int valMin)
        {
            int sum = 0;
            foreach (var item in twoDimArr)
            {
                if (item > valMin)
                {
                    sum += item;
                }
            }
            return sum;
        }
        public int Min
        {
            get
            {
                int min = int.MaxValue;
                foreach (var item in twoDimArr)
                {
                    if (item < min)
                    {
                        min = item;
                    }
                }
                return min;
            }
        }
        public int Max
        {
            get
            {
                int max = int.MinValue;
                foreach (var item in twoDimArr)
                {
                    if (item > max)
                    {
                        max = item;
                    }
                }
                return max;
            }
        }
        public (bool, int, int) GetIndexForValue(int value)
        {
            for (int i = 0; i < twoDimArr.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(0); j++)
                {
                    if (twoDimArr[j, i] == value)
                    {
                        return (true, j, i);
                    }
                }
            }
            return (false, default, default);
        }
        public void SaveToFile(string fileName)
        {
            using StreamWriter writer = new(fileName);
            writer.WriteLine($"{twoDimArr.GetLength(0)},{twoDimArr.GetLength(1)}");
            for (int i = 0; i < twoDimArr.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(0); j++)
                {
                    writer.Write($"{twoDimArr[j, i]}");
                    if (j < twoDimArr.GetLength(0) - 1)
                    {
                        writer.Write($",");
                    }
                }
                writer.WriteLine();
            }
            writer.Close();
        }
        public void LoadFromFile(string fileName)
        {
            if (File.Exists(fileName))
            {
                using StreamReader reader = new(fileName);
                string sSize = reader.ReadLine();
                string[] arrSize = sSize.Split(',');
                int sizeCol = int.Parse(arrSize[0]);
                int sizeRow = int.Parse(arrSize[1]);
                twoDimArr = new int[sizeCol, sizeRow];
                int i = 0;
                while (!reader.EndOfStream)
                {
                    string ss = reader.ReadLine();
                    string[] arrStr = ss.Split(',');
                    for (int j = 0; j < arrStr.Length; j++)
                    {
                        twoDimArr[j, i] = int.Parse(arrStr[j]);
                    }
                    i++;
                }
                reader.Close();
            }
            else
            {
                throw new Exception($"Файл \"{fileName}\" не найден!");
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new();
            for (int i = 0; i < twoDimArr.GetLength(1); i++)
            {
                for (int j = 0; j < twoDimArr.GetLength(0); j++)
                {
                    sb.Append(twoDimArr[j, i] + " ");
                }
                sb.Append('\n');
            }
            return sb.ToString();
        }
    }
}
