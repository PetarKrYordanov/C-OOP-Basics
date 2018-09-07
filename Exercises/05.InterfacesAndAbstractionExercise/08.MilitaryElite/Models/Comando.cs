using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Comando:SpecialisedSoldier,ICommando
    {
    public Comando(string firstName,string lastName, int id,string corps,double salary,IList<IMission> missions)
        :base(id,firstName,lastName,salary,corps)
    {
        this.Missions = missions;
    }

    public IList<IMission> Missions{ get; private set; }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine(base.ToString());
        sb.AppendLine("Missions:");
    //    this.Missions = this.Missions.Where(e => e.State == "inProgress").ToArray();
        foreach (var item in this.Missions)
        {
            sb.AppendLine($"  {item.ToString()}");
        }

        return sb.ToString().TrimEnd();
    }
}
