
public interface IIdentable
{
    string Id { get; }
    bool IsIdFake(string pattern);
}

