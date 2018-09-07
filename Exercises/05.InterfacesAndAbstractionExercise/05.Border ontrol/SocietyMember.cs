
public abstract class SocietyMember : IIdentable
{
    public SocietyMember(string id)
    {
        this.Id = id;
    }
    private string id;
    public string Id
    {
        get
        { return this.id; }
        set
        {
            this.id = value;
        }
    }

    public bool IsIdFake(string pattern)
    {
        return this.Id.EndsWith(pattern);
    }
}

