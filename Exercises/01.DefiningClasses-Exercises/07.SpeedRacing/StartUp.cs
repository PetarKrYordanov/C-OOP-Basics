using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());
        List<Car> cars = new List<Car>();

        for (int i = 0; i < numberOfCars; i++)
        {
            var carArgs = Console.ReadLine().Split();
            var model = carArgs[0];
            var fuel = int.Parse(carArgs[1]);
            var consumption = double.Parse(carArgs[2]);

            Car car = new Car(model, fuel, consumption);
            cars.Add(car);
        }

        var carComand = Console.ReadLine();
        while (carComand != "End")
        {
            var comandArgs = carComand.Split();
            Car.CalculateDistance(comandArgs, cars);

            carComand = Console.ReadLine();
        }

        foreach (var car in cars)
        {
            Console.WriteLine($"{car.Model} {car.FuelAmount:f2} {car.Distance}");
        }
    }
}

