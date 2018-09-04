
using System;

public class Car : Vehicle
{
    public const double CarSummerIncrease = 0.9;

    public Car(double fuelQuantity, double consumptionPerKm,double tankCapacity) 
        : base(tankCapacity, consumptionPerKm, fuelQuantity)
    {
        SummerTime();
    }

    public override void SummerTime()
    {
        this.FuelPerKilometer += CarSummerIncrease;
    }
}
