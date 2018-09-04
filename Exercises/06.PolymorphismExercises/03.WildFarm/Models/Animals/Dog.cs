using System;

public class Dog : Mammal
{
    public const double IncreaseWeightPercentage = 0.4;

    public Dog(string name, double weight, string livingRegion)
        : base(name, weight, livingRegion)
    {
    }

    public override string ProduceSound()
    {
        return "Woof!";
    }

    public override void IncreaseWeight(Food food)
    {
        var foodType = food.GetType().Name;
        if (foodType == "Meat")
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
}
