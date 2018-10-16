using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        int numberOfCars = int.Parse(Console.ReadLine());

        List<Car> cars = new List<Car>();
        for (int i = 0; i < numberOfCars; i++)
        {
            var currentCarArgs = Console.ReadLine().Split();
            Car currentCar = new Car();
            currentCar.Model = currentCarArgs[0];

            Engine engine = new Engine(int.Parse(currentCarArgs[2]),
                                        int.Parse(currentCarArgs[1]));
            currentCar.Engine = engine;

            Cargo cargo = new Cargo(int.Parse(currentCarArgs[3]),
                                            currentCarArgs[4]);
            currentCar.Cargo = cargo;

            int count = 0;
            for (int j = 6; j < currentCarArgs.Length; j+=2)
            {
                Tire tire = new Tire(double.Parse(currentCarArgs[j - 1]),
                                     int.Parse(currentCarArgs[j]));
                currentCar.Tires[count] = tire;

                count++;
            }
            cars.Add(currentCar);
        }
        var comand = Console.ReadLine();

        if (comand == "fragile")
        {
            foreach (var car in cars.Where(x=>x.Tires.Any(z=>z.Presure<1)))
            {
                if (car.Cargo.Type == "fragile")
                {
                Console.WriteLine(car.Model);
                }
                // if (car.Cargo.Type == "fragile" && car.Tires.Select(x=>x.Presure).Any(x=>x<1))
                // {
                //     Console.WriteLine(car.Model);
                // }
            }
        }
        else
        {
            foreach (var car in cars.Where(x=>x.Engine.EnginePower>250))
            {
                Console.WriteLine(car.Model);
            }
        }
    }
}

