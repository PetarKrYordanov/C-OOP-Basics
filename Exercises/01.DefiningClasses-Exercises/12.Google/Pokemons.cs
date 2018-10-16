internal class Pokemons
{
    public Pokemons(string name, string type)
    {
        this.name = name;
        this.type = type;
    }
    private string name;
    private string type;

    public string Type { get => type; set => type = value; }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return $"{this.name} {this.type}";
    }
}