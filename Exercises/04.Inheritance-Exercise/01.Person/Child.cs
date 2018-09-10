using System;

public class Child:Person
{
    private const int ChildMaxAge = 15;
    public Child(string name, int age):base(name,age)
    {

    }

    public override int Age
    {
        get => base.Age;
        set
        {
            if (value>15)
            {
                throw new ArgumentException($"Child's age must be less than {ChildMaxAge}!");
            }
            base.Age = value;
         //   this.Age = value;
        }
    }
    
}