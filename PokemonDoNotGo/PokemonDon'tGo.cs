using System.Xml.Serialization;

namespace PokemonDoNotGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonsVillage = ReadList();
            bool pokeMonsExist;
            int pokemonsCatched = 0;
            do
            {
                int input = int.Parse(Console.ReadLine());
                pokemonsCatched += CatchPokemon(pokemonsVillage, input);
                 pokeMonsExist = pokemonsVillage.Count > 0;
            } while (pokeMonsExist);
            PrintResult(pokemonsCatched);
        }

        static List<int> ReadList()
        {
            List<int> output = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToList();
            return output;
        }
        static int CatchPokemon(List<int> input, int index)
        {
           // int length = input.Count;
            int pokemon;
            int output = 0;
            if (index < 0)
            {
                pokemon = input[0];
                output += pokemon;
                input.RemoveAt(0);
                input.Insert(0, input[input.Count-1]);
            }
            else if (index >= input.Count)
            {
                pokemon = input[input.Count - 1];
                output += pokemon;
                input.RemoveAt(input.Count - 1);
                input.Add(input[0]);
            }
            else
            {
                pokemon = input[index];   
                output += pokemon;
                input.RemoveAt(index);

            }
            for (int i = 0; i < input.Count; i++)
            {
                if (input[i] <= pokemon)
                    input[i] += pokemon;
                else if (input[i] > pokemon)
                    input[i] -= pokemon;
            }

            return output;
        }
        static void PrintResult(int input)
        {
            Console.WriteLine(input);
        }
    }

}
