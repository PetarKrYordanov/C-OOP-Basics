using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var numberOfEngines = int.Parse(Console.ReadLine());

        List<Engine> engines = new List<Engine>();
        for (int i = 0; i < numberOfEngines; i++)
        {
            var engineArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            AddEngineToList(engineArray, engines);
        }


        var numberOfCars = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();
        for (int i = 0; i < numberOfCars; i++)
        {
            var carsArray = Console.ReadLine()
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            AddCarToList(carsArray, cars, engines);
        }

        foreach (var item in cars)
        {
            Console.WriteLine(item.ToString());
        }        }

    private static void AddCarToList(string[] carsArray, List<Car> cars, List<Engine> engines)
    {
        Car currentCar = new Car();

        currentCar.Model = carsArray[0];
        Engine currentEngine = engines.FirstOrDefault(x=>x.Model.Equals(carsArray[1]));
        currentCar.Engine = currentEngine;
        if (carsArray.Length == 4)
        {
            currentCar.Weight = carsArray[2];
            currentCar.Color = carsArray[3];
        }
        else if (carsArray.Length == 3)
        {
            int weight;
            bool isWeight = int.TryParse(carsArray[2], out weight);

            if (isWeight)
            {
                currentCar.Weight = carsArray[2];
            }
            else
            {
                currentCar.Color = carsArray[2];
            }
        }
       
        cars.Add(currentCar);
    }

    private static void AddEngineToList(string[] engineArray, List<Engine> engines)
    {
        Engine currentEngine = new Engine();

        var model = engineArray[0];
        var power = int.Parse(engineArray[1]);
        currentEngine.Model = model;
        currentEngine.Power = power;
        if (engineArray.Length == 3)
        {
            var displacementOrEfficiency = engineArray[2];
            int displacement;
            bool isDisplacement = int.TryParse(engineArray[2], out displacement);
            if (isDisplacement)
            {
                currentEngine.Displacement = engineArray[2];
            }
            else
            {
                currentEngine.Efficiency = engineArray[2];
            }
        }
        if (engineArray.Length == 4)
        {
            currentEngine.Displacement = engineArray[2];
            currentEngine.Efficiency = engineArray[3];
        }
        engines.Add(currentEngine);
    }
}

