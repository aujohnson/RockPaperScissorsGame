using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class RockPaperScissorsRepo
    {
        private Player player1 = new Player();
        private Player player2 = new Player();

        int callCount = 0;

        public void SetMove(Move move)
        {
            if (callCount == 0)
            {
                callCount++;
                player1.Move = move;
            }
            else
            {
                callCount = 0;
                player2.Move = move;
            }
        }

        public List<Move> GetMoves()
        {
            return new List<Move>
            {
                player1.Move,
                player2.Move
            };
        }
    }
}
