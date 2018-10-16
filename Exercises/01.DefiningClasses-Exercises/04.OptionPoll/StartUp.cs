using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());
        var persons = new List<Person>();

        for (int i = 0; i < n; i++)
        {
            var personArgs = Console.ReadLine().Split();

            var personName = personArgs[0];
            var personAge = int.Parse(personArgs[1]);

            Person person = new Person(personName, personAge);
            persons.Add(person);
        }

        var selectedPersons = persons.Where(p => p.Age > 30).ToList();

        foreach (var person in selectedPersons.OrderBy(x=>x.Name))
        {
            Console.WriteLine($"{person.Name} - {person.Age}");
        }
    }
}

