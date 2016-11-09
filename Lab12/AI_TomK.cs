using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class AI_TomK : IPlayer
    {
        public string name
        {
            get;
            private set;
        }

        public AI_TomK(string name)
        {
            this.name = name;
        }

        public RoShamBo CalculateNewRoshambo(List<Round> gameRounds)
        {
            return RoShamBo.rock;
        }
    }
}
