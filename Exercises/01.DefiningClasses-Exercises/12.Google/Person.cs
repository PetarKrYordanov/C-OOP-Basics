using System;
using System.Collections.Generic;
using System.Text;
class Person
{
    public Person(string name)
    {
        this.name = name;
        this.parents = new List<Parent>();
        this.childrens = new List<Children>();
        this.pokemons = new List<Pokemons>();
    }

    private string name;
    private Company company;
    private Car car;
    private List<Parent> parents;
    private List<Children> childrens;
    private List<Pokemons> pokemons;

    public string Name { get => name; set => name = value; }

    public Car Car { get => car; set => car = value; }

    public List<Parent> Parents { get => parents; set => parents = value; }

    public List<Children> Childrens { get => childrens; set => childrens = value; }

    internal Company Company { get => company; set => company = value; }

    internal List<Pokemons> Pokemons { get => pokemons; set => pokemons = value; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{this.name}");

        sb.AppendLine($"Company:");
        if (company != null)
            sb.AppendLine(company.ToString());

        sb.AppendLine($"Car:");
        if (car != null)
            sb.AppendLine(car.ToString());

        sb.AppendLine($"Pokemon:");
        this.pokemons
            .ForEach(p => sb.AppendLine(p.ToString()));

        sb.AppendLine($"Parents:");
        this.parents
            .ForEach(p => sb.AppendLine(p.ToString()));

        sb.AppendLine("Children:");
        this.childrens
            .ForEach(ch => sb.AppendLine(ch.ToString()));

        return sb.ToString();
    }
}

