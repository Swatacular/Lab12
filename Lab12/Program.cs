using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    public enum RoShamBo { rock, paper, scissors}
    public enum Winner { player1, player2, tie}

    class Program
    {



        static List<Round> gameRounds = new List<Round>();

        static void Main(string[] args)
        {

            Console.Beep(500, 200);
            Console.Beep(2000, 200);
            Console.Beep(3000, 200);
            Console.Beep(3000, 200);

            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine();
            Console.Write("Enter your name: ");

            IPlayer humanPlayer = new HumanPlayer(Console.ReadLine());

            Console.WriteLine();
            Console.Write("Would you like to play against A.I. \"Randy\" or A.I. \"TomK\" (r/t)?: ");

            IPlayer computerPlayer;
            string input;
            while (true)
            {
                input = Console.ReadLine();
                if (input == "r")
                {
                    computerPlayer = new AI_Randy("AI_Randy");
                    break;
                }
                else if (input == "t")
                {
                    computerPlayer = new AI_TomK("AI_Tom");
                    break;
                }
            }
            Console.WriteLine();
            while (true)
            {
                RoShamBo humanPlayerRoShamBo;
                RoShamBo computerPlayerRoShamBo;
                Round currentRound;
                
                humanPlayerRoShamBo = humanPlayer.CalculateNewRoshambo(gameRounds);
                computerPlayerRoShamBo = computerPlayer.CalculateNewRoshambo(gameRounds);

                currentRound = new Round(humanPlayerRoShamBo, computerPlayerRoShamBo);

                Console.WriteLine(currentRound.ToString());
                gameRounds.Add(currentRound);
                
                Console.Write("Play again? (n to quit): ");
                input = Console.ReadLine();
                if (input == "n") break;
            }
        }
    }
}
