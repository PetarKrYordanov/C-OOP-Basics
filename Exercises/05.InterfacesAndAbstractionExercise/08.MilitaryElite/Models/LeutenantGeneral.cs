using System;
using System.Collections.Generic;
using System.Text;

public class LeutenantGeneral:Private,ILeutenantGeneral
{
    public IList<IPrivate> Privates { get; set; } = new List<IPrivate>();
    public LeutenantGeneral(int id,string firstName,string lastName,double salary,IList<IPrivate> privates)
        :base(id,firstName,lastName,salary)
    {
        this.Privates = privates;
    }

    public override string ToString()
    {
        var sb = new StringBuilder();

        sb.AppendLine($"Name: {this.FirstName} {this.LastName} Id: {this.Id} Salary: {Math.Round(this.Salary,2):f2}");
        sb.AppendLine("Privates:");
        foreach (var @private in this.Privates)
        {
            sb.AppendLine($"  {@private.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}
