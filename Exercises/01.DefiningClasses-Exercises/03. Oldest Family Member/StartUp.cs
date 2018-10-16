using System;
using System.Linq;

public class StartUp
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        Family family = new Family();

        for (int i = 0; i < n; i++)
        {
            var personArgs = Console.ReadLine().Split(' ');

            var personName = personArgs[0];
            var personAge = int.Parse(personArgs[1]);

            Person person = new Person(personName, personAge);
            family.AddMember(person);
        }

        Person oldestPerson = family.GetOldestMember();
        Console.WriteLine(oldestPerson.Name + " " + oldestPerson.Age);
    }
}

