using System;
using System.Collections.Generic;

namespace HomeWork3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int ans;
            bool check = true;
           
            
            
            while (check)
            {
                Console.WriteLine("\nДоступны 3 вида задач:"
                + "\n1 - Работа с комплексными числами"
                + "\n2 - Подсчёт суммы всех введенных нечетных положительных чисел"
                + "\n3 - Работа с дробями"
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

            int ans;
            bool check = true;
            try
            {
                Console.WriteLine("Введите реальную часть первого комплексного числа");
                double re1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть первого комплексного числа");
                double im1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите реальную часть второго комплексного числа");
                double re2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Введите мнимую часть второго комплексного числа");
                double im2 = double.Parse(Console.ReadLine());

                ComplexClass complex01 = new(re1, im1);
                ComplexClass complex02 = new(re2, im2);
                Console.WriteLine($"Вы ввели 2 комплексных числа -> {complex01}  {complex02}");
                while (check)
                {
                    Console.WriteLine("\nДля продолжения выберите одно из доступных операций с комплексными числами:"
                    + "\n1 - Сложение"
                    + "\n2 - Вычитание"
                    + "\n3 - Умножение"
                    + "\n4 - Деление"
                    + "\nДля выхода из задачи введите 0");
                    ans = int.Parse(Console.ReadLine());
                    switch (ans)
                    {
                        case 1:
                            Console.WriteLine($"Результат сложения комплексных чисел {complex01} и {complex02} >>> {complex01.Plus(complex02)}");
                            break;
                        case 2:
                            Console.WriteLine($"Результат вычитания комплексных чисел {complex01} и {complex02} >>> {complex01.Minus(complex02)}");
                            break;
                        case 3:
                            Console.WriteLine($"Результат умножения комплексных чисел {complex01} и {complex02} >>> {complex01.Multi(complex02)}");
                            break;
                        case 4:
                            Console.WriteLine($"Результат деления комплексных чисел {complex01} и {complex02} >>> {complex01.Divis(complex02)}");
                            break;
                        case 0:
                            check = false;
                            break;
                        default:
                            Console.WriteLine($"Операция с номер {ans} не найдена, повторите ввод");
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("При выполнении приложения возникло исключение.");
                Console.WriteLine(e.Message);
            }
        }
        static void Task2()
        {
            int digit, summ = 0;

            List<double> list = new();
            do
            {
                Console.WriteLine("Введите любое число, для завершения введите 0");
                digit = ChekDigit();

                if (digit == 0)
                    break;
                else if (digit > 0 && digit % 2 == 1)
                {
                    list.Add(digit);
                    summ += digit;
                }

            }
            while (digit != 0);
            if (summ > 0)
            {
                Console.WriteLine($"Сумма нечетных положительных чисел -> {summ}");
                Console.WriteLine("Подсчитаны нечетные числа из списка");
                foreach (double listItem in list) Console.WriteLine(listItem);
            }
            else
                Console.WriteLine("В веденном ряде чисел не найдены нечетные");
            Console.ReadKey();
        }

        static void Task3()
        {

            int ans;
            bool check = true;

            Console.Write("Введите числитель первой дроби: ");
            int n1 = ChekDigit();
            Console.Write("Введите знаминатель первой дроби: ");
            int d1 = ChekDigit();
            Console.Write("Введите числитель второй дроби: ");
            int n2 = ChekDigit();
            Console.Write("Введите знаминатель второй дроби: ");
            int d2 = ChekDigit();
            Fractions fraction1 = Init(n1, d1);
            Fractions fraction2 = Init(n2, d2);
            Fractions fraction3;

            while (check)
            {
                Console.WriteLine("\nДля продолжения выберите одно из доступных операций с комплексными числами:"
                + "\n1 - Сложение"
                + "\n2 - Вычитание"
                + "\n3 - Умножение"
                + "\n4 - Деление"
                + "\n5 - Упрощение"
                + "\n6 - Урощение до десятичной дроби"
                + "\nДля выхода из задачи введите 0");
                ans = int.Parse(Console.ReadLine());
                switch (ans)
                {
                    case 1:
                        fraction3 = (fraction1.Plus(fraction2));
                        fraction3.Simplification();
                        Console.WriteLine($"Результат сложения добрных чисел {fraction1} и {fraction2} >>> {fraction3} >>> {fraction3.DecimalFraction}");
                        break;
                    case 2:
                        fraction3 = (fraction1.Minus(fraction2));
                        fraction3.Simplification();
                        Console.WriteLine($"Результат вычитания добрных чисел {fraction1} и {fraction2} >>> {fraction3} >>> {fraction3.DecimalFraction}");
                        break;
                    case 3:
                        fraction3 = (fraction1.Multiply(fraction2));
                        fraction3.Simplification();
                        Console.WriteLine($"Результат умножения добрных чисел {fraction1} и {fraction2} >>> {fraction3} >>> {fraction3.DecimalFraction}");
                        break;
                    case 4:
                        fraction3 = (fraction1.Divide(fraction2));
                        fraction3.Simplification();
                        Console.WriteLine($"Результат деления добрных чисел {fraction1} и {fraction2} >>> {fraction3} >>> {fraction3.DecimalFraction}");
                        break;
                    case 5:
                        fraction1.Simplification();
                        fraction2.Simplification();
                        Console.WriteLine(value: $"Результат деления добрных чисел {fraction1} и {fraction2} ");
                        break;
                    case 6:
                        Console.WriteLine($"{fraction1.DecimalFraction} {fraction2.DecimalFraction}");
                        break;
                    case 0:
                        check = false;
                        break;
                    default:
                        Console.WriteLine($"Операция с номер {ans} не найдена, повторите ввод");
                        break;
                }
            }
        }
        static int ChekDigit()
        {
            while (true)
                if (!int.TryParse(Console.ReadLine(), out int x))
                    Console.WriteLine("Не верное значение, повторите ввод");
                else return x;
        }
        static Fractions Init(int numerator, int denumerator)
        {
            bool checkException;
            Fractions fraction = null;
            do
            {
                checkException = false;
                try
                {
                    fraction = new Fractions(numerator, denumerator);
                }
                catch (ArgumentException ex)
                {
                    checkException = true;
                    Console.WriteLine("Ошибка: " + ex.Message);
                    Console.Write("Повторно введите знаменатель дроби: ");
                    denumerator = ChekDigit();
                }
            } while (checkException);

            return fraction;
        }
    }
}
