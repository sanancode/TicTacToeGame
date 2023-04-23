using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    internal class Game
    {
        public string Space { get; set; }
        public bool Empty { get; set; }

        public Game(string space, bool empty)
        {
            this.Space = space;
            Empty = empty;
        }
        public Game()
        {
        }
    }
}
