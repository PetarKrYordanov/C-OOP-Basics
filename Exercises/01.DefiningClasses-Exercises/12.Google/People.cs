public class People
    {
    public People(string name, string birthday)
    {
        this.name = name;
        this.birthday = birthday;
    }
    public People()
    {

    }

    private string name;
    private string birthday;

    public string Birthday { get => birthday; set => birthday = value; }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return $"{this.name} {this.birthday}";
    }
}

