using System;

public class StartUp
{
    static void Main(string[] args)
    {
        var carArgs = Console.ReadLine().Split();
        Vehicle car = new Car(double.Parse(carArgs[1]), double.Parse(carArgs[2]));

        var truckArgs = Console.ReadLine().Split();
        Vehicle truck = new Truck(double.Parse(truckArgs[1]), double.Parse(truckArgs[2]));

        var numberOfCommands = int.Parse(Console.ReadLine());

        for (int i = 0; i < numberOfCommands; i++)
        {
            var commandArgs = Console.ReadLine().Split();

            if (commandArgs[0]=="Drive")
            {
                var distance = double.Parse(commandArgs[2]);
                if (commandArgs[1]=="Car")
                {
                    car.Drive(distance);
                }
                else if(commandArgs[1]=="Truck")
                {
                    truck.Drive(distance);
                }
            }
            else if (commandArgs[0]=="Refuel")
            {
                var litters = double.Parse(commandArgs[2]);
                if (commandArgs[1]=="Car")
                {
                    car.Refuel(litters);
                }
                else if (commandArgs[1]=="Truck")
                {
                    truck.Refuel(litters);
                }
            }
        }
        Console.WriteLine(car.ToString());
        Console.WriteLine(truck.ToString());
    }
}

