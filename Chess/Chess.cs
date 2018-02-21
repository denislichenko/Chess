using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    public class Chess
    {
        public string fem { get; private set; };
        public Chess(string fem = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1") {
            this.fem = fem;
        }

        public Chess Move(string mov)
        {
            Chess nextChess = new Chess(fen);
            return nextChess; 
        }

        public char GetFigureAt(int x, int y)
        {
            return '.';
        }
    } 
}
