using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{

    static void Main(string[] args)
    {
        var personInput = Console.ReadLine().Split(new char[] { ';' }, StringSplitOptions.RemoveEmptyEntries);
        var productInput = Console.ReadLine().Split(new char[] { ';' },StringSplitOptions.RemoveEmptyEntries);

        var persons = new List<Person>();
        var products = new List<Product>();

        try
        {
            for (int i = 0; i < personInput.Length; i++)
            {
                var personArgs = personInput[i].Split('=');
                var person = new Person(personArgs[0],decimal.Parse( personArgs[1]));
                persons.Add(person);
            }

            for (int i = 0; i < productInput.Length; i++)
            {
                var productArgs = productInput[i].Split('=');
                var product = new Product(productArgs[0],decimal.Parse( productArgs[1]));
                products.Add(product);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
            Environment.Exit(0);
        }

        while (true)
        {
            var inputCommand = Console.ReadLine();
            if (inputCommand== "END")
            {
                break;
            }

            var commandArgs = inputCommand.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var product = products.FirstOrDefault(e => e.Name == commandArgs[1]);

            var buyer = persons.FirstOrDefault(e => e.Name == commandArgs[0]);

            bool isValid = buyer.BuyStock(product);

            if (isValid)
            {
                Console.WriteLine($"{commandArgs[0]} bought {commandArgs[1]}");
            }
            else
            {
                Console.WriteLine($"{commandArgs[0]} can't afford {commandArgs[1]}");
            }
        }

        foreach (var p in persons)
        {
            Console.Write($"{p.Name} - ");
            if (p.products.Count ==0)
            {
                Console.Write("Nothing bought");
            }
            else
            {
                Console.WriteLine(string.Join(", ",p.products.Select(e=>e.Name)));
            }
        }
    }
}

