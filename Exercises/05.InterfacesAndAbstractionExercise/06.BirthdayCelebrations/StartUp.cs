using System;
using System.Collections.Generic;

public class StartUp
    {
        static void Main(string[] args)
        {
        var allMembers = new List<IBirthdate>();
        GetAllMembers(allMembers);
        PrintResult(allMembers);
        }

    private static void PrintResult(List<IBirthdate> allMembers)
    {
        var dateEnd = Console.ReadLine();
        foreach (var member in allMembers)
        {
            if (member.isValidYear(dateEnd))
            {
                Console.WriteLine(member.Birthdate);
            }
        }
    }

    private static void GetAllMembers(List<IBirthdate> allMembers)
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }
            var inputArgs = input.Split(' ');

            switch (inputArgs[0])
            {
                case "Citizen":
                    var name = inputArgs[1];
                    var age = int.Parse(inputArgs[2]);
                    var id = inputArgs[3];
                    var birthdate = inputArgs[4];
                    var citizen = new Citizen(name, age, id, birthdate);
                    allMembers.Add(citizen);
                    break;
                case "Pet":
                    var petName = inputArgs[1];
                    var petBirthdate = inputArgs[2];
                    var pet = new Pet(petName, petBirthdate);
                    allMembers.Add(pet);
                    break;
                default:
                    break;
            }
        }
    }
}

