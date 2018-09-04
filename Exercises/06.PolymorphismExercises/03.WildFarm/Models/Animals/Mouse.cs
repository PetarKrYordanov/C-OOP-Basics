using System;

public class Mouse : Mammal
{
    public const double IncreaseWeightPercentage = 0.1;

    public Mouse(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override void IncreaseWeight(Food food)
    {
        var foodType = this.GetType().Name;
        if (foodType == "Vegetable" || foodType == "Fruit")
        {
            this.Weight += food.FoodQuantity * IncreaseWeightPercentage;
            this.FoodEaten += food.FoodQuantity;
        }
        else
        {
            throw new ArgumentException($"{this.GetType().Name}" +
                $" does not eat {food.GetType().Name}!");
        }
    }

    public override string ProduceSound()
    {
        return "Squeak";
    }
}

