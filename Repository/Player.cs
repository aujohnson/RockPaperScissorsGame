using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public enum Move
    {
        Rock, Paper, Scissors
    }

    public class Player
    {
        public Move Move { get; set; }
    }
}
