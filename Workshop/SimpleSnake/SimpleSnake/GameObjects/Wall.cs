namespace SimpleSnake.GameObjects
{
   public class Wall :Point
    {
        public Wall(int leftX, int topY):base(leftX,topY)
        {
            InitializeWallBorders();
        }

        private void InitializeWallBorders()
        {
            SetHorizontalLine(0);
            SetHorizontalLine(this.TopY);

            SetVerticalLine(0);
            SetVerticalLine(this.LeftX -1);
        }

        private const char wallSymbol = '\u25A0';

        private void SetHorizontalLine(int top)
        {
            for (var left = 0; left < this.LeftX; left++)
            {
                this.Draw(left,top,wallSymbol);
            }
        }

        private void SetVerticalLine(int left)
        {
            for (int top =0; top < this.TopY; top++)
            {
                this.Draw(left,top,wallSymbol);
            }
        }

        public bool IsPointOfWall(Point snake)
        {
            return snake.TopY == 0 || snake.LeftX == 0 ||
                   snake.LeftX == this.LeftX || snake.TopY == this.TopY;
        }
    }
}
