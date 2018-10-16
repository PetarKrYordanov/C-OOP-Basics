public class Person
{
    public Person()
    {
        name = "No name";
        age = 1;
    }
    public Person(int age) :this()
    {
        this.age = age;
    }
    public Person(string name) :this()
    {
        this.name = name;
    }
    public Person(string name, int age):this(name)
    {
        this.age = age;
    }

    private string name;
    private int age;

    public string Name
    {
        get { return this.name; }
        set { this.name = value; }
    }

    public int Age
    {
        get { return this.age; }
        set { this.age = value; }
    }
}

