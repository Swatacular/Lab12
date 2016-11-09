using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Round
    {
        private RoShamBo player1RoShamBo;
        private RoShamBo player2RoShamBo;
        private Winner winner;

        public Round(RoShamBo player1RoShamBo, RoShamBo player2RoShamBo)
        {
            this.player1RoShamBo = player1RoShamBo;
            this.player2RoShamBo = player2RoShamBo;
            winner = CalculateWinner(Player1RoShamBo, Player2RoShamBo);
        }

        public RoShamBo Player1RoShamBo
        {
            get
            {
                return player1RoShamBo;
            }
        }

        public RoShamBo Player2RoShamBo
        {
            get
            {
                return player2RoShamBo;
            }
        }

        public Winner Winner
        {
            get
            {
                return winner;
            }
        }

        private Winner CalculateWinner(RoShamBo player1, RoShamBo player2)
        {
            if (player1 == player2)
            {
                return Winner.tie;
            }
            else if (((RoShamBo)(((int)player1 - 1 + 3) % 3)) == player2) //basically asking if player1s RoShamBo is countered by player2
            {
                return Winner.player2;
            }
            else if (((RoShamBo)(((int)player2 - 1 + 3) % 3)) == player1) //basically asking if player1s RoShamBo is countered by player2
            {
                return Winner.player1;
            }
            else throw new InvalidOperationException();
        }

        public override string ToString()
        {
            return Winner.ToString();
        }
    }
}
