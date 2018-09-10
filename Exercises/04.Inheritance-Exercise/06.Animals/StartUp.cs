using System;
using System.Collections.Generic;

public class StartUp
{
    static void Main(string[] args)
    {

        var animals = new List<Animal>();
        while (true)
        {
            var animalType = Console.ReadLine();
            if (animalType == "Beast!")
            {
                break;
            }
            try
            {
            ReadAndCreateAnimal(animals, animalType);
            }
            catch (Exception)
            {
                Console.WriteLine("Invalid input!");
            }
        }
        foreach (var animal in animals)
        {
            Console.WriteLine(animal);
        }
    }

    private static void ReadAndCreateAnimal(List<Animal> animals, string animalType)
    {
        var animalTokens = Console.ReadLine().Split(' ');
        string name = animalTokens[0];
        int age = int.Parse(animalTokens[1]);
        string gender = "Male";
        if (animalTokens.Length == 3)
        {
            gender = animalTokens[2];
        }

        switch (animalType)
        {
            case "Cat":
                var cat = new Cat(name, age, gender);
                animals.Add(cat);
                break;
            case "Dog":
                var dog = new Dog(name, age, gender);
                animals.Add(dog);
                break;
            case "Frog":
                var frog = new Frog(name, age, gender);
                animals.Add(frog);
                break;
            case "Tomcat":
                var tomcat = new Tomcat(name, age);
                animals.Add(tomcat);
                break;
            case "Kitten":
                var kitten = new Kitten(name, age);
                animals.Add(kitten);
                break;
            default:
                break;
        }
    }
}

