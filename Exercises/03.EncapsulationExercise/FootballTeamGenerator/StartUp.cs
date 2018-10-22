using FootballTeamGenerator;
using System;
using System.Collections.Generic;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        List<Team> teams = new List<Team>();

        while (true)
        {
            var input = Console.ReadLine();
            if (input == "END")
            {
                break;
            }


            var inputTokens = input.Split(';');
            try
            {
                switch (inputTokens[0])
                {
                    case "Team":
                        var team = new Team(inputTokens[1]);
                        teams.Add(team);
                        break;
                    case "Add":
                        AddPlayerCommand(inputTokens, teams);
                        break;
                    case "Remove":
                        RemovePlayer(inputTokens, teams);
                        break;
                    case "Rating":
                        PrintRating(inputTokens[1], teams);
                        break;
                    default:
                        break;
                }
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }

    private static void PrintRating(string teamName, List<Team> teams)
    {
        var team = teams.SingleOrDefault(e => e.Name == teamName);
        if (team == null)
        {
            throw new ArgumentException($"Team {teamName} does not exist.");
        }
        var teamRating = team.GetTeamRating();
        Console.WriteLine($"{teamName} - {teamRating}");
    }

    private static void RemovePlayer(string[] inputTokens, List<Team> teams)
    {
        var team = teams.FirstOrDefault(e => e.Name == inputTokens[1]);
        if (team == null)
        {
            throw new ArgumentException($"Team {team.Name} does not exist.");
        }
        team.RemovePlayer(inputTokens[2]);
    }

    private static void AddPlayerCommand(string[] inputTokens, List<Team> teams)
    {
        var team = teams.SingleOrDefault(e => e.Name == inputTokens[1]);
        if (team == null)
        {
            throw new ArgumentException($"Team {inputTokens[1]} does not exist.");
        }
        var player = new Player(inputTokens[2]);
        player.Skills = inputTokens.Skip(3).Take(5).Select(int.Parse).ToList();

        team.AddPlayer(player);
    }
}

