using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var carArgs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
            .Skip(1).Select(double.Parse).ToArray();
        Vehicle car = new Car(carArgs[0], carArgs[1],carArgs[2]);

        var truckArgs = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries)
            .Skip(1).Select(double.Parse).ToArray();
        Vehicle truck = new Truck(truckArgs[0],truckArgs[1],truckArgs[2]);

        var busArgs = Console.ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Skip(1).Select(double.Parse).ToArray();
        Vehicle bus = new Bus(busArgs[0], busArgs[1], busArgs[2]);

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            try
            {
                var commandArgs = Console.ReadLine().Split();
                if (commandArgs[1] == "Bus")
                {
                    var command = commandArgs[0];
                    var distanceOrLiters = double.Parse(commandArgs[2]);

                    if (command == "Drive")
                    {
                        bus.Drive(distanceOrLiters,0);
                    }
                    else if (command == "DriveEmpty")
                    {
                        bus.Drive(distanceOrLiters, 1);
                    }
                    else if (command == "Refuel")
                    {
                        bus.Refuel(distanceOrLiters);
                    }
                }
               else if (commandArgs[0] == "Drive")
                {
                    var distance = double.Parse(commandArgs[2]);
                    if (commandArgs[1] == "Car")
                    {
                        car.Drive(distance);
                    }
                    else if (commandArgs[1] == "Truck")
                    {
                        truck.Drive(distance);
                    }
                }
                else if (commandArgs[0] == "Refuel")
                {
                    var litters = double.Parse(commandArgs[2]);
                    if (commandArgs[1] == "Car")
                    {
                        car.Refuel(litters);
                    }
                    else if (commandArgs[1] == "Truck")
                    {
                        truck.Refuel(litters);
                    }
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }

        }
        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
        Console.WriteLine(bus.ToString());
    }
}
