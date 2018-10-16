using System;
using System.Collections.Generic;
using System.Linq;

class StartUp
{
    static void Main(string[] args)
    {
        var input = Console.ReadLine();
        var pokemons = new List<Pokemon>();
        var trainers = new List<Trainer>();

        while (input != "Tournament")
        {
            var inputArray = input
                .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Pokemon pokemon = AddPokemon(inputArray);
            pokemons.Add(pokemon);
            AddTrainer(inputArray, pokemon, trainers);

            input = Console.ReadLine();
        }

        while (true)
        {
            var comand = Console.ReadLine();
            if (comand == "End")
            {
                break;
            }

            UpdateTrainerBadges(comand, trainers);

            foreach (var trainer in trainers.Where(t => t.Pokemons.All(p => p.Element != comand)).ToList())
            {
                trainer.Pokemons.ForEach(p => p.Health -= 10);
                trainer.Pokemons = trainer.Pokemons.Where(p => p.Health > 0).ToList();
            }
        }

        foreach (var trainer in trainers.OrderByDescending(t => t.Badges))
        {
            Console.WriteLine($"{trainer.Name} {trainer.Badges} {trainer.Pokemons.Count}");
        }
    }

    private static void UpdateTrainerBadges(string comand, List<Trainer> trainers)
    {
     trainers.Where(t => t.Pokemons.Any(z => z.Element.Equals(comand)))
                        .ToList()
                        .ForEach(t => t.Badges += 1);
    }

    private static Pokemon AddPokemon(string[] inputArray)
    {
        var pokemonName = inputArray[1];
        var pokemonElement = inputArray[2];
        var pokemonHealth = int.Parse(inputArray[3]);
        Pokemon curremtPokemon = new Pokemon(pokemonName, pokemonElement, pokemonHealth);

        return curremtPokemon;
    }

    private static void AddTrainer(string[] inputArray, Pokemon pokemon, List<Trainer> trainers)
    {
        if (trainers.Any(x=>x.Name.Equals(inputArray[0])))
        {
            var thisTrainer = trainers.FirstOrDefault(x => x.Name.Equals(inputArray[0]));
            thisTrainer.Pokemons.Add(pokemon);
            return;
        }
        Trainer trainer = new Trainer(inputArray[0]);
        trainer.Pokemons.Add(pokemon);
        trainers.Add(trainer);
    }
}

