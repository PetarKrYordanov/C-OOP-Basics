using System.Collections.Generic;

class Trainer
{
    public Trainer(string name)
    {
        this.Name = name;
        this.Badges = 0;
        this.Pokemons = new List<Pokemon>();
    }
    private string name;
    private int badges;
    private List<Pokemon> pokemons;

    public string Name { get => name; set => name = value; }
    public int Badges { get => badges; set => badges = value; }
    internal List<Pokemon> Pokemons { get => pokemons; set => pokemons = value; }
}

