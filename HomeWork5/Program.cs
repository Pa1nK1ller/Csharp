using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace HomeWork5
{
    struct Element
    {
        public string FI;
        public double avgGrade;
    }
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            bool check = true;



            while (check)
            {
                Console.WriteLine("\nДоступны 5 видов задач:"
                + "\n1 - Программа, которая будет проверять корректность ввода логина"
                + "\n2 - Работа с классом Message"
                + "\n3 - Проверка анаграмм"
                + "\n4 - Задача ЕГЭ"
                + "\nДля выхода из программы введите 0");
                ans = CheckNumber();
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
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine($"Задача с номер {ans} не найдена, повторите ввод");
                        break;
                }
            }
        }


        #region Task1
        private static void Task1()
        {
            int ans;
            bool ansContinue = false;
            bool flag;
            Console.Write("Введите логин: ");
            string login = Console.ReadLine();

            do
            {
                Console.WriteLine($"\nКак будем проверять (выберите нужный вариант)?"
                    + "\n1. без использования регулярных выражений"
                    + "\n2. с использованием регулярных выражений");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine();
                flag = false;
                switch (ans)
                {
                    case 1:
                        flag = CheckWithoutRegex(login);
                        break;
                    case 2:
                        flag = CheckRegex(login);
                        break;
                    default:
                        break;
                }
            } while (ansContinue);

            if (flag) Console.WriteLine("Введенный логин прошел проверку");
            else Console.WriteLine("Введенный логин не прошел проверку");
            Console.ReadLine();
        }
        private static bool CheckWithoutRegex(string login)
        {
            bool _flag = login.Length >= 2 && login.Length <= 10;
            _flag = _flag && !char.IsDigit(login[0]);

            foreach (char ch in login)
            {
                _flag = _flag && ((ch >= 'a' && ch <= 'z')
                                    || (ch >= 'A' && ch <= 'Z')
                                    || (ch >= '0' && ch <= '9'));
            }

            return _flag;
        }
        private static bool CheckRegex(string login)
        {
            Regex regex = new(@"^[^0-9]{1}[a-zA-Z0-9]{1,9}$");
            return regex.IsMatch(login);

        }
        #endregion
        private static void Task2()
        {
            string str = @"В те времена, когда роились грезы
                В сердцах людей, прозрачны и ясны,
                Как хороши, как свежи были розы
                Моей любви, и славы, и весны!
                Прошли лета, и всюду льются слезы…
                Нет ни страны, ни тех, кто жил в стране
                Как хороши, как свежи ныне розы
                Воспоминаний о минувшем дне!
                Но дни идут - уже стихают грозы.
                Вернуться в дом Россия ищет троп…
                Как хороши, как свежи будут розы,
                Моей страной мне брошенные в гроб!
                для проверки частоты появления слов : гроб, розы, минувшем, хороши, времена";

            Massage.WordLettersMoreThan(str, 6);
            Console.WriteLine();
            Massage.DeleteWordsEndingChar(str, 'а');
            Console.WriteLine();
            Massage.LongestWord(str);
            Console.WriteLine();
            Massage.StrBuilderLgstWord(str);
            Console.WriteLine();
            DictPrint(Massage.FrequencyDictionary(str));
            Console.ReadLine();
        }
        private static void Task3()
        {
            Console.WriteLine("Для того, чтобы проверить, являются ли слова анаграммами введите первое слово");
            string first = Console.ReadLine();
            Console.WriteLine("Введите второе слово");
            string second = Console.ReadLine();
            if (first.Select(char.ToUpper).OrderBy(x => x).SequenceEqual(second.Select(char.ToUpper).OrderBy(x => x)))
                Console.WriteLine("Строки являются анаграммами");
            else
                Console.WriteLine("Строки не являются анаграммами");
        }
        private static void Task4()
        {
            int amountOfWorstPupils = 3;
            StreamReader sr = new("..\\..\\data.txt");
            int N = int.Parse(sr.ReadLine());
            Element[] a = new Element[N];
            for (int i = 0; i < N; i++)
            {
                string[] s = sr.ReadLine().Split(' ');
                a[i].FI = s[0] + " " + s[1];
                a[i].avgGrade = (double.Parse(s[2]) + double.Parse(s[3]) + double.Parse(s[4])) / 3;
            }
            sr.Close();
            SortPupils(ref a);
            string result = string.Format("{0,-20} {1,-10}\n\n", "Ученик", "Средний балл");
            Element prev = a[0];
            for (int i = 0; i < amountOfWorstPupils; i++)
            {
                if (i > 0)
                {
                    if (prev.avgGrade == a[i].avgGrade)
                        amountOfWorstPupils++;
                    prev = a[i];
                }

                result += string.Format("{0,-20} {1,-10:F2}\n",
                                       a[i].FI, a[i].avgGrade);
            }

            Console.WriteLine($"\n{result}");

            Console.ReadKey();
        }
        static void SortPupils(ref Element[] pupils)
        {
            for (int i = 0; i < pupils.Length; i++)
            {
                for (int j = 0; j < pupils.Length - i - 1; j++)
                {
                    if (pupils[j].avgGrade > pupils[j + 1].avgGrade)
                    {
                        Element tmp = pupils[j + 1];
                        pupils[j + 1] = pupils[j];
                        pupils[j] = tmp;
                    }
                }
            }
        }
        static public void DictPrint(Dictionary<string, int> dict)
        {
            string line = "-----";
            string headerKey = "Key";
            string headerValue = "Value";
            Console.WriteLine($"Элементы словаря ({dict.Count} шт.)");
            Console.WriteLine($"|{headerKey,20}|{headerValue,5}|");
            Console.WriteLine($"|{line,20}|{line,5}|");
            foreach (string el in dict.Keys)
            {
                dict.TryGetValue(el, out int v);
                Console.WriteLine($"|{el,20}|{v,5}|");
            }
            Console.WriteLine();
        }
        static int CheckNumber()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.Write("Ошибка ввода.\nПожалуйста, повторите ввод: ");
                else return x;
        }
    }

}
