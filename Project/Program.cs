using System;

namespace ToDoList

{
    class Program
    {

        public static void Main(string[] args)
        {
            string workkdayjob = $"\n 6:00 Подъем \n 6:30 Завтрак \n 7:00 - 10:30 Работа \n 10:30 - 11:30 Обед \n 11:30 - 16:00 Работа ";
            string workkdayafterjobPSP = "\n 16:00 - 17:00 Ужин \n 17:00 - 19:00 Изучение С# \n 19:00 - 20:00 Поход в зал \n 22:30 Отбой \n ";
            string workkdayafterjobVJ = "\n 16:00 - 17:00 Ужин \n 17:00 - 21:00 Встреча с друзьями \n 21:00 - 22:00 Свободное время \n 22:30 Отбой \n ";
            string weekend = "\n 10:00 Подъем \n 11:00 Завтрак \n 11:00 - 16:00 Свободное время \n 16:00 - 17:00 Бассейн \n 17:00 - 20:00 Катание на велосипеде \n 20:00 - 22:00 Просмотр фильма \n 23:00 Отбой \n ";

            Console.WriteLine("Введите день недели");
            string day = Console.ReadLine();
            switch (day)
            {
                case "Понедельник":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(workkdayjob + workkdayafterjobPSP);

                    break;

                case "Вторник":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(workkdayjob + workkdayafterjobVJ);
                    break;

                case "Среда":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(workkdayjob + workkdayafterjobPSP);
                    break;

                case "Четверг":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(workkdayjob + workkdayafterjobVJ);
                    break;

                case "Пятница":
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(workkdayjob + workkdayafterjobPSP);
                    break;

                case "Суббота":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(weekend);
                    break;

                case "Воскресенье":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(weekend);
                    break;

                case "Все":
                    Console.WriteLine();
                    break;

                default:
                    Console.WriteLine("Нет такого дня недели!");
                    break;
            }
            Console.ForegroundColor = ConsoleColor.White; 
            Console.WriteLine("Нажмите Enter");
            Console.ReadKey();
        }

    }
}

