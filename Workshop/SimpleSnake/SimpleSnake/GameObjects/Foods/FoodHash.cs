namespace SimpleSnake.GameObjects.Foods
{
public    class FoodHash:Food
    {
       public const char foodSymbol = '#';
       public const int points =3;

        public FoodHash(Wall wall)
            : base(wall, foodSymbol, points)
        {

        }
    }
}
