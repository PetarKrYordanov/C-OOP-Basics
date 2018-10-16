using System.Text;
class Car
{
    public Car(string model, Engine engine)
    {
        this.Model = model;
        this.Engine = engine;
        this.Weight = "n/a";
        this.Color = "n/a";
    }
    public Car()
    {
        this.Weight = "n/a";
        this.Color = "n/a";
    }
    public Car(string model, Engine engine, string weight) : this(model, engine)
    {
        this.Weight = weight;
    }
    private string model;
    private Engine engine;
    private string weight;
    private string color;

    public string Model { get => model; set => model = value; }
    internal Engine Engine { get => engine; set => engine = value; }
    public string Weight { get => weight; set => weight = value; }
    public string Color { get => color; set => color = value; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine(this.Model + ":");
        sb.AppendLine($"  {this.Engine.Model}:");
        sb.AppendLine($"    Power: {this.Engine.Power}");
        sb.AppendLine($"    Displacement: {this.Engine.Displacement}");
        sb.AppendLine($"    Efficiency: {this.Engine.Efficiency}");
        sb.AppendLine($"  Weight: {this.weight}");
        sb.Append($"  Color: {this.color}");

        return sb.ToString();
    }
}

