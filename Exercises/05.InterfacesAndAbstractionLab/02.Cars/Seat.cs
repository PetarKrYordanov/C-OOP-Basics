using System.Text;

public class Seat : ICar
{
    private string model;
    private string color;
    public Seat(string model, string color)
    {
        this.Color = color;
        this.Model = model;
    }
    public string Model { get => this.model; set => this.model = value; }
    public string Color { get => this.color; set =>this.color=value; }

    public string Start()
    {
        return $"Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"{this.Color} Seat {this.Model}");
        sb.AppendLine(Start());
        sb.AppendLine(Stop());
        return sb.ToString().TrimEnd();

    }
}

