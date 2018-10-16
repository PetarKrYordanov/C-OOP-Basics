using System.Collections.Generic;
using System.Linq;

public class Family
{
    private List<Person> members;
    public Family()
    {
        this.members = new List<Person>();
    }

    public void AddMember(Person member)
    {
        this.members.Add(member);
    }
    public Person GetOldestMember()
    {
        Person person = members
            .OrderByDescending(x => x.Age)
            .First();
        return person;
    }
}

