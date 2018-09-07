using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {
        var allMembers = new List<SocietyMember>();

        ReadAllMembers(allMembers);
        PrintNotValidIds(allMembers);      
    }

    private static void PrintNotValidIds(List<SocietyMember> allMembers)
    {
        var pattern = Console.ReadLine();
        foreach (var member in allMembers)
        {
            if (member.IsIdFake(pattern))
            {
                Console.WriteLine(member.Id);
            }
        }
    }

    private static void ReadAllMembers(List<SocietyMember> allMembers)
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            var inputArgs = input.Split(' ');

            if (inputArgs.Length == 2)
            {
                var model = inputArgs[0];
                var id = inputArgs[1];
                var robot = new Robot(model, id);
                allMembers.Add(robot);
            }
            else if (inputArgs.Length == 3)
            {
                var name = inputArgs[0];
                var age = int.Parse(inputArgs[1]);
                var id = inputArgs[2];

                var citizen = new Citizen(name, age, id);
                allMembers.Add(citizen);
            }
        }
    }
}
