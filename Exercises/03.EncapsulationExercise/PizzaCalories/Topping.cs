
using System;
using System.Collections.Generic;
using System.Linq;

public class Topping
{
    private const int CaloriesPerGram = 2;
    private Dictionary<string, double> validTypes = new Dictionary<string, double>
    {
        ["meat"] = 1.2,
        ["veggies"] = 0.8,
        ["cheese"] = 1.1,
        ["sauce"] = 0.9
    };

    private double weight;
    private string type;

    public Topping(string type,double weight)
    {
        this.Type = type;
        this.Weight = weight;
    }
    public string Type
    {
        get { return type; }
        private set
        {
            if (!validTypes.Any(e=>e.Key.ToLower() == value.ToLower()))
            {
                throw new ArgumentException($"Cannot place {value} on top of your pizza.");
            }
            else
            type = value;
        }
    }

    public double Weight
    {
        get { return weight; }
        set
        {
            if (value < 1 || value > 50)
            {
                throw new ArgumentException($"{this.Type} weight should be in the range [1..50].");
            }
            weight = value;
        }
    }

    public double GetToppingCalories()
    {
        double calories = CaloriesPerGram * validTypes[this.Type.ToLower()] * this.Weight;
        return calories;
    }
}
