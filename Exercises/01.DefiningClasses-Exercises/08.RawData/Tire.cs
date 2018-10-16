
class Tire
{
    public Tire(double presure, int age)
    {
        this.presure = presure;
        this.age = age;
    }
    private double presure;
    private int age;

    public int Age { get => age; set => age = value; }
    public double Presure { get => presure; set => presure = value; }
}

