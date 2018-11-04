using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        var idSoldiers = new Dictionary<int, Soldier>();

        GetAllSoldiers(idSoldiers);
    }
    //to do make validation check on corps and missionState
    private static void GetAllSoldiers(Dictionary<int, Soldier> idSoldiers)
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (input == "End")
            {
                break;
            }

            var soldierArgs = input.Split(' ');
            var type = soldierArgs[0];
            try
            {
                soldierArgs = soldierArgs.Skip(1).ToArray();
                switch (type)
                {
                    case "Private":
                        AddPrivate(soldierArgs, idSoldiers);
                        break;
                    case "Engineer":
                        AddEngineer(soldierArgs, idSoldiers);
                        break;
                    case "Commando":
                        try
                        {
                        AddCommando(soldierArgs, idSoldiers);

                        }
                        catch (Exception)
                        {

                            throw;
                        }
                        break;
                    case "Spy":
                        AddSpy(soldierArgs, idSoldiers);
                        break;
                    case "LieutenantGeneral":
                        AddLeutenantGeneral(soldierArgs, idSoldiers);
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException e)
            {
                continue;               
            }
    
        }

        foreach (var item in idSoldiers.Values)
        {
            Console.WriteLine(item.ToString());
        }
    }

    private static void AddLeutenantGeneral(string[] soldierArgs, Dictionary<int, Soldier> idSoldiers)
    {
        //  LeutenantGeneral<id> < firstName > < lastName > < salary > < private1Id > < private2Id > … < privateNId >    }
        var id = int.Parse(soldierArgs[0]);
        var firstName = soldierArgs[1];
        var lastName = soldierArgs[2];
        var salary = double.Parse(soldierArgs[3]);

        var privateIds = soldierArgs.Skip(4).Select(int.Parse).ToArray();
        var privateList = new List<IPrivate>();

        for (int i = 0; i < privateIds.Length; i++)
        {
            privateList.Add((IPrivate)idSoldiers[privateIds[i]]);
        }
        var leutenantGeneral = new LeutenantGeneral(id, firstName, lastName, salary, privateList);
        idSoldiers.Add(id, leutenantGeneral);
    }
    private static void AddSpy(string[] soldierArgs, Dictionary<int, Soldier> idSoldiers)
    {
        var id = int.Parse(soldierArgs[0]);
        var firstName = soldierArgs[1];
        var lastName = soldierArgs[2];
        var codeNumber = int.Parse(soldierArgs[3]);

        var spy = new Spy(id, firstName, lastName, codeNumber);

        if (!idSoldiers.ContainsKey(id))
        {
            idSoldiers.Add(id, spy);
        }
    }

    private static void AddCommando(string[] soldierArgs, Dictionary<int, Soldier> idSoldiers)
    {
        //  Commando<id> < firstName > < lastName > < salary > < corps > < mission1CodeName >  < mission1state > … < missionNCodeName > < missionNstate >” 
        var id = int.Parse(soldierArgs[0]);
        var firstName = soldierArgs[1];
        var lastName = soldierArgs[2];
        var salary = double.Parse(soldierArgs[3]);
        var corps = soldierArgs[4];

        var missionsArgs = soldierArgs.Skip(5).ToArray();
        var missions = new List<IMission>();
        for (int i = 0; i < missionsArgs.Length; i+=2)
        {
            var missionState = missionsArgs[i + 1];
            string[] validMissionsState = new string[] { "Finished", "inProgress" };
            if (!validMissionsState.Any(e=>e==missionState))
            {
                continue;
            }
            var mission = new Mission(missionsArgs[i], missionsArgs[i + 1]);
            missions.Add(mission);
        }

        var commando = new Comando(firstName, lastName, id, corps, salary, missions);

        if (!idSoldiers.ContainsKey(id))
        {
            idSoldiers.Add(id, commando);
        }
    }

    private static void AddEngineer(string[] soldierArgs, Dictionary<int, Soldier> idSoldiers)
    {
        //    Engineer<id> < firstName > < lastName > < salary > < corps > < repair1Part > < repair1Hours > … < repairNPart > < repairNHours >
        var id = int.Parse(soldierArgs[0]);
        var firstName = soldierArgs[1];
        var lastName = soldierArgs[2];
        var salary = double.Parse(soldierArgs[3]);
        var corps = soldierArgs[4];
        var repairsArgs = soldierArgs.Skip(5).ToArray();
        var repairsList = new List<Repair>();
        for (int i = 0; i < repairsArgs.Length; i+=2)
        {
            var repair = new Repair(repairsArgs[i], int.Parse(repairsArgs[i+1]));
            repairsList.Add(repair);
        }

        var engineer = new Engineer(id, firstName, lastName, salary, corps, repairsList);

        if (!idSoldiers.ContainsKey(id))
        {
            idSoldiers.Add(id, engineer);
        }
    }

    private static void AddPrivate(string[] soldierArgs, Dictionary<int, Soldier> idSoldiers)
    {
        var id = int.Parse(soldierArgs[0]);
        var firstName = soldierArgs[1];
        var lastName = soldierArgs[2];
        var salary = double.Parse(soldierArgs[3]);

        var privateSoldier = new Private(id, firstName, lastName, salary);
        idSoldiers.Add(id, privateSoldier);

    }
}
