using System;
using System.Threading;

namespace PingPong
{
    class Startup
    {
        static int padsize = 6;
        static int firstPlayerPositionY = Console.WindowHeight / 2 - padsize / 2;
        static int initialXPositionOfSecondPlayer = Console.WindowWidth - 1;
        static int initialYPositionOfSecondPlayer = Console.WindowHeight / 2 - padsize / 2;
        static int secondPlayerPositionX = Console.WindowWidth - 1;
        static int secondPlayerPositionY = Console.WindowHeight / 2 - padsize / 2;
        static char padSymbol = '|';
        static int ballPositionX = Console.WindowWidth / 2;
        static int ballPositionY = Console.WindowHeight / 2;
        static char ballSymbol = 'O';
        static int firstPlayerResult = 0;
        static int secondPlayerResult = 0;
        static bool ballIsMovingUp = true;
        static bool ballIsMovingRight = true;

        static void Main(string[] args)
        {
            Console.BufferHeight = Console.WindowHeight = 40;
            Console.BufferWidth = Console.WindowWidth = 100;

            string firstSentence = "PLAYER WHO REACHES TO 10 POINTS FIRST WINS!";
            string secondSentence = "Press any key to continue...";

            Console.SetCursorPosition(Console.WindowWidth / 2 - firstSentence.Length / 2, Console.WindowHeight / 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(firstSentence);

            Console.SetCursorPosition(Console.WindowWidth / 2 - secondSentence.Length / 2, Console.WindowHeight / 2 + 2);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write(secondSentence);

            ConsoleKeyInfo key = Console.ReadKey();

            Run();
        }

        static void Run()
        {
            while (true)
            {
                if (Console.KeyAvailable)
                {
                    MoveFirstPlayerPad();
                }

                MoveSecondPlayerPad();

                MoveBall();

                Console.Clear();

                CreateFirstPlayerPad();
                CreateSecondPlayerPad();
                CreateBall();
                GetResult();

                Thread.Sleep(100);

                if (firstPlayerResult == 10)
                {
                    Console.WriteLine("FIRST PLAYER WINS");
                    break;
                }

                if (secondPlayerResult == 10)
                {
                    Console.WriteLine("SECOND PLAYER WINS");
                    break;
                }
            }

        }

        static void GetResult()
        {
            Console.SetCursorPosition(Console.WindowWidth / 2 - (firstPlayerResult.ToString().Length + 1 + secondPlayerResult.ToString().Length), 0);
            Console.Write($"{firstPlayerResult} - {secondPlayerResult}");
        }

        static void MoveBall()
        {
            if (ballPositionX < 3)
            {
                if (ballPositionY >= firstPlayerPositionY
                    && ballPositionY < firstPlayerPositionY + padsize)
                {
                    ballIsMovingRight = true;
                }
            }

            if (ballPositionX >= Console.WindowWidth - 3 - 1)
            {
                if (ballPositionY >= secondPlayerPositionY
                    && ballPositionY < secondPlayerPositionY + secondPlayerPositionY)
                {
                    ballIsMovingRight = false;
                }
            }

            if (ballIsMovingUp)
            {
                if (ballIsMovingRight)
                {
                    if (ballPositionY == 0)
                    {
                        ballIsMovingUp = false;
                    }
                    else
                    {
                        ballPositionY--;
                    }

                    if (ballPositionX == Console.WindowWidth - 1)
                    {
                        SetBallInitialPosition();

                        firstPlayerResult++;

                        ballIsMovingRight = false;
                    }
                    else
                    {
                        ballPositionX++;
                    }
                }
                else
                {
                    if (ballPositionY == 0)
                    {
                        ballIsMovingUp = false;
                    }
                    else
                    {
                        ballPositionY--;
                    }

                    if (ballPositionX == 1)
                    {
                        SetBallInitialPosition();

                        secondPlayerResult++;

                        ballIsMovingRight = true;
                    }
                    else
                    {
                        ballPositionX--;
                    }
                }
            }
            else
            {
                if (ballIsMovingRight)
                {
                    if (ballPositionY == Console.WindowHeight - 1)
                    {
                        ballIsMovingUp = true;
                    }
                    else
                    {
                        ballPositionY++;
                    }

                    if (ballPositionX == Console.WindowWidth - 1)
                    {
                        SetBallInitialPosition();

                        firstPlayerResult++;

                        ballIsMovingRight = false;
                    }
                    else
                    {
                        ballPositionX++;
                    }
                }
                else
                {
                    if (ballPositionY == Console.WindowHeight - 1)
                    {
                        ballIsMovingUp = true;
                    }
                    else
                    {
                        ballPositionY++;
                    }

                    if (ballPositionX == 1)
                    {
                        SetBallInitialPosition();

                        secondPlayerResult++;

                        ballIsMovingRight = true;
                    }
                    else
                    {
                        ballPositionX--;
                    }
                }
            }
        }

        static void SetBallInitialPosition()
        {
            int ballPositionX = Console.WindowWidth / 2;
            int ballPositionY = Console.WindowHeight / 2;

            secondPlayerPositionX = initialXPositionOfSecondPlayer;
            secondPlayerPositionY = initialYPositionOfSecondPlayer;
        }

        static void CreateBall()
        {
            Console.SetCursorPosition(ballPositionX, ballPositionY);
            Console.Write(ballSymbol);
        }

        static void MoveSecondPlayerPad()
        {
            Random randomGenerator = new Random();
            int chance = randomGenerator.Next(0, 101);

            if (chance < 90)
            {
                if (ballIsMovingUp)
                {
                    if (secondPlayerPositionY > 0)
                    {
                        secondPlayerPositionY--;
                    }
                }
                else
                {
                    if (secondPlayerPositionY + padsize < Console.WindowHeight - 1)
                    {
                        secondPlayerPositionY++;
                    }
                }
            }
        }

        static void MoveFirstPlayerPad()
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey();

                if (key.Key == ConsoleKey.UpArrow)
                {
                    if (firstPlayerPositionY > 1)
                    {
                        firstPlayerPositionY--;
                    }
                }

                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (firstPlayerPositionY + padsize < Console.WindowHeight)
                    {
                        firstPlayerPositionY++;
                    }
                }
            }
        }

        static void CreateSecondPlayerPad()
        {
            for (int i = secondPlayerPositionY; i < secondPlayerPositionY + padsize; i++)
            {
                Console.SetCursorPosition(secondPlayerPositionX, i);
                Console.Write(padSymbol);

                Console.SetCursorPosition(secondPlayerPositionX - 1, i);
                Console.Write(padSymbol);
            }
        }

        static void CreateFirstPlayerPad()
        {
            for (int i = firstPlayerPositionY; i < firstPlayerPositionY + padsize; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write(padSymbol);

                Console.SetCursorPosition(1, i);
                Console.Write(padSymbol);
            }
        }
    }
}