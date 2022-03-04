using System;
using System.Collections.Generic;
using System.Threading;

namespace Cars
{
    class Startup
    {
        const int playground = 12;

        static void Main(string[] args)
        {
            Console.BufferWidth = Console.WindowWidth = 50;
            Console.BufferHeight = Console.WindowHeight = 30;

            Run();
        }

        static void Run()
        {
            Car userCar = GetUserCar();
            List<Car> enemyCars = new List<Car>();
            enemyCars.Add(GetEnemyCar());

            bool hitted = false;
            string gameTitle = "Cars Console Game";
            int lifes = 5;

            Random randomGenerator = new Random();
            
            while (true)
            {
                PrintGameInformation(gameTitle, lifes);

                int chanceOfCreationOfNewEnemyCar = randomGenerator.Next(1, 100);

                if (chanceOfCreationOfNewEnemyCar < 70)
                {
                    enemyCars.Add(GetEnemyCar());
                }

                foreach (var enemyCar in enemyCars)
                {
                    PrintPosition(MoveEnemyCar(enemyCar), hitted);

                    if (userCar.X == enemyCar.X && userCar.Y == enemyCar.Y)
                    {
                        hitted = true;
                        lifes--;
                    }
                }

                while (Console.KeyAvailable)
                {
                    MoveUserCar(userCar);
                }

                PrintPosition(userCar, hitted);

                if (hitted)
                {
                    enemyCars = new List<Car>();
                }

                hitted = false;

                Thread.Sleep(200);

                Console.Clear();

                if (lifes < 0)
                {
                    Console.Clear();
                    Console.WriteLine("Good game!");

                    break;
                }
            }
        }

        static void PrintGameInformation(string title, int lifes)
        {
            Console.SetCursorPosition(25, 3);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);

            Console.SetCursorPosition(25, 4);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Life count: {lifes}");

            Console.SetCursorPosition(25, Console.WindowHeight - 1);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("by Nikola Siderov");
        }

        static void PrintPosition(Car obj, bool hitted)
        {
            Console.SetCursorPosition(obj.X, obj.Y);

            if (obj.Symbol == 'N')
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            if (hitted)
            {
                Console.Write('X');
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Clear();
            }
            else
            {
                Console.Write(obj.Symbol);
            }
        }

        static Car GetUserCar()
        {
            Car userCar = new Car();
            userCar.X = 6;
            userCar.Y = Console.WindowHeight - 1;
            userCar.Symbol = 'N';

            return userCar;
        }

        static Car GetEnemyCar()
        {
            Random random = new Random();
            int randomIndex = random.Next(0, playground + 2);

            Car enemyCar = new Car();
            enemyCar.Y = 0;
            enemyCar.X = randomIndex;
            enemyCar.Symbol = '#';

            return enemyCar;
        }

        static Car MoveUserCar(Car userCar)
        {
            ConsoleKeyInfo key = Console.ReadKey(true);

            if (key.Key == ConsoleKey.LeftArrow)
            {
                if (userCar.X > 0)
                {
                    userCar.X--;
                }
            }
            else if (key.Key == ConsoleKey.RightArrow)
            {
                if (userCar.X < playground)
                {
                    userCar.X++;
                }
            }

            return userCar;
        }

        static Car MoveEnemyCar(Car enemyCar)
        {
            if (enemyCar.Y < Console.WindowHeight - 1)
            {
                enemyCar.Y++;
            }
            else
            {
                enemyCar.Y = 0;
            }

            return enemyCar;
        }
    }
}
