using System;
using System.Collections.Generic;
using System.Linq;

namespace _04._Pokemon_Evolution
{
    class PokeEvolution
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            List<Pokemon> pokemons = new List<Pokemon>();

            while (input != "wubbalubbadubdub")
            {
                var currentPokemon = input.Split(new char[] { '-', '>' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                Pokemon pokemon = new Pokemon();

                if (currentPokemon.Count == 1)
                {
                    pokemon = pokemons.First(x => x.Name == currentPokemon[0].Trim());
                    Console.WriteLine($"# {pokemon.Name}");

                    foreach (var evol in pokemon.Evolutions)
                    {
                        Console.WriteLine($"{evol.EvolutionName} <-> {evol.Index}");
                    }
                    input = Console.ReadLine();

                    continue;
                }
                pokemon.Name = currentPokemon[0].Trim();
                List<Evolution> evolutions = new List<Evolution>();
                Evolution currentEvolution = new Evolution();

                currentEvolution.EvolutionName = currentPokemon[1].Trim();
                currentEvolution.Index = int.Parse(currentPokemon[2].Trim());

                if (pokemons.Any(x => x.Name == currentPokemon[0].Trim()))
                {
                    pokemon = pokemons.First(y => y.Name == currentPokemon[0].Trim());
                    pokemon.Evolutions.Add(currentEvolution);
                }
                else
                {
                    evolutions.Add(currentEvolution);
                    pokemon.Evolutions = evolutions;
                    pokemons.Add(pokemon);
                }
                input = Console.ReadLine();
            }

            foreach (var pokemon in pokemons)
            {
                Console.WriteLine($"# {pokemon.Name}");

                foreach (var evol in pokemon.Evolutions.OrderByDescending(x => x.Index))
                {
                    Console.WriteLine($"{evol.EvolutionName} <-> {evol.Index}");
                }
            }
        }
    }
    class Pokemon
    {
        public string Name { get; set; }
        public List<Evolution> Evolutions { get; set; }
    }
    class Evolution
    {
        public String EvolutionName { get; set; }
        public int Index { get; set; }
    }
}
