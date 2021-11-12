using System;

namespace HomeWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            int taskNumber = -1;
            while (taskNumber != 0)
            {
                Console.WriteLine("Выберите номер задачи\n"
                    + "Задача 1 - Нахождение минимального из трёх чисел\n"
                    + "Задача 2 - Подсчёт количества цифр числа\n"
                    + "Задача 3 - Подсчёт суммы всех введенных нечетных положительных чисел\n"
                    + "Задача 4 - Проверка логина и пароля\n"
                    + "Задача 5 - Расчёт ИМТ и получение рекомендация\n" 
                    +"Задача 6 - Подсчёт количества “Хороших” чисел в диапазоне от 1 до 1 000 000 000\n" 
                    +"Задача 7 - Рекурсивный метод, который выводит на экран числа от a до b (a < b)\n" 
                    +"Задача 8 - Рекурсивный метод, который считает сумму чисел от a до b.\n" 
                    +"Для выхода из программы введите 0\n" +
                    "==================================\n");
                taskNumber = int.Parse(Console.ReadLine());
                switch (taskNumber)
                {
                    case 1:
                        Console.WriteLine("Выбрана задач №1");
                        Task1();
                        break;
                    case 2:
                        Console.WriteLine("Выбрана задач №2");
                        Task2();
                        break;
                    case 3:
                        Console.WriteLine("Выбрана задач №3");
                        Task3();
                        break;
                    case 4:
                        Console.WriteLine("Выбрана задач №4");
                        Task4();
                        break;
                    case 5:
                        Console.WriteLine("Выбрана задач №5");
                        Task5();
                        break;
                    case 6:
                        Console.WriteLine("Выбрана задач №6");
                        Task6();
                        break;
                    case 7:
                        Console.WriteLine("Выбрана задач №7");
                        Task7(5,13);
                        break;
                    case 8:
                        Console.WriteLine("Выбрана задач №8");
                        Console.WriteLine(Task8(5,13));
                        break;
                    default:
                        Console.WriteLine("Не корректно введен номер задачи");
                        break;


                }
            }
        }
        #region Task1
        static void Task1()
        {
            int a, b, c;
            Console.WriteLine("\nВведите 3 числа");
            Console.WriteLine("Введите первое число");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите второе число");
            b = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите третье число");
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Минимальное из трех чисел: " + Min3(a, b, c) + "\n");
        }
        static int Min3(int a, int b, int c)
        {
            if (a <= b && a <= c)
                return a;
            else if (b <= c)
                return b;
            else
                return c;
        }
        #endregion
        #region Task2
        static void Task2()
        {
            int number;
            Console.WriteLine("Введите число, для завершения ввода нажмите Enter");
            number = int.Parse(Console.ReadLine());
            Console.WriteLine("Количество цифр в веденном вами числе: " + SumNum(number) + "\n");

        }
        static int SumNum(int number)
        {
            int count = 0;
            while (number != 0)
            {
                number /= 10;
                count++;
            }
            return count;
        }

        #endregion
        #region Task3
        static void Task3()
        {
            int Sum = 0;
            Console.WriteLine("Введите первое число, для завершения ввода чисел введите 0");
            while (true)
            {
                int a = Convert.ToInt32(Console.ReadLine());
                if (a == 0)
                {
                    break;
                }
                else if (a > 0 && a % 2 != 0)
                {
                    Sum += a;
                }
                Console.WriteLine("Введите следующее число, для завершения ввода чисел введите 0");
            }
            Console.WriteLine($"Сумма всех нечетных положительных чисел равна: {Sum}\n");
        }
        #endregion
        #region Task4
        static void Task4()
        {
            string defLogin = "root", defPasswor = "GeekBrains";
            string login, password;
            int count = 2;
            do
            {
                Console.WriteLine("Введите логин");
                login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                password = Console.ReadLine();
                if (Verifycation(login, password, defLogin, defPasswor))
                {
                    Console.WriteLine("Авторизация пройдена");
                }
                else
                {
                    Console.WriteLine("Авторизация не пройдена");
                }
                count--;
            }
            while (count >= 0);
        }

        static bool Verifycation(string login, string password, string defLogin, string defPassword)
        {

            if (login == defLogin && password == defPassword)
                return true;
            else return false;

        }
        #endregion
        #region Task5
        static void Task5()
        {
            double height, weight, imt;
            Console.WriteLine("Введите ваш рост в метрах");
            height = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ваш вес в килограммах");
            weight = double.Parse(Console.ReadLine());
            imt = weight / Math.Pow(height, 2);
            Console.WriteLine($"ИМТ = {imt:F2}");

            if (imt <= 16)
            {
                Console.WriteLine("У вас выраженный дефицит массы тела\n" +
                    "Для достижения идеального веса, вам необходимо набрать " + Math.Round(((19 - imt) * (Math.Pow(height, 2))), 2) + " кг.\n");
            }
            else if (imt > 16 && imt <= 18.5)
                Console.WriteLine("У вас недостаточная масса тела\n" +
                    "Для достижения идеального веса, вам необходимо набрать " + Math.Round(((19 - imt) * (Math.Pow(height, 2))), 2) + " кг.\n");
            else if (imt > 18.5 && imt <= 25)
                Console.WriteLine("Ваш вес в пределах нормы");
            else if (imt > 25 && imt <= 30)
                Console.WriteLine("У вас избыточная масса тела\n" +
                    "Для достижения идеального веса, вам необходимо сбросить " + Math.Round(((imt - 19) * (Math.Pow(height, 2))), 2) + " кг.\n");
            else if (imt > 30 && imt <= 35)
                Console.WriteLine("У вас ожирение 1 степени\n" +
                    "Для достижения идеального веса, вам необходимо сбросить " + Math.Round(((imt - 19) * (Math.Pow(height, 2))), 2) + " кг.\n");
            else if (imt > 35 && imt <= 40)
                Console.WriteLine("У вас ожирение 2 степени\n" +
                    "Для достижения идеального веса, вам необходимо сбросить " + Math.Round(((imt - 19) * (Math.Pow(height, 2))), 2) + " кг.\n");
            else
                Console.WriteLine("У вас ожирение 3 степени\n" +
                    "Для достижения идеального веса, вам необходимо сбросить " + Math.Round(((imt - 19) * (Math.Pow(height, 2))), 2) + " кг.\n");
        }

        #endregion
        #region Task6
        static void Task6()
        {

            int goodNumCount = 0, min = 1, max = 1000000000, temp, testnum;
            DateTime start = DateTime.Now;
            for (int i = min; i <= max; i++)
            {
                temp = 0;
                testnum = i;
                while (testnum != 0)
                {
                    temp += testnum % 10;
                    testnum /= 10;
                }
                if (i % temp == 0) goodNumCount++;
            }
            Console.WriteLine($"Количество хороших чисел: {goodNumCount}\n" +
                $"Время выполнения программы: {DateTime.Now - start}");
        }

        #endregion
        #region Task7
        static void Task7(int a, int b) {

            if (a > b)
            {
                Console.WriteLine("Ошибка, a>b.");
            }
            else {
                Console.WriteLine(a);
                if (b > a) {
                    Task7(a+1,b);
                }
            }
        }
        #endregion
        #region Task8
        static int Task8(int a, int b) {
            if (a > b)
            {
                Console.WriteLine("Ошибка, a > b.");
                return 0;
            }
            else if (b > a)
            {
                return (b + Task8(a, b - 1));
            }
            else
            {
                return a;
            }
        }
        #endregion
    }
}