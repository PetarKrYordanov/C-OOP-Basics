namespace SimpleSnake.GameObjects.Foods
{
  public  class FoodAsterisk:Food
  {
      public const char foodSymbol = '*';
      public const int points = 1;

      public FoodAsterisk(Wall wall)
          : base(wall, foodSymbol, points)
      {

      }
  }
}
