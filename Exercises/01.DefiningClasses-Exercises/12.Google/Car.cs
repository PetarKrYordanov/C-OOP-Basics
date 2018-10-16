public class Car
{
    public Car(string model, int speed)
    {
        this.model = model;
        this.speed = speed;
    }
    private string model;
    private int speed;

    public int Speed { get => speed; set => speed = value; }
    public string Model { get => model; set => model = value; }

    public override string ToString()
    {
        return $"{model} {speed}";
    }
}