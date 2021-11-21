using LibToWorkWith2DimArray;
using System;
namespace HomeWork_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            bool check = true;



            while (check)
            {
                Console.WriteLine("\nДоступны 5 видов задач:"
                + "\n1 - Дан целочисленный массив из 20 элементов заполненный случайными числами от –10 000 до 10 000 включительно.\nПрограмма позволяет найти и вывести количество пар элементов массива, в которых только одно число делится на 3"
                + "\n2 - Реализация задачи #1 в виде статического класса, а также считывание массива из файла"
                + "\n3 - Работа с одномерным массивом"
                + "\n4 - Проверка логина и пароля, логин и пароль считываются из файла"
                + "\n5 - Работа с двумерным массивом"
                + "\nДля выхода из программы введите 0");
                ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        Task1();
                        break;
                    case 2:
                        Task2();
                        break;
                    case 3:
                        Task3();
                        break;
                    case 4:
                        Task4();
                        break;
                    case 5:
                        Task5();
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine($"Задача с номер {ans} не найдена, повторите ввод");
                        break;
                }
            }
        }
        static void Task1()
        {
            const int arrayLength = 20;
            int[] myArray = GetArrayWithRandomNum(arrayLength);
            Console.WriteLine("Массив из случайных чисел в диапозоне от -10000 до 100000 включительно:");
            Array.ForEach(myArray, Console.WriteLine);
            int result = GetNumberOfPairs(myArray);
            Console.WriteLine($"Количество пар: {result}");
            Console.ReadKey();
        }

        static void Task2()
        {
            int[] arrInts = StaticClass.GetArrayWithRandomNum(20);
            Console.WriteLine("Массив из случайных чисел:");
            Array.ForEach(arrInts, Console.WriteLine);
            int count = StaticClass.GetCountGoodNumbers(arrInts);
            Console.WriteLine($"Кол-во пар элементов массива, в которых только одно число делится на три = {count}");
            Console.WriteLine("============================================");
            try
            {
                int[] arrLoaded = StaticClass.LoadArrayFromFile(@"..\..\data.txt");
                Console.WriteLine("Массив загруженных элементов из файла:");
                Array.ForEach(arrLoaded, Console.WriteLine);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message + "\nДальнейшее выполнение невозможно");
                Console.ReadKey();
            }


        }

        static void Task3()
        {
            Console.WriteLine("Введите размер массива");
            int size = CheckNumber();
            Console.WriteLine("Введите шаг заполнения массива");
            int step = CheckNumber();
            MyArray myArray = new(size, step);
            Console.WriteLine("Сгенерированный массив:");
            for (int i = 0; i < myArray.Length; i++)
            {
                Console.Write($"{myArray[i]} ");
            }
            int sum = myArray.Sum;
            Console.WriteLine($"\nСумма элементов массива {sum}");
            int[] arrayInverse = myArray.Inverse();
            Console.WriteLine("Массив с измененными знаками у всех элементов");
            for (int i = 0; i < arrayInverse.Length; i++)
            {
                Console.Write($"{arrayInverse[i]} ");
            }

            Console.WriteLine("\nВведите число, на которое необходимо перемножить все элементы массива");
            int multi = CheckNumber();
            int[] multiArray = myArray.Multi(multi);
            Console.WriteLine($"Массив умноженый на {multi}: ");
            for (int i = 0; i < multiArray.Length; i++)
            {
                Console.Write($"{multiArray[i]} ");
            }
            int maxCount = myArray.MaxCount;
            Console.WriteLine($"\nКоличество максимальных элементов {maxCount}");
            #region пунктБ, работа через библиотеку
            Console.WriteLine("Демонстрация работы библиотеки");
            MyArrayLib.MyArray myArrayWithLib = new(20);
            Console.WriteLine("Массив сгенерированный с помощью библиотеки:");
            for (int i = 0; i < myArrayWithLib.Length; i++)
            {
                Console.Write($"{myArrayWithLib[i]} ");
            }
            Console.WriteLine($"Сумма всех элементов массива {myArrayWithLib.Sum}");
            Console.WriteLine($"Максимальное значение элемента {myArrayWithLib.Max}");
            Console.WriteLine($"Количество максимальных элементов {myArrayWithLib.MaxCount}");
            #endregion
        }

        static void Task4()
        {
            Accounts accounts = new(@"..\..\AccountsData.txt");
            var (authYes, login) = AuthLoginFromConsole(accounts);
            if (authYes)
            {
                Console.WriteLine($"Авторизация пройдена успешно\nЗдравствуйте, {login}!");
            }
            else
            {
                Console.WriteLine("Авторизация не удалась");
            }

        }

        static void Task5()
        {
            Console.WriteLine("Введите число колонок у массива");
            int colCount = CheckNumber();
            Console.WriteLine("Введите число строк у массива");
            int rowCount = CheckNumber();
            DoubleArray doubleArray = new(colCount, rowCount);
            Console.WriteLine("Массив заполненный случайными числами:");
            Console.WriteLine(doubleArray);
            Console.WriteLine($"Сумма всех элементов массива = {doubleArray.Sum()}");
            Console.WriteLine("Введите значение массива, всё что больше задонного значение будет просуммировано");
            int minValue = CheckNumber();
            Console.WriteLine($"Сумма всех элементов массива больше заданного = {doubleArray.Sum(minValue)}");
            int min = doubleArray.Min;
            Console.WriteLine($"Минимальный элемент массива равен {doubleArray.Min}");
            var (_, minNumCol, minNumRow) = doubleArray.GetIndexForValue(min);
            Console.WriteLine($"Он находится в колонке {minNumCol + 1} и строке {minNumRow + 1}");
            int max = doubleArray.Max;
            Console.WriteLine($"Максимальный элемент массива равен {max}");
            var (_, maxNumCol, maxNumRow) = doubleArray.GetIndexForValue(max);
            Console.WriteLine($"Он находится в колонке {maxNumCol + 1} и строке {maxNumRow + 1}");
            Console.ReadKey();
            try
            {
                DoubleArray loadDoubleArray = new(@"..\..\DoubleArrayFile.txt");
                Console.WriteLine("\nМассив из файла:");
                Console.WriteLine(loadDoubleArray);
                Console.WriteLine("Создаем новый массив");
                Console.WriteLine("Введите число колонок у записываемого массива");
                int newColCount = CheckNumber();
                Console.WriteLine("Введите число строк у записываемого массива");
                int newRowCount = CheckNumber();
                DoubleArray newDoubleArray = new(newColCount, newRowCount);
                Console.WriteLine("Запись нового массива в файл");
                newDoubleArray.SaveToFile(@"..\..\NewDoubleArrayFile.txt");
                Console.WriteLine("Чтение нового массива из сформированного файла");
                newDoubleArray.LoadFromFile(@"..\..\NewDoubleArrayFile.txt");
                Console.WriteLine("\nНовый массив прочитанный из файла:");
                Console.WriteLine(newDoubleArray);
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine("Исключение: " + e.Message);
            }
        }
        #region Вспомогательные методы, когда-нибудь вынесу в отдельный файл =)
        static int CheckNumber()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Ошибка ввода.\nПожалуйста, повторите ввод: ");
                else return x;
        }
        static int[] GetArrayWithRandomNum(int size)
        {
            Random rnd = new();
            int[] retArr = new int[size];
            for (int i = 0; i < retArr.Length; i++)
            {
                retArr[i] = rnd.Next(-10000, 10001);
            }
            return retArr;
        }
        static int GetNumberOfPairs(int[] array)
        {
            int count = 0;
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
        private static (bool, string) AuthLoginFromConsole(Accounts accounts)
        {
            int countTry = 3;
            string login = default;
            while (countTry >= 0)
            {
                Console.Write("Введите свой логин:> ");
                login = Console.ReadLine();
                if (accounts.IsValidLogin(login))
                {
                    break;
                }
                Console.WriteLine($"Такой логин отсутствует в списке. У вас осталось {countTry} попыток.");
                countTry--;
            }
            while (countTry >= 0)
            {
                Console.Write("Введите пароль:> ");
                string password = Console.ReadLine();
                if (accounts.IsValidLoginPassword(login, password))
                {
                    return (true, login);
                }
                Console.WriteLine($"Неправильный пароль! У вас осталось {countTry} попыток.");
                countTry--;
            }
            return (false, default);
        }
        #endregion
    }
}

