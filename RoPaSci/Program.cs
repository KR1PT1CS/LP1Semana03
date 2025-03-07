
using System;

namespace RoPaSci
{
    enum GameItem
    {
        Rock,
        Paper,
        Scissors
    }

    enum GameStatus
    {
        Draw,
        Player1Wins,
        Player2Wins
    }

    class Program
    {
        private static void Main(string[] args)
        {
          
            if (args.Length < 2)
            {
                Console.WriteLine("Por favor, forneça dois itens válidos do jogo (Rock, Paper, Scissors).");
                return;
            }

            
            GameItem player1;
            GameItem player2;

            try
            {
                player1 = Enum.Parse<GameItem>(args[0], true);
                player2 = Enum.Parse<GameItem>(args[1], true);

                
                GameStatus result = RockPaperScissors(player1, player2);

            
                switch (result)
                {
                    case GameStatus.Draw:
                        Console.WriteLine("É um empate!");
                        break;
                    case GameStatus.Player1Wins:
                        Console.WriteLine("Jogador 1 vence!");
                        break;
                    case GameStatus.Player2Wins:
                        Console.WriteLine("Jogador 2 vence!");
                        break;
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Entrada inválida. Use Rock, Paper ou Scissors.");
            }
        }

        private static GameStatus RockPaperScissors(GameItem player1, GameItem player2)
        {
           
            if (player1 == player2)
                return GameStatus.Draw;

          
            return (player1, player2) switch
            {
                (GameItem.Rock, GameItem.Scissors) => GameStatus.Player1Wins,
                (GameItem.Scissors, GameItem.Paper) => GameStatus.Player1Wins,
                (GameItem.Paper, GameItem.Rock) => GameStatus.Player1Wins,
                _ => GameStatus.Player2Wins
            };
        }
    }
}