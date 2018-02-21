using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess
{
    class FigureOnSquare
    {
        public Figure fiqure { get; private set; }
        public Square square { get; private set; }

        public FigureOnSquare(Figure figure , Square square)
        {
            this.fiqure = figure;
            this.square = square;
        }
    }
}
