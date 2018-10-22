
using System;
using System.Collections.Generic;
using System.Linq;

public class Dough
{
    public const int caloriesPerGram = 2;
    private Dictionary<string, double> validFlourTypes = new Dictionary<string, double>
    {
        ["white"] = 1.5,
        ["wholegrain"] = 1
    };

    public Dictionary<string, double> validBakingTechniques = new Dictionary<string, double>
    {
        ["crispy"] = 0.9,
        ["chewy"] = 1.1,
        ["homemade"] = 1
    };

    private string flourType;
    private string bakingTechnique;
    private double weight;

    public Dough(string flourType, string bakingTechnique, double weight)
    {
        this.FlourType = flourType;
        this.BakingTechnique = bakingTechnique;
        this.Weight = weight;
    }
    public double Weight
    {
        private set
        {
            if (value < 1.0 || value > 200.0)
            {
                throw new ArgumentException("Dough weight should be in the range [1..200].");
            }
            else
                this.weight = value;
        }
        get { return this.weight; }
    }

    public string FlourType
    {
        get { return this.flourType; }
        set
        {
            if (!this.validFlourTypes.Any(e => e.Key.ToLower() == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            else
            this.flourType = value.ToLower();
        }
    } 

    public string BakingTechnique
    {
        get { return this.bakingTechnique; }
        set
        {
            if (!this.validBakingTechniques.Any(e => e.Key.ToLower() == value.ToLower()))
            {
                throw new ArgumentException("Invalid type of dough.");
            }
            else
                this.bakingTechnique = value.ToLower();
        }
    }

    public double DoughCalories()
    {
        var doughCalories = validFlourTypes[this.FlourType.ToLower()] * validBakingTechniques[this.BakingTechnique.ToLower()]*caloriesPerGram*this.Weight;
        return doughCalories;
    }
}
