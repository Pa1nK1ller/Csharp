using System;
using System.IO;

namespace Task2
{
    struct Functions
    {
        public static double F_Sin(double x)
        {
            return Math.Sin(x);
        }
        public static double F_x2(double x)
        {
            return Math.Pow(x, 2);
        }
        public static double F_x3(double x)
        {
            return Math.Pow(x, 3);
        }
        public static double F_Sqrt(double x)
        {
            return Math.Sqrt(x);
        }

        public static double Load(string fileName, out double[] arr)
        {
            FileStream fs = new(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new(fs);
            double min = double.MaxValue;
            double d;
            arr = Array.Empty<double>();
            Console.WriteLine($"\nДанные из файла: {fileName}");
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                Array.Resize(ref arr, i + 1);
                d = bw.ReadDouble();
                if (d < min) min = d;
                arr[i] = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        public static void SaveFunc(Func F, string fileName, double x, double b, double h)
        {
            FileStream fs = new(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new(fs);
            int counter = 0;
            while (x <= b)
            {
                counter++;
                bw.Write(F(x));
                x += h;
            }
            bw.Close();
            fs.Close();
            Console.WriteLine($"\nВ файл записано: {counter} знач., расчетная функция {F.Method.Name}");
        }
    }
}
