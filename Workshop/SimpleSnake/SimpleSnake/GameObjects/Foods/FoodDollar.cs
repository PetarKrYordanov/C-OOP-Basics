namespace SimpleSnake.GameObjects.Foods
{
  public  class FoodDollar:Food
    {
       public const char foodSymbol = '$';
       public const int points = 2;

        public FoodDollar(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }
    }
}
