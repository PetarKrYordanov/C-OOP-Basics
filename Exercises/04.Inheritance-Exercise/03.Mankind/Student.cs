using System;
using System.Linq;

public class Student : Human
{
    private string facultyNumber;

    public string FacultyNumber
    {
        get { return facultyNumber; }
         set
        {
            if (value.Length > 10 || value.Length < 5 || !value.All(Char.IsLetterOrDigit))
            {
                throw new ArgumentException("Invalid faculty number!");
            }
            this.facultyNumber = value;
        }
    }

    public Student(string firstName, string lastName, string facultyNumber)
        : base(firstName, lastName)
    {
        this.FacultyNumber = facultyNumber;
    }

    public override string ToString()
    {
        return $"First Name: {base.FirstName + Environment.NewLine}" +
            $"Last Name: {base.LastName + Environment.NewLine}" +
            $"Faculty number: {this.facultyNumber}";
    }
}

