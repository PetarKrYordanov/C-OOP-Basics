using System;
using System.Collections.Generic;

class StartUp
{
    static void Main(string[] args)
    {
        var familyTree = new List<Person>();
        string personInput = Console.ReadLine();
        var mainPerson = new Person();

        if (Char.IsDigit(personInput[0]))
        {
            mainPerson.Birthdate = personInput;
        }
        else
        {
            mainPerson.Name = personInput;
        }


        while (true)
        {
            var comand = Console.ReadLine();
            if (comand== "End")
            {
                break;
            }
        }
    }
}

