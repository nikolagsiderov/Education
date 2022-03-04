using System;
using System.Threading;

namespace SnakeGame
{
    class Startup
    {
        static bool initialSnakeCreation = true;
        static bool eaten = false;

        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 100;

            Run();
        }

        static void Run()
        {
            while (true)
            {
                if (eaten)
                {
                    SpawnFruits();
                }

                MoveSnake();
                GrowSnake();

                Console.Clear();

                Thread.Sleep(100);

                CreateSnake();
            }
        }

        static void SpawnFruits()
        {
            Fruit fruit = new Fruit();
            fruit.Symbol = '@';

            Random randomGen = new Random();
            int chanceOfX = randomGen.Next(1, 100);
            int chanceOfY = randomGen.Next(1, 40);

            Console.SetCursorPosition(chanceOfX, chanceOfY);
            Console.Write(fruit.Symbol);
        }

        static void MoveSnake()
        {

        }

        static void GrowSnake()
        {

        }

        static void CreateSnake()
        {
            Snake snake = new Snake();
            snake.Symbol = 'O';

            if (initialSnakeCreation)
            {
                for (int i = 0; i < 3; i++)
                {
                    snake.Body.Enqueue(snake.Symbol);
                    snake.BodyCoordinatesX.Enqueue(i + 1);
                    snake.BodyCoordinatesY.Enqueue(1);

                    Console.SetCursorPosition(i + 1, 1);
                    Console.Write(snake.Symbol);
                }
                
                initialSnakeCreation = false;
            }
            else
            {
                for (int i = 0; i < snake.Count; i++)
                {
                    snake
                }
            }
        }
    }
}
