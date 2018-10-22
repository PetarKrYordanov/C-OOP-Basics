using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


public class Pizza
{
    private string name;
    public Dough dough;
    private List<Topping> toppings;


    public Pizza(string name)
    {
        this.Name = name;
        this.toppings = new List<Topping>();
    }

    public Pizza(Dough dough, string name):this(name)
    {
        this.dough = dough;
    }

    public string Name
    {
        get { return this.name; }
        private set
        {
            if (value.Length > 15 || value.Length < 0 || value.Trim() == string.Empty)
            {
                throw new ArgumentException($"Pizza name should be between 1 and 15 symbols.");
            }
            else
                this.name = value;
        }
    }

    public void AddTopping (Topping topping)
    {
        toppings.Add(topping);
        if (toppings.Count>10)
        {
            throw new ArgumentException("Number of toppings should be in range [0..10].");
        }
    }

    private double GetAllCalories()
    {
        var doughCalories = this.dough.DoughCalories();
         var toppingsCalories =   this.toppings.Sum(e => e.GetToppingCalories());
        return doughCalories+toppingsCalories;
    }

    public override string ToString()
    {
        var calories = this.GetAllCalories();
        return $"{this.name} - {calories:f2} Calories.";
    }
}

