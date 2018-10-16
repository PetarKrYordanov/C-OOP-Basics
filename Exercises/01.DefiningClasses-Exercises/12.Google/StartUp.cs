using System;
using System.Collections.Generic;
using System.Linq;

namespace _12.Google
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>();
            while (true)
            {
                var input = Console.ReadLine();
                if (input == "End")
                {
                    break;
                }
                var personInput = input
                    .Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                AddPersonToList(personInput, persons);                
            }
            var searchedPerson = Console.ReadLine();

            var person = persons.FirstOrDefault(x => x.Name.Equals(searchedPerson));
            Console.WriteLine(person.ToString());
        }

        private static void AddPersonToList(List<string> personInput, List<Person> persons)
        {
            var currentName = personInput[0];

            var currentPerson = persons.FirstOrDefault(p => p.Name.Equals(currentName));
            if (currentPerson == null)
            {
                currentPerson = new Person(currentName);
                persons.Add(currentPerson);
            }

            var personAttribute = personInput[1];

            switch (personAttribute)
            {
                case "company":
                    currentPerson.Company = 
                        new Company(personInput[2], personInput[3], decimal.Parse(personInput[4]));
                    break;
                case "pokemon": currentPerson.Pokemons
                        .Add(new Pokemons(personInput[2], personInput[3]));
                    break;
                case "parents":
                    currentPerson.Parents
                        .Add(new Parent(personInput[2], personInput[3]));
                    break;
                case "children":
                    currentPerson.Childrens
                        .Add(new Children(personInput[2], personInput[3]));
                    break;
                case "car":
                    currentPerson.Car = new Car(personInput[2], int.Parse(personInput[3]));
                    break;
                default:
                    break;
            }
        }
    }
}
