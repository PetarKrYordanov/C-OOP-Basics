namespace SimpleSnake.Core
{
    using System;
    using System.Threading;

    using GameObjects;
    using Enums;
    public class Engine
    {
        private Point[] pointsOfDirection;
        private Wall wall;
        private Snake snake;
        private Direction direction;
        private double sleepTime;



        public Engine(Wall wall, Snake snake)
        {
            this.wall = wall;
            this.snake = snake;
            this.sleepTime = 100;
            this.pointsOfDirection = new Point[4];
        }
        private void CreateDirections()
        {
            this.pointsOfDirection[0] = new Point(1, 0);
            this.pointsOfDirection[1] = new Point(-1, 0);
            this.pointsOfDirection[2] = new Point(0, 1);
            this.pointsOfDirection[3] = new Point(0, -1);
        }

        private void GetNextDirection()
        {
            ConsoleKeyInfo userInput = Console.ReadKey();

            if (userInput.Key == ConsoleKey.LeftArrow)
            {
                if (direction != Direction.Right)
                {
                    direction = Direction.Left;
                }
            }
            else if (userInput.Key == ConsoleKey.RightArrow)
            {
                if (direction != Direction.Left)
                {
                    direction = Direction.Right;
                }
            }
            else if (userInput.Key == ConsoleKey.UpArrow)
            {
                if (direction != Direction.Down)
                {
                    direction = Direction.Up;
                }
            }
            else if (userInput.Key == ConsoleKey.DownArrow)
            {
                if (direction != Direction.Up)
                {
                    direction = Direction.Down;
                }
            }

            Console.CursorVisible = false;
        }

        public void Run()
        {
            this.CreateDirections();

            while (true)
            {

                if (Console.KeyAvailable)
                {
                    PlayerInfo();
                    GetNextDirection();
                }


                bool isMoving = snake.IsMoving(this.pointsOfDirection[(int)direction]);

                if (!isMoving)
                {
                    AskUserToRestart();
                }

                sleepTime -= 0.01;

                Thread.Sleep((int)sleepTime);
            }
        }

        private void AskUserToRestart()
        {
            int leftX = this.wall.LeftX + 1;
            int topY = 3;
          
            Console.SetCursorPosition(leftX +3, topY);
            Console.Write("Would you like to continue? y/n");

            string input = Console.ReadLine();

            if (input == "y")
            {
                Console.Clear();
                StartUp.Main();
            }
            else
            {
                StopGame();
            }
        }

        private void StopGame()
        {
            Console.SetCursorPosition(20, 10);
            Console.Write("Game over!");
            Environment.Exit(0);
        }

        public void PlayerInfo()
        {
            Console.SetCursorPosition(wall.LeftX+3,0);
            Console.Write($"Player on points {this.snake.PlayerPoints}");
        }
    }
}
