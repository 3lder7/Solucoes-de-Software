using System;
using PokemonNamespace;

namespace PooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon instPoke = new Pokemon("Pikachu", "Pokémon poderoso");
            instPoke.ExibirDadosPokemon(true);

            Console.ReadKey();
        }
    }
}
