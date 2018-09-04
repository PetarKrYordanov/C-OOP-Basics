using System;
public abstract class Vehicle
{
    public Vehicle(double fuelQuantity, double consumptionPerKm)
    {
        this.FuelQuantity = fuelQuantity;
        this.FuelPerKiolometer = consumptionPerKm;
    }
    public double FuelQuantity { get; set; }

    public double FuelPerKiolometer { get; set; }

    public virtual void Drive(double distance)
    {
        var litersNeeded = this.FuelPerKiolometer * distance;
        if (litersNeeded > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.FuelQuantity -= litersNeeded;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }
    public virtual void Refuel(double liters)
    {
        this.FuelQuantity += liters;
    }

    public abstract void SummerTime();

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
