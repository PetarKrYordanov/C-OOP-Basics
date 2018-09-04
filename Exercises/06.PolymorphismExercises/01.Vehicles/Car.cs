
using System;

public class Car : Vehicle
{
    public const double CarSummerIncrease = 0.9;

    public Car(double fuelQuantity, double consumptionPerKm) : base(fuelQuantity, consumptionPerKm)
    {
        SummerTime();
    }

    public override void SummerTime()
    {
        this.FuelPerKiolometer += CarSummerIncrease;
    }
}
