using System;
public class Truck : Vehicle
{
    public const double TruckSummerIncrease = 1.6;

    public Truck(double fuelQuantity, double consumptionPerKm) : base(fuelQuantity, consumptionPerKm)
    {
        SummerTime();
    }

    public override void Refuel(double liters)
    {
        this.FuelQuantity += liters*0.95;
    }

    public override void SummerTime()
    {
        this.FuelPerKiolometer += TruckSummerIncrease;
    }
}
