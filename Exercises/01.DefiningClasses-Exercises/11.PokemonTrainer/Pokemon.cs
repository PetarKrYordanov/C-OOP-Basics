class Pokemon
{
    public Pokemon(string pokemonName,string polemonElement,int pokemonHealth)
    {
        this.name = pokemonName;
        this.element = polemonElement;
        this.health = pokemonHealth;
    }
    private string name;
    private string element;
    private int health;

    public string Name { get => name; set => name = value; }
    public string Element { get => element; set => element = value; }
    public int Health { get => health; set => health = value; }
}

