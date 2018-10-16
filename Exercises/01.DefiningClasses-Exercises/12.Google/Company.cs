internal class Company
{
    public Company(string name,string department, decimal salary)
    {
        this.name = name;
        this.department = department;
        this.salary = salary;
    }

    private string name;
    private string department;
    private decimal salary;

    public decimal Salary { get => salary; set => salary = value; }
    public string Department { get => department; set => department = value; }
    public string Name { get => name; set => name = value; }

    public override string ToString()
    {
        return $"{name} {department} {salary:f2}";
    }
}