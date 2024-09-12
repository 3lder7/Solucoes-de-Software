using System;

namespace PooPokemonApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Pokemon instPoke = new Pokemon();
            instPoke.acessoNome = "Pikachu";
            instPoke.acessoDescricao = "Pokémon poderoso";
            instPoke.ExibirDadosPokemon();

            Console.ReadKey();
        }
    }
}
