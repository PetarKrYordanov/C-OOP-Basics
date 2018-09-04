using System;
public class Tiger : Feline
{
    public const double IncreaseWeightPercentage = 1;

    public Tiger(string name, double weight, string livingRegion, string breed)
        : base(name, weight, livingRegion, breed)
    {
 
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
            throw new ArgumentException($"{this.GetType().Name} does not eat {food.GetType().Name}!");
        }
    }

    public override string ProduceSound()
    {
        return "ROAR!!!";
    }
}

