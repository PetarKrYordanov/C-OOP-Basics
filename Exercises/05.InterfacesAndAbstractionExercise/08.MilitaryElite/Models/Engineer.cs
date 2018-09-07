using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(int id, string firstName, string lastName, double salary, string corps, IList<Repair> repairs)
        : base(id, firstName, lastName, salary, corps)
    {

        this.Repairs = repairs;
    }

    public IList<Repair> Repairs { get; }
    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Repairs:");
        foreach (var item in this.Repairs)
        {
            sb.AppendLine($"  {item.ToString()}");
        }
        return sb.ToString().TrimEnd();
    }

}