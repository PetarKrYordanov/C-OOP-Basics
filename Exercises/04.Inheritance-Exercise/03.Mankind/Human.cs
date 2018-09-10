using System;

public class Human
{
    private const int minFirstNameLength = 4;
    private const int minLastNameLength = 3;

    private string firstName;

    private string lastName;

    public Human(string firstName, string lastName)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
    }
    public string LastName
    {
        get { return lastName; }
        set
        {
            if (Char.IsLower(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: lastName");
            }
            if (value.Length<minLastNameLength)
            {
                throw new ArgumentException("Expected length at least 3 symbols!Argument: lastName");
            }      
            this.lastName = value;
        }
    }

    public string FirstName
    {
        get { return this.firstName; }
        set
        {
            if (Char.IsLower(value[0]))
            {
                throw new ArgumentException("Expected upper case letter! Argument: firstName");
            }
            if (value.Length<minFirstNameLength )
            {
                throw new ArgumentException($"Expected length at least {minFirstNameLength} symbols! Argument: firstName");
            }
            this.firstName = value;
        }
    }

}

