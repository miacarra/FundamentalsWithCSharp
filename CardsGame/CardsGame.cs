using System.Collections.Generic;
namespace CardsGame
{
    internal class CardsGame
    {
        static void Main(string[] args)
        {
            List<int> player1 = ReadList();
            List<int> player2 = ReadList();
            int deck1 = player1.Count;
            int deck2 = player2.Count;
            int result;

            while (true)
            {
                if (deck1 == 0 || deck2 == 0)
                    break;
                result = PlayCards(player1, player2);
                  if (result==0 )
                {
                    Player1Loses(player1);
                    Player2Loses(player2);
                }
                else if (result == 1)
                {
                    Player1Wins(player1, player2);
                    Player2Loses(player2);
                }
                else if (result == 2)
                {
                    Player2Wins(player2, player1);
                    Player1Loses(player1);
                }
                deck1 = player1.Count;
                deck2 = player2.Count;

            }
            PresenTheWinner(player1, player2);

        }
        private static List<int> ReadList()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }
        private static int PlayCards(List<int> player1, List<int> player2)
        {
            if (player1.First() > player2.First())
                return 1;
            else if (player1.First() < player2.First())
                return 2;
            else
                return 0;
        }
        static List<int> Player1Wins(List<int> player1, List<int> player2)
        {
            player1.Add(player1.First());
            player1.Add(player2.First());
            player1.RemoveAt(0);
            
            return player1;
        }
        static List<int> Player1Loses(List<int> player1)
        {
            player1.RemoveAt(0);
            return player1;
        }
        static List<int> Player2Wins(List<int> player2, List<int> player1)
        {
            player2.Add(player2.First());
            player2.Add(player1.First());
            player2.RemoveAt(0);
            return player2;
        }
        static List<int> Player2Loses(List<int> player2)
        {
            player2.RemoveAt(0);
            return player2;
        }
        static void PresenTheWinner(List<int> player1, List<int> player2)
        {
            if (player1.Count>player2.Count && player2.Count <= 0)
                Console.WriteLine($"First player wins! Sum: {player1.Sum()}");
            else if (player2.Count > player1.Count && player1.Count <= 0)
                Console.WriteLine($"Second player wins! Sum: {player2.Sum()}");
            
        }
        
    }
}