using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Age = 20;
            person.Name = "Pesho";

            var person2 = new Person("Gosho", 18);
            var person3 = new Person("Stamat", 43);
          //  Console.WriteLine(person2.Age);
        }
    }
}

