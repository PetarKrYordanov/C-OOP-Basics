
using FootballTeamGenerator;
using System;
using System.Collections.Generic;
using System.Linq;

public class Player
{
    private readonly string[] skillNames = new string[] { "Endurance","Sprint", "Dribble","Passing","Shooting" };
    private string name;

    private List<int> skills;

    public Player(string Name)
    {
        this.Name = Name;
        this.skills = new List<int>();
    }
    public string Name
    {
        get { return this.name; }
        set
        {
            Validator.ValidateName(value);
            this.name = value;
        }
    }

    public List<int> Skills
    {
        get { return this.skills; }
        set
        {
            var skills = new int[5];
            for (int i = 0; i < skillNames.Length; i++)
            {
                if (value[i]>100||value[i]<0)
                {
                    throw new ArgumentException(string.Format("{0} should be between 0 and 100.", skillNames[i]));
                }
                skills[i] = value[i];
            }
            this.skills = skills.ToList();
        }
    }
}
