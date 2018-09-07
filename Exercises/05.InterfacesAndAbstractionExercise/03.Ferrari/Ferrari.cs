using System;

public class Ferrari : ICar
{
    private string driver;
    private string model = "488-Spider";
    public string Driver { get => this.driver; set => this.driver = value; }

    public string Model { get {return this.model; } }
    public Ferrari(string driver)
    {
        this.Driver = driver;
    }
    public string Brakes()
    {
      return ("Brakes!");
    }

    public string GasPedal()
    {
        return ("Zadu6avam sA!");
    }

    public override string ToString()
    {
        return $"{this.model}/{this.Brakes()}/{this.GasPedal()}/{this.Driver}";
    }
}

