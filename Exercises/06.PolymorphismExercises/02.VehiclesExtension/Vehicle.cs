using System;
public abstract class Vehicle
{
    private double tankCapacity;
    private double fuelQuantity;
    private double fuelPerKilometer;
    public Vehicle(double tankCapacity, double consumptionPerKm, double fuelQuantity)
    {
        this.TankCapacity = tankCapacity;
        this.FuelQuantity = fuelQuantity;
        this.FuelPerKilometer = consumptionPerKm;
    }
    public double FuelQuantity
    {
        get
        {
            return this.fuelQuantity;
        }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }

            if (value > this.TankCapacity)
            {
                this.fuelQuantity = 0;
            }
            else
            {
                this.fuelQuantity = value;
            }
        }
    }

    public double TankCapacity
    {
        get
        {
            return this.tankCapacity;
        }
        set
        {
            if (value<0)
            {
                throw new ArgumentException("Fuel must be a positive number");
            }  
            this.tankCapacity = value;
        }
    }

    public virtual double FuelPerKilometer
    {
        get
        {
            return this.fuelPerKilometer;
        }
        set
        {
            this.fuelPerKilometer = value;
        }
    }

    public virtual void Drive(double distance, int option = 0)
    {

        var litersNeeded = this.FuelPerKilometer * distance;
        if (litersNeeded > this.FuelQuantity)
        {
            Console.WriteLine($"{this.GetType().Name} needs refueling");
        }
        else
        {
            this.FuelQuantity =this.fuelQuantity- litersNeeded;
            Console.WriteLine($"{this.GetType().Name} travelled {distance} km");
        }
    }

    public virtual void Refuel(double fuelAmount)
    {
        if (fuelAmount <= 0)
        {
            throw new ArgumentException("Fuel must be a positive number");
        }
        var newFuelQuantity = this.FuelQuantity + fuelAmount;

        if (this.TankCapacity < newFuelQuantity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }
        this.FuelQuantity =this.FuelQuantity+ fuelAmount;
    }

    public abstract void SummerTime();

    public override string ToString()
    {
        return $"{this.GetType().Name}: {this.FuelQuantity:f2}";
    }
}
