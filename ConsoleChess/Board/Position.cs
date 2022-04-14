﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleChess.Board
{
    class Position
    {
        public int Line { get; set; }
        public int Column { get; set; }

        public Position(int linha, int coluna)
        {
            Line = linha;
            Column = coluna;
        }

        public override string ToString()
        {
            return $"{Line}, {Column}";
        }
    }
}
