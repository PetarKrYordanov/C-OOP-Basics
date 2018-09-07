using System;
using System.Text;

public class Tesla : ICar, IElectricCar
{
    public Tesla(string model, string color, int battery)
    {
        this.Model = model;
        this.Color = color;
        this.Battery = battery;
    }
    private int battery;
    public int Battery {
        get => this.battery;
        set
        {
            if (value<0)
            {
                throw new ArgumentException();
            }
            this.battery = value; 
        }
	}
    private string model;
    public string Model
    {
        get => this.model;
        set
        {
            this.model = value;
        }
    }
    private string color;
    public string Color
    { get
        { return this.color; }
        set { this.color = value; }
    }

    public string Start()
    {
        return "Engine start";
    }

    public string Stop()
    {
        return "Breaaak!";
    }

    public override string ToString()
    {
        ;
        var sb = new StringBuilder();

        sb.AppendLine( $"{this.Color} Tesla {this.Model} with {this.Battery} Batteries");
        sb.AppendLine(Start());
        sb.AppendLine(Stop());
        return sb.ToString().TrimEnd();
    }
}

