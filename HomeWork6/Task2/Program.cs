using System;
using System.Text;

namespace Task2
{
    public delegate double Func(double x);

    class Program
    {

        static void Main(string[] args)
        {
            Func[] arrFunc = new Func[]
            {
                Functions.F_Sin,
                Functions.F_x2,
                Functions.F_x3,
                Functions.F_Sqrt
            };
            int ans;

            Console.WriteLine($"Какую функцию использовать (выберите нужный вариант)?"
                + $"\n1 - F_Sin (sin x)"
                + $"\n2 - F_x2 (x^2)"
                + $"\n3 - F_x3 (x^3)"
                + $"\n4 - F_Sqrt(√2) ");

            do
            {
                Console.WriteLine("Выберите необходимый номер: ");
                ans = (int)CheckNumber();
                if (ans >= arrFunc.Length || ans <= 0)
                {
                    Console.WriteLine($"Функция с кодом \"{ans}\" отсутствует в программе");
                    ans = 0;
                }
            } while (ans == 0);
            Console.WriteLine("Введите минимальное значение аргумента (x): ");
            double ansX = CheckNumber();
            double ansSegment;
            do
            {
                Console.WriteLine("Введите отрезок исследования функции (x2): ");
                ansSegment = CheckNumber();
                if (ansSegment <= ansX)
                {
                    Console.WriteLine($"Правый край интервал \"{ansSegment}\" не может быть меньше значения аргумента {ansX}");
                    ansSegment = 0;
                }
            } while (ansSegment == 0);

            Functions.SaveFunc(arrFunc[ans - 1], "data.bin", ansX, ansSegment, 0.5);
            Console.WriteLine($"Минимальное значение: {Functions.Load("data.bin", out double[] arr):F2}");
            ArrPrint(arr, 8);
            Console.ReadLine();
        }
        static double CheckNumber()
        {
            while (true)
                if (!double.TryParse(Console.ReadLine(), out double x))
                    Console.Write("Ошибка ввода.\nПожалуйста, повторите ввод: ");
                else return x;
        }
        static public void ArrPrint(double[] arr, int rowLen, int width = 5)
        {
            int len = 0;
            StringBuilder msg = new();

            Console.Write($"Элементы массива ({arr.Length} шт.)");
            foreach (var item in arr)
            {
                if (string.Format("{0:F2}", item).Length > len)
                    len = string.Format("{0:F2}", item).Length;
            }

            if (len < width) len = width;

            for (int i = 0; i < arr.Length; i++)
            {
                msg.Clear().ToString();
                string elLen = msg.Append(' ', len - string.Format("{0:F2}", arr[i]).Length).ToString();
                if (i % rowLen == 0) Console.Write("\n|");
                Console.Write($"{elLen}{arr[i]:F2}|");
            }
            Console.WriteLine();
        }
    }
}
