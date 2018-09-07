internal class Pet:IBirthdate
{
    private string name;
    private string birthdate;

    public Pet(string name, string birthdate)
    {
        this.Name = name;
        this.Birthdate = birthdate;
    }

    public string Birthdate { get { return this.birthdate; } set { this.birthdate = value; } }
    public string Name { get =>this.name; set { this.name = value; } }

    public bool isValidYear(string date)
    {
        return this.Birthdate.EndsWith(date);
    }
}