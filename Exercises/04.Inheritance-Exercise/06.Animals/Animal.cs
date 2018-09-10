using System;
using System.Text;

public class Animal:ISoundProducable
{
    private const string ErrorMsg = "Invalid input!";
    //•	Each Animal should have a name, an age and a gender
    private string name;
    private int age;
    private string gender;

    public Animal(string name,int age,string gender)
    {
        this.Name = name;
        this.Age = age;
        this.Gender = gender;
    }
    public string Name
    {
        get { return name; }
        set
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException(ErrorMsg);
            }
           this.name = value;
        }
    }
    public int Age
    {
        get { return age; }
        set
        {
            if (value <= 0)
            {
                throw new ArgumentException(ErrorMsg);
            } 
            this.age = value;
        }
    }
    public string Gender
    {
        get { return gender; }
        set
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException(ErrorMsg);
            }
            gender = value;
        }
    }
    public virtual string ProduceSound()
    {
        return "Noise";
    }

    public override string ToString()
    {
        var sb = new StringBuilder();
        sb.AppendLine($"{this.GetType().Name}");
        sb.AppendLine($"{this.Name} {this.Age} {this.Gender}");
        sb.AppendLine(this.ProduceSound());

        return sb.ToString().TrimEnd();
    }
}

