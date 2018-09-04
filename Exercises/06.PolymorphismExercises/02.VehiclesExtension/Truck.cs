using System;
public class Truck : Vehicle
{
    public const double TruckSummerIncrease = 1.6;

    public Truck(double fuelQuantity, double consumptionPerKm,double tankCapacity)
        : base(tankCapacity, consumptionPerKm,fuelQuantity)
    {
        SummerTime();
    }

    public override void Refuel(double fuelAmount)
    {
        if (fuelAmount<=0)
        {
          throw new ArgumentException("Fuel must be a positive number");
        }

        var newCapacity = this.FuelQuantity + fuelAmount * 0.95;
        if (newCapacity>TankCapacity)
        {
            throw new ArgumentException($"Cannot fit {fuelAmount} fuel in the tank");
        }

        this.FuelQuantity =this.FuelQuantity+ fuelAmount*0.95;
    }

    public override void SummerTime()
    {
        this.FuelPerKilometer += TruckSummerIncrease;
    }
}
