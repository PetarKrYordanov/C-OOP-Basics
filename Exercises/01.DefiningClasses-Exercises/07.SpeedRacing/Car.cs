using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class Car
{
    public Car(string model, double fuelAmount,double fuelConsumption)
    {
        this.model = model;
        this.fuelAmount = fuelAmount;
        this.ConsumptionPerKilometere = fuelConsumption;
        this.distance = 0;
    }
    private string model;
    private double fuelAmount;
    private double consumptionPerKilometere;
    private int distance;

    public int Distance { get => distance; set => distance = value; }
    public double ConsumptionPerKilometere { get => consumptionPerKilometere; set => consumptionPerKilometere = value; }
    public double FuelAmount { get => fuelAmount; set => fuelAmount = value; }
    public string Model { get => model; set => model = value; }

   public static void CalculateDistance(string[] comandArgs, List<Car> cars)
    {
        var carModel = comandArgs[1];
        var carDistance = int.Parse(comandArgs[2]);
        Car thisCar;

        if (cars.Any(x=>x.Model==carModel))
        {
            thisCar = cars.Where(x => x.model == carModel).First();
        }
        else
        {
            return;
        }

        var neededFuel = thisCar.ConsumptionPerKilometere * carDistance;

        if (thisCar.FuelAmount>= neededFuel)
        {
            thisCar.FuelAmount -= neededFuel;
            thisCar.Distance += carDistance; 
        }
        else
        {
            Console.WriteLine("Insufficient fuel for the drive");
        }
        return;
    }
}

