using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class AI_Randy : IPlayer
    {

        public string name
        {
            get;
            private set;
        }

        public AI_Randy(string name)
        {
            this.name = name;
        }


        Random randy = new Random();
        public RoShamBo CalculateNewRoshambo(List<Round> gameRounds)
        {
            return (RoShamBo)randy.Next(0, 3);
        }
    }
}
