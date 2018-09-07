public class Repair:IRepair
{
    public Repair(string partName,int hoursNeeded)
    {
        this.PartName = partName;
        this.HoursWorked = hoursNeeded;
    }
    public string PartName { get; set; }
    public int HoursWorked { get; set; }

    public override string ToString()
    {
        return $"Part Name: {this.PartName} Hours Worked: {this.HoursWorked}";
    }
}
