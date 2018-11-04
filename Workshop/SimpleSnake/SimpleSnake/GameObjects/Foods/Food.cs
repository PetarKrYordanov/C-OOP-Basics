namespace SimpleSnake.GameObjects.Foods
{
    using System;
    using System.Linq;
    using System.Collections.Generic;

    public abstract class Food : Point
    {
        public int FoodPoints { get; protected set; }

        public char FoodSymbol
        { get; set; }  

       public Wall wall;

        public Random random;

        protected Food(Wall wall, char foodSymbol, int points)
        :base(wall.LeftX,wall.TopY)
        {
            this.wall = wall;
            this.FoodPoints = points;
            this.FoodSymbol = foodSymbol;   
            this.random = new Random();
        }

        public void SetRandomPosition(Queue<Point> snakeElements)
        {
            this.LeftX = random.Next(2, wall.LeftX - 2);
            this.TopY = random.Next(2, wall.TopY - 2);

            bool isPointOfSnake = snakeElements.Any(x => x.LeftX == this.LeftX &&
                                                         x.TopY == this.TopY);

            while (isPointOfSnake)
            {
                this.LeftX = random.Next(2, wall.LeftX - 2);
                this.TopY = random.Next(2, wall.TopY - 2);

                isPointOfSnake = snakeElements
                    .Any(x => x.LeftX == this.LeftX &&
                              x.TopY == this.TopY);
            }

            Console.BackgroundColor = ConsoleColor.Red;
            this.Draw(FoodSymbol);
            Console.BackgroundColor = ConsoleColor.White;
        }

        public bool IsFoodPoint(Point snake)
        {
            return snake.TopY == this.TopY &&
                   snake.LeftX == this.LeftX;
        }
    }
}
