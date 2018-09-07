public class Citizen:SocietyMember
{
    private string name;
    private int age;
    public Citizen(string name, int age, string id)
        :base(id)
    {
        this.Name = name;
        this.Age = age;
    }
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

}
