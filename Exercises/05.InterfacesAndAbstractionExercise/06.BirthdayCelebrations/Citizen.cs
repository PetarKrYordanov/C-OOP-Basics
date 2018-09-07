public class Citizen:SocietyMember,IBirthdate
{
    private string name;
    private int age;
    public Citizen(string name, int age,string id,string birthdate)
        :this(name,age,id)
    {
        this.Birthdate = birthdate;
    }
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
    private string birthdate;
    public string Birthdate
    {
        get { return this.birthdate; }
        private set { this.birthdate = value; }
    }

    public bool isValidYear(string date)
    {
        return this.Birthdate.EndsWith(date);
    }
}
