using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Anketa(); //
            Imt();
            //DistCoordinates();
            //Swap();
            ///Info();
        }
        static void Anketa()
        {
            string name, surname, age, height, weight;
            Output("Введите Вашу имя");
            name = Input();
            Output("Введите Вашу фамилию");
            surname = Input();
            Output("Сколько Вам лет");
            age = Input();
            Output("Какой у Вас рост?");
            height = Input();
            Output("Какой у Вас вес?");
            weight = Input();
            Output("Имя: " + name + " Фамилия: " + surname + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Имя {0}, Фамилия {1}, Возраст {2}, Рост {3}, Вес {4}", name, surname, age, height, weight);
            Output($"Имя: {name}, Фамилия: {surname}, Возраст: {age}, Рост: {height}, Вес: {weight}.");
            Console.ReadLine();
        }
        static void Imt()
        {
            double heightImt, WeightImt, Imt;
            Output("Какой у Вас рост?");
            heightImt = double.Parse(Console.ReadLine());
            Output("Какой у Вас вес?");
            WeightImt = double.Parse(Console.ReadLine());
            Imt = WeightImt / Math.Pow(heightImt, 2);
            Output($"ИМТ = {Imt}");
        }
        static void DistCoordinates()
        {
            double x1, x2, y1, y2;
            Output("Введите значение x1");
            x1 = double.Parse(Input());
            Output("Введите значение x2");
            x2 = double.Parse(Input());
            Output("Введите значение y1");
            y1 = double.Parse(Input());
            Output("Введите значение y2");
            y2 = double.Parse(Input());
            Output($"r = {CalcDistCoord(x1, x2, y1, y2):F2}");
        }
        static double CalcDistCoord(double x1, double x2, double y1, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
        static void Swap()
        {
            int x, y;
            Output("Введите значаение X");
            x = int.Parse(Input());
            Output("Введите значаение Y");
            y = int.Parse(Input());
            x = x + y;
            y = x - y;
            x = x - y;
            Output($"Теперь значение X = {x}, а значение Y = {y}");
        }
        static void Info()
        {
            string name = "Konstantin", surename = "Zikranets", city = "Chelyabinsk";

            Console.SetCursorPosition(Console.WindowHeight / 2, Console.WindowWidth / 2);
            Output($"{name} {surename} {city} ");

            printInfoInCentr($"{name} {surename} {city}",Console.WindowHeight/2,Console.WindowWidth/2+2);

        }

        static void printInfoInCentr(string info, int posX, int posY) {
            Console.SetCursorPosition(posX,posY);
            Output(info);
        }
        static void Output(string text)
        {
            Console.WriteLine(text);
        }
        static string Input()
        {
            string textInput = Console.ReadLine();
            return textInput;
        }

    }
    
}

