using System;
using System.Collections.Generic;
using System.Linq;

public  class StartUp
    {
        static void Main(string[] args)
        {
        var members = new Dictionary<string, IBuyer>();
        GetAllMembers(members);
        BuyFoodCommands(members);
        PrintResult(members);
        }

    private static void PrintResult(Dictionary<string, IBuyer> members)
    {
        var totalFood = members.Sum(e => e.Value.Food);
        Console.WriteLine(totalFood);
    }

    private static void BuyFoodCommands(Dictionary<string, IBuyer> members)
    {
        while (true)
        {
            var inputName = Console.ReadLine();
            if (inputName=="End")
            {
                break;
            }

            if (!members.ContainsKey(inputName))
            {
                continue;
            }
            members[inputName].BuyFood();
        }
    }

    private static void GetAllMembers(Dictionary<string, IBuyer> members)
    {
        var numberOfMembers = int.Parse(Console.ReadLine());
        for (int i = 0; i < numberOfMembers; i++)
        {
            var memberArgs = Console.ReadLine().Split(' ');
            if (memberArgs.Length==3)
            {
                var rebelName = memberArgs[0];
                if (members.ContainsKey(rebelName))
                {
                    continue;
                }
                var rebelAge = int.Parse(memberArgs[1]);
                var groupName = memberArgs[2];

                var rebel = new Rebel(rebelName, rebelAge, groupName);
                members.Add(rebelName,rebel);
            }
            else
            {
                var name = memberArgs[0];
                if (members.ContainsKey(name))
                {
                    continue;
                }
                var age = int.Parse(memberArgs[1]);
                var id = memberArgs[2];
                var birthdate = memberArgs[3];

                var citizen = new Citizen(name, age, id, birthdate);
                members.Add(name, citizen);
            }
     
        }
    }
}

