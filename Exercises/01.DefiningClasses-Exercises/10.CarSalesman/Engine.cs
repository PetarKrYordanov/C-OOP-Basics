class Engine
{
    public Engine()
    {
        this.Displacement = "n/a";
        this.Efficiency = "n/a";
    }
    public Engine(string model, int power) : this()
    {
        this.Model = model;
        this.Power = power;
    }
    private string model;
    private int power;
    private string displacement;
    private string efficiency;

    public string Model { get => model; set => model = value; }
    public int Power { get => power; set => power = value; }
    public string Displacement { get => displacement; set => displacement = value; }
    public string Efficiency { get => efficiency; set => efficiency = value; }
}

