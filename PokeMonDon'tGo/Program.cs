namespace PokeMonDon_tGo;
class Program
{
    static void Main(string[] args)
    {
        List<int> pokemons = ReadList();
        int count=pokemons.Count;   
    }
    static List<int> ReadList()
    { 
    List<int> output= Console.ReadLine().Split(' ', SplitStringOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        return output;  
        while (count!=0)
        {


            using System.Xml.Serialization;

namespace PokemonDoNotGo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pokemonVillage = ReadList();
            int length = pokemonVillage.Count;
            bool pokeMonsExist = length > 0;
            int pokemonsCatched = 0;
            do
            {
                int input = int.Parse(Console.ReadLine());
                pokemonsCatched += CatchPokemon(pokemonVillage, input);
            } while (pokeMonsExist);
            PrintResult(pokemonsCatched);
        }

        static int[] ReadArray()d
        {
            int[] output = Console.ReadLine().
                Split(' ', StringSplitOptions.RemoveEmptyEntries).
                Select(int.Parse).
                ToArray();
            return output;
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
        int length = input.Count;
        int output = 0;
        if (index < 0)
        {
            input.Where(x => x > input[0]).Select(x => x -= input[0]).ToList();
            input.Where(x => x <= input[0]).Select(x => x += input[0]).ToList();
            output += input[0];
            input.RemoveAt(0);
            input.Insert(0, input[length - 1]);
        }
        else if (index > length)
        {
            input.Where(x => x > input[length - 1]).Select(x => x.{ x -= input[length - 1]}.ToList();
            input.Where(x => x <= input[length - 1]).Select(x => x += input[length - 1]).ToList();
            output += input[length - 1];
            input.RemoveAt(length - 1);
            input.Insert(length - 1, input[0]);
        }
        else
        {
            input.Where(x => x > input[index]).Select(x => x -= input[index]).ToList();
            input.Where(x => x <= input[index]).Select(x => x += input[index]).ToList();
            output += input[index];
            input.RemoveAt(index);
        }
        return output;
    }
    static void PrintResult(int input)
    {
        Console.WriteLine(input);
    }
}
    
}

        
        
        
        }
    }
}
