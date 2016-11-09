using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class HumanPlayer : IPlayer
    {
        public string name
        {
            get;
            private set;
        }

        public HumanPlayer(string name)
        {
            this.name = name;
        }
        

        public RoShamBo CalculateNewRoshambo(List<Round> gameRounds)
        {
            return InputRoShamBo();
        }

        public RoShamBo InputRoShamBo()
        {
            string input = "";
            while (true)
            {
                Console.Write("Pick rock, paper or scissors: ");
                input = Console.ReadLine();
                if (input != (RoShamBo.paper.ToString()) && input != RoShamBo.rock.ToString() && input != RoShamBo.scissors.ToString())
                {
                    Console.WriteLine("Bad input.");
                }
                else break;
            }
            return (RoShamBo)Enum.Parse(typeof(RoShamBo), input);
        }
    }
}
