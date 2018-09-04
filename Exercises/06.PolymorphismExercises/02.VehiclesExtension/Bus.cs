using System;

public class Bus : Vehicle
{
    public const double BusSummerIncrease = 1.4;
    private double driveEmptyConsumption;
    public double DriveEmptyConsumption
    {
        get
        {
            return this.driveEmptyConsumption;
        }
        set
        {
            this.driveEmptyConsumption = value;
        }
    }

    public Bus(double fuelQuantity, double consumptionPerKm, double tankCapacity)
        : base(tankCapacity, consumptionPerKm, fuelQuantity)
    {
        this.DriveEmptyConsumption = base.FuelPerKilometer;
        SummerTime();
    }
    public override void Drive(double distance, int option = 0)
    {
        if (option == 0)
        {
            base.Drive(distance);
        }
        else
        {
            var litersNeeded = distance * this.DriveEmptyConsumption;
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
    }
    public override void SummerTime()
    {
        this.FuelPerKilometer += BusSummerIncrease;
    }
}
