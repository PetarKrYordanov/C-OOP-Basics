namespace SimpleSnake.GameObjects
{
    using System;

    public class Point
    {
        private int leftX;
        private int topY;
        public Point(int leftX, int topY)
        {
            this.LeftX = leftX;
            this.TopY = topY;
        }

        public int LeftX
        {
            get { return this.leftX; }
            set
            {
                //if (value<0 || value>Console.WindowWidth)
                //{
                //    throw new ArgumentException();
                //}

                this.leftX = value;
            }
        }

        public int TopY
        {
            get { return this.topY; }
            set
            {
                //if (value < 0 || value > Console.WindowHeight)
                //{
                //    throw new ArgumentException();
                //}

                this.topY = value;
            }
        }

        public void Draw(char symbol)
        {
            Console.SetCursorPosition(this.LeftX, this.TopY);
            Console.WriteLine(symbol);
        }

        public void Draw(int leftX, int topY, char symbol)
        {
            Console.SetCursorPosition(leftX,topY);
            Console.Write(symbol);
        }
    }
}
